using System;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using ClipboardMonitorLite.Languages;
using ClipboardMonitorLite.FileOperations;
using ClipboardMonitorLite.SettingsManager;
using ClipboardMonitorLite.ClipboardActions;

namespace ClipboardMonitorLite.FormControls
{
    public class ButtonActions
    {
        private Form ActiveForm;
        private Settings _settings;
        private SaveHistory _history;
        private bool exitFileWritten;
        private ResourceManager resManager;
        private NotifyIcon NotificationIcon;
        private ClipboardManager _clipActions;
        public ButtonActions(ClipboardManager clipManager, NotifyIcon icon, Form form, Settings settings, SaveHistory history)
        {
            exitFileWritten = false;
            ActiveForm = form;
            _clipActions = clipManager;
            NotificationIcon = icon;
            _settings = settings;
            _history = history;
            _settings.PropertyChanged += _settings_PropertyChanged;
            _clipActions.PropertyChanged += _clipActions_PropertyChanged;
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

        private void _clipActions_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_settings.NotifyClipboardChange && !string.IsNullOrWhiteSpace(_clipActions.CurrentlyCopiedItem))
            {
                RefreshResourceManager();
                NotificationIcon.BalloonTipText = resManager.GetString("Notif_ItemCopied");
                NotificationIcon.BalloonTipTitle = resManager.GetString("Notif_Title_ItemCopied");
                NotificationIcon.ShowBalloonTip(4);
            }
        }

        private void _settings_PropertyChanged(object sender, PropertyChangedEventArgs e)
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

        public void ClearClipboardClick(object sender, EventArgs e)
        {
            _clipActions.ClearClip();
        }

        public void ClearHistoryClick(object sender, EventArgs e)
        {
            _clipActions.ClearHistory();
        }

        public void DonationClick(object sender, EventArgs e)
        {
            Process.Start(Resources.MainResources.url_KoFi);
        }

        public void ExitApplicationClick(object sender, EventArgs e)
        {
            if (_settings.SaveClipboardHistory && !_settings.WriteInRealTime && !exitFileWritten)
            {
                _history.WriteBeforeExit();
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
