using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Storage;
using System.Runtime.Serialization.Json;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_AWSAD1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Client Config


        const string client_id = "295286002263-r8c79v1ck6ahm0u52p5cejlh7rcu911m.apps.googleusercontent.com";
        const string client_secret = "Ss6MpCqIUVOt3MHcSlJzQuZp";
        const string project_id = "gmail-164809";
        const string auth_uri = "https://accounts.google.com/o/oauth2/auth";
        const string token_uri = "https://accounts.google.com/o/oauth2/token";
        const string auth_provider_x509_cert_url = "https://www.googleapis.com/oauth2/v1/certs";
        const string redirect_uris = "urn:ietf:wg:oauth:2.0:oob" + "http://localhost";


        public MainPage()
        {
            this.InitializeComponent();

        }








        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool show;
            show = (ShowH.Visibility == Visibility.Visible) ? true : false;
            ShowH.Visibility = (show == false) ? Visibility.Visible : Visibility.Collapsed;

            
            threadFill.Fill = new SolidColorBrush(Colors.OrangeRed);
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, object e)
        {
            threadFill.Fill = new SolidColorBrush(Colors.Orange);

        }




    }
}

