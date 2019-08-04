using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClipboardLibrary
{
    public static class ClipChange
    {
        public static event EventHandler ClipboardUpdate;

        private static NotificationForm _form = new NotificationForm();

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
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
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
