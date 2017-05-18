using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.Storage;
using Windows.UI.Notifications;

namespace BackgroundTaskInternet
{
    public sealed class BGTaskInterface : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            BackgroundTaskDeferral _deferral = taskInstance.GetDeferral();
            updateInfor();
            _deferral.Complete();
        }


        private async void updateInfor()
        {
            string msg = "";
            string status = "";
            var local = ApplicationData.Current.LocalFolder;

            var file = await local.GetFileAsync(@"\Data\data.txt");
            IList<string> lines = await FileIO.ReadLinesAsync(file);
            foreach (var item in lines)
            {
                string[] d = item.Split(' ', '\n');
                status = d[0];
            }
            

            var networkInfor = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();


            // msg = (networkInfor == null) ? "No Internet Access" : "Internet Access";
            msg = (networkInfor == null) ? "No Internet Access" : status;


            XmlDocument xdoc = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150Text03);
            xdoc.GetElementsByTagName("text")[0].InnerText = msg;
            TileNotification notification = new TileNotification(xdoc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);

        }
    }
}
