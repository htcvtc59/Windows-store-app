using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Syndication;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ParseRss
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<NewYorkTime> lstNYT = NewYorkTime.listNewYT;
            gridviewNYT.ItemsSource = lstNYT;
            imgHomePage.Source = new BitmapImage(new Uri(NewYorkTime.GetImaggeHome().imgHome));

        }
        
       

        private void gridviewNYT_ItemClick(object sender, ItemClickEventArgs e)
        {
            var nyt = (NewYorkTime)e.ClickedItem;
            gridHomePage.Visibility = Visibility.Collapsed;
            gridPageItem.Visibility = Visibility.Visible;
            webviewItem.Source = new Uri(nyt.itemlink);
                
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            List<NewYorkTime> lstNYT = NewYorkTime.listNewYT;
            gridviewNYT.ItemsSource = lstNYT;
            gridHomePage.Visibility = Visibility.Visible;
            gridPageItem.Visibility = Visibility.Collapsed;
        }

        private void btnBackHome_Click(object sender, RoutedEventArgs e)
        {
            List<NewYorkTime> lstNYT = NewYorkTime.listNewYT;
            gridviewNYT.ItemsSource = lstNYT;
            gridHomePage.Visibility = Visibility.Visible;
            gridPageItem.Visibility = Visibility.Collapsed;
        }
    }
}
