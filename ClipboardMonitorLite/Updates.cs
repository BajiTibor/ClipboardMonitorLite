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

        public async void Btn_checkForUpdates_Click(object sender, EventArgs e)
        {
            await UpdateApplicationGitHub();
        }

        public async void Update()
        {
            await UpdateApplicationGitHub();
        }

        public string GetVersionNumber()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            return versionInfo.FileVersion;
        }
    }
}
