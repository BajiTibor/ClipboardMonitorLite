using System;
using System.IO;
using SettingsLib;
using IWshRuntimeLibrary;
using System.Windows.Forms;
using System.ComponentModel;

namespace ClipboardMonitorLite.FileOperations
{
    /// <summary>
    /// Contains the methods for detecting whenever the application's
    /// shotcut exists inside the startup folder or not, and can create
    /// a new shortcut and place it there if needed, or remove the old one.
    /// This depends on the Settings class
    /// </summary>

    //I think this could be moved into Settings and class could be removed entirely
    public class LaunchOnStartup
    {
        private Settings _settings;
        //Shouldn't such things be in settings rather than in this class?
        private string shortcutName;
        private string shortcutPath;
        private string targetFileLocation;
        private string targetWorkingFolder;

        public LaunchOnStartup(Settings settings)
        {
            _settings = settings;
            shortcutName = "ClipboardManagerLite";
            shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            targetFileLocation = Application.ExecutablePath;
            targetWorkingFolder = AppDomain.CurrentDomain.BaseDirectory;
            _settings.PropertyChanged += PropertyChanged;
            CheckState();
        }

        private void PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("StartWithWindows"))
            {
                CheckState();
            }
        }

        public void CheckState()
        {
            string file = $"{shortcutPath}\\{shortcutName}.lnk";
            bool StartupFileExists = System.IO.File.Exists(file);
            if (_settings.StartWithWindows)
            {
                if (!StartupFileExists)
                {
                    CreateShortcut();
                }
            }
            else
            {
                if (StartupFileExists)
                {
                    System.IO.File.Delete(file);
                }
            }
        }

        private void CreateShortcut()
        {
            string shortcutLocation = Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "Start Clipboard Manager Lite";
            shortcut.TargetPath = targetFileLocation;
            shortcut.WorkingDirectory = targetWorkingFolder;
            shortcut.Save();
        }
    }
}
