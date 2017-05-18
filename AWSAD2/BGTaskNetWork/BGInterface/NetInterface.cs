using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace BGInterface
{
    public sealed class NetInterface : IBackgroundTask
    {
        BackgroundTaskDeferral _deferral = null;
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            _deferral = taskInstance.GetDeferral();
            updateInfor();
            _deferral.Complete();


        }

        private void updateInfor()
        {
            var networkInfor = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
            string msg = "";
            msg = (networkInfor == null) ? "No Internet Access" : "Internet Access";
            XmlDocument xdoc = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150Text03);
            xdoc.GetElementsByTagName("text")[0].InnerText = msg;
            TileNotification notification = new TileNotification(xdoc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);

            var notificationXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText01);
            var toastElement = notificationXml.GetElementsByTagName("text");
            toastElement[0].AppendChild(notificationXml.CreateTextNode(msg));
            var imageElement = notificationXml.GetElementsByTagName("image");
            imageElement[0].Attributes[1].NodeValue = "Assets/google.jpg";
            var toastNotification = new ToastNotification(notificationXml);
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
        }
    }
}
