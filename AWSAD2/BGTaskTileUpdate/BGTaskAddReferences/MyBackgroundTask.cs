using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;

namespace BGTaskAddReferences
{
    public sealed class MyBackgroundTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            BackgroundTaskDeferral deferral = taskInstance.GetDeferral();
            UpdateStatusAndTime();
            deferral.Complete();
        }
        public void UpdateStatusAndTime()
        {
            var tileContent = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquareText03);
            var tileLines = tileContent.SelectNodes("tile/visual/binding/text");
            var networkStatus = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
            tileLines[0].InnerText = (networkStatus == null) ? "No Network" : networkStatus.GetDomainConnectivityLevel().ToString();
            tileLines[1].InnerText = DateTime.Now.ToString("MM/dd/yyyy");
            tileLines[2].InnerText = DateTime.Now.ToString("HH:mm:ss");
            var notification = new TileNotification(tileContent);
            var updater = TileUpdateManager.CreateTileUpdaterForApplication();
            updater.Update(notification);

        }
    }
}
