using Squirrel;
using System;
using System.Threading.Tasks;

namespace ClipboardMonitorLite
{
    public class Updates
    {
        public async Task UpdateApplicationGitHub()
        {
            using (var manager = UpdateManager.GitHubUpdateManager(Constants.UpdateURL))
            {
                await manager.Result.UpdateApp();
            }
        }

        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager(@"C:\temp\releases"))
            {
                await manager.UpdateApp();
            }
        }

        public async void Btn_checkForUpdates_Click(object sender, EventArgs e)
        {
            await CheckForUpdates();
        }
    }
}
