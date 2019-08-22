using Squirrel;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.Updates
{
    public class Update
    {
        public async Task FetchUpdateInfo()
        {
            using (var manager = await UpdateManager.GitHubUpdateManager(Resources.Constants.UpdateURL))
            {
                UpdateInfo result;
                result = await manager.CheckForUpdate();

                if (!result.ReleasesToApply.Count.Equals(0))
                {
                    DialogResult DiagResult = MessageBox.Show("Update ready! Would you like to install it now?", "Update",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DiagResult.Equals(DialogResult.Yes))
                    {
                        await manager.UpdateApp();
                        NotifyIcon notification = new NotifyIcon();
                        notification.BalloonTipText = "Please restart the application at your earliest convenience.";
                        notification.BalloonTipTitle = "Update installed";
                        notification.ShowBalloonTip(4);
                    }
                }
            }
        }
    }
}
