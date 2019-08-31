using System;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using ClipboardMonitorLite.Cloud;
using ClipboardMonitorLite.Resources;
using System.Runtime.InteropServices;
using ClipboardMonitorLite.Exceptions;
using Microsoft.AspNetCore.SignalR.Client;

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
        //private ConnectionState _connectionState;

        public ClipboardManager(CloudInteractions cloud, ClipMessage message)
        {
            ClipboardUpdate += ClipboardChangeEvent_ClipboardUpdate;
            _exception = new ExceptionHandling();
            _form = new NotificationForm();
            _message = message;
            _cloud = cloud;
            _message.PropertyChanged += MessageChanged;
        }

        private void MessageChanged(object sender, EventArgs e)
        {
            SetFromCloud(sender, e);
        }

        private void SetFromCloud(object sender, EventArgs e)
        {
            string CopiedItem = _message.Message;
            ChangeTextOnClip(CopiedItem);
        }

        private void ClipboardChangeEvent_ClipboardUpdate(object sender, EventArgs e)
        {
            string CopiedItem = GetClipText();
            if (!string.IsNullOrWhiteSpace(CopiedItem) && !CopiedItem.Equals(currentlycopieditem))
            {
                CurrentlyCopiedItem = CopiedItem;
                ClipboardHistory += ($"{CopiedItem}\n");
                //if (_connectionState.IsConnectionAlive.Equals(HubConnectionState.Connected))
                    _cloud.SendText(Constants.MachineName, CopiedItem);
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

        [STAThread]
        public void ChangeTextOnClip(string text)
        {
            try
            {
                Methods.OpenClipboard(IntPtr.Zero);
                var ptr = Marshal.StringToHGlobalUni(text);
                Methods.SetClipboardData(13, ptr);
            }
            catch (Exception ex)
            {
                _exception.Handle(ex);
            }
            finally
            {
                Methods.CloseClipboard();
            }
        }

        public string GetClipText()
        {
            if (!Methods.IsClipboardFormatAvailable(Methods.CF_UNICODETEXT))
                return null;

            try
            {
                if (!Methods.OpenClipboard(IntPtr.Zero))
                    return null;

                IntPtr handle = Methods.GetClipboardData(Methods.CF_UNICODETEXT);
                if (handle == IntPtr.Zero)
                    return null;

                IntPtr pointer = IntPtr.Zero;

                try
                {
                    pointer = Methods.GlobalLock(handle);
                    if (pointer == IntPtr.Zero)
                        return null;

                    int size = Methods.GlobalSize(handle);
                    byte[] buff = new byte[size];

                    Marshal.Copy(pointer, buff, 0, size);

                    return Encoding.Unicode.GetString(buff).TrimEnd('\0');
                }
                finally
                {
                    if (pointer != IntPtr.Zero)
                        Methods.GlobalUnlock(handle);
                }
            }
            finally
            {
                Methods.CloseClipboard();
            }
        }

        internal static class Methods
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
            public static extern bool SetClipboardData(uint uFormat, IntPtr data);

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
                Methods.SetParent(Handle, Methods.HWND_MESSAGE);
                Methods.AddClipboardFormatListener(Handle);
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == Methods.WM_CLIPBOARDUPDATE)
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
