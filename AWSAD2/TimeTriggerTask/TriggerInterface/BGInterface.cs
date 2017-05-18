using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace TriggerInterface
{
    public sealed class BGInterface : IBackgroundTask
    {
         
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            BackgroundTaskDeferral _deferral = taskInstance.GetDeferral();
            updateTime();
            _deferral.Complete();

        }

        private void updateTime()
        {
            string str = DateTime.Now.ToString("hh:mm:ss");
            XmlDocument xdoc = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150Text03);
            xdoc.GetElementsByTagName("text")[0].InnerText = str;
            TileNotification notification = new TileNotification(xdoc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);

        }
    }
}
