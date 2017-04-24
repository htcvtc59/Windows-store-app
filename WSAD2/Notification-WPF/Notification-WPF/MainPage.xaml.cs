using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
using System;
using Windows.Data.Xml.Dom;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Notification_WPF
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


        }
        private void btnNotification_Click(object sender, RoutedEventArgs e)
        {
            ToastImageAndText04();
        }
        private void toastText01()
        {
            var notificationManager = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);
            var toastElement = notificationManager.GetElementsByTagName("text");
            toastElement[0].AppendChild(notificationManager.CreateTextNode("This is Notification Message"));
            var toastNotification = new ToastNotification(notificationManager);
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);

        }
        private void toastText02()
        {
            var notificationManager = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);
            var toastElement = notificationManager.GetElementsByTagName("text");
            toastElement[0].AppendChild(notificationManager.CreateTextNode("This is Notification Message"));
            toastElement[1].AppendChild(notificationManager.CreateTextNode("This is second line Notification"));
            var toastNotification = new ToastNotification(notificationManager);
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);

        }
        private void toastText03()
        {
            var notificationManager = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText03);
            var toastElement = notificationManager.GetElementsByTagName("text");
            toastElement[0].AppendChild(notificationManager.CreateTextNode("This is Notification Message"));
            toastElement[1].AppendChild(notificationManager.CreateTextNode("This is second line Notification"));
            var toastNotification = new ToastNotification(notificationManager);
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);

        }
        private void toastText04()
        {
            var notificationManager = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText04);
            var toastElement = notificationManager.GetElementsByTagName("text");
            toastElement[0].AppendChild(notificationManager.CreateTextNode("This is Notification Message"));
            toastElement[1].AppendChild(notificationManager.CreateTextNode("This is second line Notification"));
            toastElement[2].AppendChild(notificationManager.CreateTextNode("This is third line Notification"));
            var toastNotification = new ToastNotification(notificationManager);
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);

        }
        //ToastNotification with image
        private void ToastImageAndText01()
        {
            var notificationXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText01);
            var toastElement = notificationXml.GetElementsByTagName("text");
            toastElement[0].AppendChild(notificationXml.CreateTextNode("This is Notification Message"));
            var imageElement = notificationXml.GetElementsByTagName("image");
            imageElement[0].Attributes[1].NodeValue = "Assets/Logo.scale-100.png";
            var toastNotification = new ToastNotification(notificationXml);
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
        }
        private void ToastImageAndText02()
        {
            var notificationXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText02);
            var toastElement = notificationXml.GetElementsByTagName("text");
            toastElement[0].AppendChild(notificationXml.CreateTextNode("This is Notification Message"));
            toastElement[1].AppendChild(notificationXml.CreateTextNode("This is second line Notification"));
            var imageElement = notificationXml.GetElementsByTagName("image");
            imageElement[0].Attributes[1].NodeValue = "Assets/Logo.scale-100.png";
            var toastNotification = new ToastNotification(notificationXml);
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
        }
        private void ToastImageAndText03()
        {
            var notificationXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText03);
            var toastElement = notificationXml.GetElementsByTagName("text");
            toastElement[0].AppendChild(notificationXml.CreateTextNode("This is Notification Message"));
            toastElement[1].AppendChild(notificationXml.CreateTextNode("This is second line Notification"));
            var imageElement = notificationXml.GetElementsByTagName("image");
            imageElement[0].Attributes[1].NodeValue = "Assets/Logo.scale-100.png";
            var toastNotification = new ToastNotification(notificationXml);
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
        }
        private void ToastImageAndText04()
        {
            var notificationXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);
            var toastElement = notificationXml.GetElementsByTagName("text");
            toastElement[0].AppendChild(notificationXml.CreateTextNode("This is Notification Message"));
            toastElement[1].AppendChild(notificationXml.CreateTextNode("This is second line Notification"));
            toastElement[2].AppendChild(notificationXml.CreateTextNode("This is third line Notification"));
            var imageElement = notificationXml.GetElementsByTagName("image");
            imageElement[0].Attributes[1].NodeValue = "Assets/Logo.scale-100.png";
            var toastNotification = new ToastNotification(notificationXml);
            ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
        }


    }
}
