using System;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using ClipboardMonitorLite.Cloud;
using ClipboardMonitorLite.Resources;
using System.Runtime.InteropServices;
using ClipboardMonitorLite.Exceptions;
using ClipboardMonitorLite.SettingsManager;

namespace ClipboardMonitorLite.ClipboardActions
{
    public class ClipboardManager : INotifyPropertyChanged
    {
        private ClipMessage _message;
        private string clipboardhistory;
        private CloudInteractions _cloud;
        private string currentlycopieditem;
        private static NotificationForm _form;
        private static ExceptionHandling _exception;
        public static event EventHandler ClipboardUpdate;
        public event PropertyChangedEventHandler PropertyChanged;
        private Settings _settings;
        private bool TextFromCloud;

        public ClipboardManager(CloudInteractions cloud, ClipMessage message, Settings settings)
        {
            ClipboardUpdate += ClipboardChangeEvent_ClipboardUpdate;
            _settings = settings;
            _exception = new ExceptionHandling();
            _form = new NotificationForm();
            _message = message;
            _cloud = cloud;
            _message.PropertyChanged += MessageChanged;
            TextFromCloud = false;
        }
         // So many issues, the machine name first doesn't appear then two of them appear, then this pattern continues.
        public void MessageFromCloud()
        {
            if (_settings.LimitTraffic && !_settings.SendOnly)
            {
                SetFromCloud();
            }
            else if (!_settings.LimitTraffic)
            {
                SetFromCloud();
            }
        }

        private void MessageChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "MachineName")
            {
                MessageFromCloud();
            }
        }

        private void SetFromCloud()
        {
            string CopiedItem = _message.Message;
            if (_settings.IncludeDeviceName)
                ClipboardHistory += $"{_message.MachineName} - ";
            ChangeTextOnClip(CopiedItem);
            TextFromCloud = true;
        }

        private void ClipboardChangeEvent_ClipboardUpdate(object sender, EventArgs e)
        {
            string CopiedItem = GetClipText();
            if (!string.IsNullOrWhiteSpace(CopiedItem) && !CopiedItem.Equals(currentlycopieditem))
            {
                CurrentlyCopiedItem = CopiedItem;
                var timeStamp = ($"{ DateTime.Now.ToShortTimeString() } - ");


                if (_settings.UseTimestamp)
                {
                    ClipboardHistory += ($"{timeStamp}{CopiedItem}\n");
                }
                else
                {
                    ClipboardHistory += ($"{CopiedItem}\n");
                }
                if (!TextFromCloud)
                {
                    if (_settings.OnlineMode)
                    {
                        try
                        {
                            if (!_settings.LimitTraffic)
                                _cloud.SendText(Constants.MachineName, CopiedItem);
                            else if (_settings.LimitTraffic && _settings.SendOnly)
                                _cloud.SendText(Constants.MachineName, CopiedItem);
                        }
                        catch (Exception ex)
                        {
                            _exception.Handle(ex);
                        }
                    }
                }
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
