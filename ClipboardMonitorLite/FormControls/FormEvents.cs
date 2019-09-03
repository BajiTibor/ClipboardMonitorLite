using System;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using ClipboardMonitorLite.FileOperations;
using SettingsLib;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.Languages.LanguageControl;

namespace ClipboardMonitorLite.FormControls
{
    public class FormEvents
    {
        private Form ActiveForm;
        private Settings _settings;
        private bool exitFileWritten;
        private ResourceManager resManager;
        private NotifyIcon NotificationIcon;
        private WriteHistoryFile _writeHistory;
        private ClipboardManager _clipboardManager;
        public FormEvents(ClipboardManager clipManager, NotifyIcon icon, Form form, Settings settings, WriteHistoryFile history)
        {
            exitFileWritten = false;
            ActiveForm = form;
            _clipboardManager = clipManager;
            NotificationIcon = icon;
            _settings = settings;
            _writeHistory = history;
            _settings.PropertyChanged += ChangeIconStyle;
            _clipboardManager.PropertyChanged += ShowCopyNotification;
            SetIconStyle();
            SetWindowStartupState();
        }

        private void SetWindowStartupState()
        {
            if (_settings.StartMinimized.Equals(true))
            {
                ActiveForm.ShowInTaskbar = false;
                ActiveForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void ShowCopyNotification(object sender, PropertyChangedEventArgs e)
        {
            if (_settings.NotifyClipboardChange && !string.IsNullOrWhiteSpace(_clipboardManager.CurrentlyCopiedItem))
            {
                RefreshResourceManager();
                NotificationIcon.BalloonTipText = resManager.GetString("Notif_ItemCopied");
                NotificationIcon.BalloonTipTitle = resManager.GetString("Notif_Title_ItemCopied");
                NotificationIcon.ShowBalloonTip(4);
            }
        }

        private void ChangeIconStyle(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("UsingWhiteTrayIcon"))
            {
                SetIconStyle();
            }
        }

        public void OpenFileBrowserClick(object sender, EventArgs e)
        {
            RefreshResourceManager();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = resManager.GetString("File_TextFile");
            dialog.Title = resManager.GetString("SaveAsTextFile");
            dialog.ShowDialog();

            if (!dialog.FileName.Equals(string.Empty))
            {
                _settings.HistoryFileLocation = dialog.FileName;
            }

        }

        public void LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        public void ClearClipboardClick(object sender, EventArgs e)
        {
            _clipboardManager.ClearClip();
        }

        public void ClearHistoryClick(object sender, EventArgs e)
        {
            _clipboardManager.ClearHistory();
        }

        public void DonationClick(object sender, EventArgs e)
        {
            Process.Start(Resources.MainResources.url_KoFi);
        }

        public void ExitApplicationClick(object sender, EventArgs e)
        {
            if (_settings.SaveClipboardHistory && !_settings.WriteInRealTime && !exitFileWritten)
            {
                _writeHistory.WriteBeforeExit();
                exitFileWritten = true;
            }
            NotificationIcon.Visible = false;
            NotificationIcon.Dispose();
            Application.Exit();
        }

        public void RestoreWindowClick(object sender, EventArgs e)
        {
            if (ActiveForm.ShowInTaskbar.Equals(false))
            {
                ActiveForm.ShowInTaskbar = true;
            }
            ActiveForm.WindowState = FormWindowState.Normal;
            ActiveForm.Focus();
        }

        public void FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing) && _settings.MinimizeOnClose)
            {
                e.Cancel = true;
                ActiveForm.ShowInTaskbar = false;
                ActiveForm.WindowState = FormWindowState.Minimized;
            }
            else
            {
                ExitApplicationClick(sender, e);
            }
        }

        private void SetIconStyle()
        {
            if (_settings.UsingWhiteTrayIcon)
                NotificationIcon.Icon = Resources.MainResources.icon_white;
            else
                NotificationIcon.Icon = Resources.MainResources.icon_dark;
        }

        private void RefreshResourceManager()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[_settings.CurrentlySelectedLanguage]}",
                Assembly.GetExecutingAssembly());
        }
    }
}
