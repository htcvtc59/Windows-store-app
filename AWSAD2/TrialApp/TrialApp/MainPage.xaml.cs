using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TrialApp
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

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            StorageFolder f = await Package.Current.InstalledLocation.GetFolderAsync("Data");
            StorageFile s = await f.GetFileAsync("WindowsStoreProxy.xml ");
            await CurrentAppSimulator.ReloadSimulatorAsync(s);

        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentAppSimulator.LicenseInformation.IsTrial)
            {
                txtDetail.Text = "Trial License";
            }
        }

        private async void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            LicenseInformation l = CurrentAppSimulator.LicenseInformation;
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    txtDetail.Text = "Trial License.\n";
                    var r = (l.ExpirationDate - DateTime.Now).Days;
                    txtDetail.Text += String.Format("Remaining days: {1}", l.ExpirationDate, r);

                });
        }

    }
}
