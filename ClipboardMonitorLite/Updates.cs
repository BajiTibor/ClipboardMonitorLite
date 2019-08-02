using Squirrel;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;

namespace ClipboardMonitorLite
{
    public class Updates
    {
        private async Task UpdateApplicationGitHub()
        {
            using (var manager = await UpdateManager.GitHubUpdateManager(Constants.UpdateURL))
            {
                await manager.UpdateApp();
            }
        }

        private async Task FetchUpdateInfo()
        {
            Properties.Settings.Default.UpdateInformation = "";
            Properties.Settings.Default.UpdateInformation += ("Starting update...\n");
            using (var manager = await UpdateManager.GitHubUpdateManager(Constants.UpdateURL))
            {
                UpdateInfo result;
                result = await manager.CheckForUpdate();

                Properties.Settings.Default.UpdateInformation += ("Update info:\n" +
                    $"Currently installed version: {result.CurrentlyInstalledVersion.Version}\n" +
                    $"Latest version released: {result.FutureReleaseEntry.Version}\n");
                if (result.ReleasesToApply.Count == 0)
                {
                    Properties.Settings.Default.NeedsUpdate = false;
                    Properties.Settings.Default.UpdateInformation += "No need to update.";
                }
                else
                {
                    Properties.Settings.Default.NeedsUpdate = true;
                    await UpdateApplicationGitHub();
                    Properties.Settings.Default.UpdateInformation += "Update found!\n" +
                        "Please restart the application to install!";
                }
            }
        }

        public async void Btn_checkForUpdates_Click(object sender, EventArgs e)
        {
            await FetchUpdateInfo();
        }

        public async void Update()
        {
            await FetchUpdateInfo();
        }

        public string GetVersionNumber()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            return versionInfo.FileVersion;
        }
    }
}
