using System;
using SettingsLib;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using CloudConnectionLib.Messages;
using ClipboardMonitorLite.Resources;
using System.Runtime.InteropServices;
using ClipboardMonitorLite.Exceptions;

namespace ClipboardMonitorLite.ClipboardActions
{
    public class ClipboardManager : INotifyPropertyChanged
    {
        private Settings _settings;
        private bool TextFromCloud;
        private string clipboardhistory;
        private string currentlycopieditem;
        private static NotificationForm form;
        private SignalRMessage _inboundMessage;
        private SignalRMessage _outgoingMessage;
        private static ExceptionHandling _exception;
        public static event EventHandler ClipboardUpdate;
        public event PropertyChangedEventHandler PropertyChanged;

        public ClipboardManager(SignalRMessage inboundMessage, SignalRMessage outgoingMessage, Settings settings)
        {
            ClipboardUpdate += ClipboardChangeEvent_ClipboardUpdate;
            _settings = settings;
            _exception = new ExceptionHandling();
            form = new NotificationForm();
            _inboundMessage = inboundMessage;
            _outgoingMessage = outgoingMessage;
            TextFromCloud = false;
            _inboundMessage.PropertyChanged += _inboundMessage_PropertyChanged;
        }

        private void _inboundMessage_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("MachineName"))
            {
                TextFromCloud = true;
                if (_settings.IncludeDeviceName)
                {
                    ClipboardHistory += $"{_inboundMessage.MachineName} - ";
                }
                ChangeTextOnClip(_inboundMessage.Message);
            }
        }

        private void ClipChanged(bool NeedsToSend = true)
        {
            string CurrentCopy = GetClipText();
            if (!string.IsNullOrWhiteSpace(CurrentCopy) && !CurrentCopy.Equals(currentlycopieditem))
            {
                CurrentlyCopiedItem = CurrentCopy;
                var timeStamp = ($"{ DateTime.Now.ToShortTimeString() } - ");
                if (_settings.UseTimestamp)
                {
                    ClipboardHistory += ($"{timeStamp}{CurrentCopy}\n");
                }
                else
                {
                    ClipboardHistory += ($"{CurrentCopy}\n");
                }
                if (_settings.OnlineMode && NeedsToSend)
                {
                    try
                    {
                        _outgoingMessage.Message = CurrentCopy;
                        _outgoingMessage.MachineName = Constants.MachineName;
                    }
                    catch (Exception ex)
                    {
                        _exception.Handle(ex);
                    }
                }
            }

        }

        private void ClipboardChangeEvent_ClipboardUpdate(object sender, EventArgs e)
        {
            if (!TextFromCloud)
            {
                ClipChanged();
            }
            else
            {
                ClipChanged(false);
                TextFromCloud = false;
            }
        }

        public void ClearClip()
        {
            ChangeTextOnClip(string.Empty);
        }

        public void ClearHistory()
        {
            ClipboardHistory = string.Empty;
        }

        public void ChangeTextOnClip(string text)
        {
            try
            {
                UnsafeNativeMethods.OpenClipboard(IntPtr.Zero);
                var ptr = Marshal.StringToHGlobalUni(text);
                UnsafeNativeMethods.SetClipboardData(13, ptr);
            }
            catch (Exception ex)
            {
                _exception.Handle(ex);
            }
            finally
            {
                UnsafeNativeMethods.CloseClipboard();
            }
        }

        public string GetClipText()
        {
            if (!UnsafeNativeMethods.IsClipboardFormatAvailable(UnsafeNativeMethods.CF_UNICODETEXT))
                return null;

            try
            {
                if (!UnsafeNativeMethods.OpenClipboard(IntPtr.Zero))
                    return null;

                IntPtr handle = UnsafeNativeMethods.GetClipboardData(UnsafeNativeMethods.CF_UNICODETEXT);
                if (handle == IntPtr.Zero)
                    return null;

                IntPtr pointer = IntPtr.Zero;

                try
                {
                    pointer = UnsafeNativeMethods.GlobalLock(handle);
                    if (pointer == IntPtr.Zero)
                        return null;

                    int size = UnsafeNativeMethods.GlobalSize(handle);
                    byte[] buff = new byte[size];

                    Marshal.Copy(pointer, buff, 0, size);

                    return Encoding.Unicode.GetString(buff).TrimEnd('\0');
                }
                finally
                {
                    if (pointer != IntPtr.Zero)
                        UnsafeNativeMethods.GlobalUnlock(handle);
                }
            }
            finally
            {
                UnsafeNativeMethods.CloseClipboard();
            }
        }

        internal static class UnsafeNativeMethods
        {
            public const int WM_CLIPBOARDUPDATE = 0x031D;
            public static IntPtr HWND_MESSAGE = new IntPtr(-3);
            public const uint CF_UNICODETEXT = 13U;

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AddClipboardFormatListener(IntPtr hwnd);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

            [DllImport("user32.dll")]
            public static extern bool OpenClipboard(IntPtr hWndNewOwner);

            [DllImport("user32.dll")]
            public static extern IntPtr GetClipboardData(uint uFormat);

            [DllImport("user32.dll")]
            public static extern bool CloseClipboard();

            [DllImport("user32.dll")]
            public static extern UIntPtr SetClipboardData(uint uFormat, IntPtr data); // Changed

            [DllImport("User32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool IsClipboardFormatAvailable(uint format);

            [DllImport("Kernel32.dll", SetLastError = true)]
            public static extern IntPtr GlobalLock(IntPtr hMem);

            [DllImport("Kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GlobalUnlock(IntPtr hMem);

            [DllImport("Kernel32.dll", SetLastError = true)]
            public static extern int GlobalSize(IntPtr hMem);
        }

        public static void OnClipboardUpdate(EventArgs e)
        {
            try
            {
                ClipboardUpdate?.Invoke(null, e);
            }
            catch (Exception ex)
            {
                _exception.Handle(ex);
            }
        }

        private class NotificationForm : Form
        {
            public NotificationForm()
            {
                UnsafeNativeMethods.SetParent(Handle, UnsafeNativeMethods.HWND_MESSAGE);
                UnsafeNativeMethods.AddClipboardFormatListener(Handle);
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == UnsafeNativeMethods.WM_CLIPBOARDUPDATE)
                {
                    OnClipboardUpdate(null);
                }
                base.WndProc(ref m);
            }
        }

        public string ClipboardHistory
        {
            get
            {
                return clipboardhistory;
            }
            set
            {
                clipboardhistory = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("ClipboardHistory"));
            }
        }
        public string CurrentlyCopiedItem
        {
            get
            {
                return currentlycopieditem;
            }
            set
            {
                currentlycopieditem = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CurrentlyCopiedItem"));
            }
        }

        private void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
