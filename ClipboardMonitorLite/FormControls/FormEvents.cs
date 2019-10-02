using System;
using SettingsLib;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using ClipboardMonitorLite.FileOperations;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.Languages.LanguageControl;

namespace ClipboardMonitorLite.FormControls
{
    /// <summary>
    /// Class that handles events that happen on a Form.
    /// </summary>
    public class FormEvents
    {
        private Form ActiveForm;
        private Settings _settings;
        private bool exitFileWritten;
        private ResourceManager resManager;
        private NotifyIcon NotificationIcon;
        private WriteHistoryFile _writeHistory;
        private ClipboardManager _clipboardManager;
        private OnlineSettings _onlineSettings;
        public FormEvents(ClipboardManager clipManager, NotifyIcon icon, Form form, Settings settings, WriteHistoryFile history,
            OnlineSettings onlineSettings)
        {
            exitFileWritten = false;
            ActiveForm = form;
            _clipboardManager = clipManager;
            NotificationIcon = icon;
            _settings = settings;
            _writeHistory = history;
            _settings.PropertyChanged += ChangeIconStyle;
            _clipboardManager.PropertyChanged += ShowCopyNotification;
            _settings.PropertyChanged += ShowPasswordChanged;
            _onlineSettings = onlineSettings;
            SetIconStyle();
            SetWindowStartupState();
        }

        private void ShowPasswordChanged(object sender, PropertyChangedEventArgs e)
        {
            TextBox Password = ActiveForm.Controls.Find("Txt_Password", false)[0] as TextBox;
            if (_settings.ShowPassword)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }

        public void GenerateNewGroupId(object sender, EventArgs e)
        {
            _onlineSettings.GroupId = Guid.NewGuid();
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

        /// <summary>
        /// Sets the notification icon's style on the taskbar.
        /// </summary>
        private void SetIconStyle()
        {
            if (_settings.UsingWhiteTrayIcon)
                NotificationIcon.Icon = Resources.MainResources.icon_white;
            else
                NotificationIcon.Icon = Resources.MainResources.icon_dark;
        }

        /// <summary>
        /// Creates a new ResourceManager object with the new language.
        /// Usually gets called when the language has changed.
        /// </summary>
        private void RefreshResourceManager()
        {
            resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[_settings.CurrentlySelectedLanguage]}",
                Assembly.GetExecutingAssembly());
        }
    }
}
