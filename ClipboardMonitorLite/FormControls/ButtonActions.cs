﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipboardMonitorLite.ClipboardActions;
using ClipboardMonitorLite.SettingsManager;
using System.Resources;
using ClipboardMonitorLite.Languages;
using System.Reflection;

namespace ClipboardMonitorLite.FormControls
{
    public class ButtonActions
    {
        private ClipboardManager _clipActions;
        private NotifyIcon NotificationIcon;
        private FormControl _formControl;
        private Form ActiveForm;
        private Settings _settings;
        private ResourceManager resManager;
        public ButtonActions(ClipboardManager clipManager, NotifyIcon icon, Form form, Settings settings)
        {
            ActiveForm = form;
            _clipActions = clipManager;
            NotificationIcon = icon;
            _settings = settings;
            _formControl = new FormControl();
            _settings.PropertyChanged += _settings_PropertyChanged;
            _clipActions.PropertyChanged += _clipActions_PropertyChanged;
            SetIconStyle();
        }

        private void _clipActions_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_settings.NotifyClipboardChange)
            {
                resManager = new ResourceManager($"ClipboardMonitorLite.Languages.lang_{LanguageCode.LanguageList[_settings.CurrentlySelectedLanguage]}",
                Assembly.GetExecutingAssembly());

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

        public void ShowOptionsWindowClick(object sender, EventArgs e)
        {

        }

        public void ExitApplicationClick(object sender, EventArgs e)
        {
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
        }

        private void SetIconStyle()
        {
            if (_settings.UsingWhiteTrayIcon)
                NotificationIcon.Icon = Resources.MainResources.icon_white;
            else
                NotificationIcon.Icon = Resources.MainResources.icon_dark;
        }
    }
}
