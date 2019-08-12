using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClipboardMonitorLite.ClipboardActions
{
    public class ClipboardManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public static event EventHandler ClipboardUpdate;
        static NotificationForm _form = new NotificationForm();
        string clipboardhistory;
        string currentlycopieditem;

        public ClipboardManager()
        {
            ClipboardUpdate += ClipboardChangeEvent_ClipboardUpdate;
        }

        private void ClipboardChangeEvent_ClipboardUpdate(object sender, EventArgs e)
        {
            string CopiedItem = GetClipText();
            if (!string.IsNullOrWhiteSpace(CopiedItem) && !CopiedItem.Equals(currentlycopieditem))
            {
                CurrentlyCopiedItem = CopiedItem;
                ClipboardHistory += ($"{CopiedItem}\n");
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

        public string GetClipText()
        {
            return Clipboard.GetText();
        }

        public void ClearClip()
        {
            Clipboard.Clear();
        }

        public void ClearHistory()
        {
            ClearClip();
        }

        internal static class Methods
        {
            public const int WM_CLIPBOARDUPDATE = 0x031D;
            public static IntPtr HWND_MESSAGE = new IntPtr(-3);

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AddClipboardFormatListener(IntPtr hwnd);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        }

        public static void OnClipboardUpdate(EventArgs e)
        {
            try
            {
                ClipboardUpdate?.Invoke(null, e);
            }
            catch
            {
                
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
    }
}
