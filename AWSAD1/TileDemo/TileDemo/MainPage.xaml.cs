using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TileDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            TileUpdateManager.CreateTileUpdaterForApplication().EnableNotificationQueue(true);
        }

        private void btnUpdateTitle_Click(object sender, RoutedEventArgs e)
        {
            //XmlDocument xmlTile = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare310x310Text01);
            //xmlTile.GetElementsByTagName("text")[0].InnerText = "Hello";
            //xmlTile.GetElementsByTagName("text")[1].InnerText = "Beautiful app";
            //xmlTile.GetElementsByTagName("text")[2].InnerText = "Beautiful Title";
            //TileNotification notification = new TileNotification(xmlTile);
            //TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);
            XmlDocument xmlTile = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare310x310ImageAndText01);
            xmlTile.GetElementsByTagName("text")[0].InnerText = "Hello";
            ((XmlElement)xmlTile.GetElementsByTagName("image")[0]).SetAttribute("src", "http://newstotalk.com/wp-content/uploads/2013/10/Apple-Released-1-Pound-iPad-Air-620x300.png");
            TileNotification notification = new TileNotification(xmlTile);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(notification);
        }
    }
}
