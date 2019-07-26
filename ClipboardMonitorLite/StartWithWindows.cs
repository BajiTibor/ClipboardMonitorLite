using Microsoft.Win32;
using System.Security.Principal;
using System.Reflection;
using System.Linq;
using System.Diagnostics;
using System;

namespace ClipboardMonitorLite
{
    public class StartWithWindows
    {
        static bool IsProgramElevated
        {
            get
            {
                return WindowsIdentity.GetCurrent().Owner
                        .IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid);
            }
        }
        public void RunChecks()
        {
            if (!IsProgramElevated && !Properties.Settings.Default.CanRestartAsAdmin)
            {
                return;
            }
            else if (!IsProgramElevated)
            {
                var exeFile = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo appStartInfo = new ProcessStartInfo(exeFile);
                appStartInfo.Verb = "runas";
                Properties.Settings.Default.CanRestartAsAdmin = false;
                Process.Start(appStartInfo);
                Environment.Exit(0);
                return;
            }
            else
            {
                Properties.Settings.Default.CanRestartAsAdmin = true;
                CheckStartupStatus();
            }
        }

        public void CheckStartupStatus()
        {
            if (Properties.Settings.Default.OpenWithWin)
            {
                if (!RegistryKeyExists())
                {
                    AddAppToStartup();
                }
            }
            else
            {
                if (RegistryKeyExists())
                {
                    RemoveAppFromStartup();
                }
            }
        }

        private string AppName = "ClipboardMonitorLite";
        private void AddAppToStartup()
        {
            using (RegistryKey key = Registry.CurrentUser
                .OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                key.SetValue(AppName, $"{Assembly.GetEntryAssembly().Location}");
            }
        }

        private void RemoveAppFromStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                key.DeleteValue(AppName, true);
            }
        }

        private bool RegistryKeyExists()
        {
            RegistryKey autoStart = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            return (autoStart.GetValueNames().Contains(AppName));
        }
    }
}
