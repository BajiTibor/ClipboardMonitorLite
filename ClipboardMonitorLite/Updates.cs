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
            using (var manager = await UpdateManager.GitHubUpdateManager(Constants.UpdateURL))
            {
                UpdateInfo result;
                result = await manager.CheckForUpdate();


                if (result.ReleasesToApply.Count == 0)
                {

                }
                else
                {
 
                    await UpdateApplicationGitHub();
 
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
