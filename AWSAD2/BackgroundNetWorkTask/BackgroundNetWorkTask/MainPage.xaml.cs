using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Connectivity;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BackgroundNetWorkTask
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string internetProfile = "Not contected to Internet";
        string networkAdapterId = "Not network adapter id";
        private CoreDispatcher NetworkStatusWithInternetPresentDispatcher;



        public MainPage()
        {
            this.InitializeComponent();
            NetworkStatusWithInternetPresentDispatcher = Window.Current.CoreWindow.Dispatcher;
            UpdateStatusAndTime();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            foreach (var task in BackgroundTaskRegistration.AllTasks)
            {
                if (task.Value.Name == BackgroundTaskSample.SampleBackgroundWithConditionName)
                {
                    var isTaskRegistered = RegisterCompleteHandlerforBackgroundTask(task.Value);
                    UpdateButton(isTaskRegistered);
                    UpdateStatusAndTime();
                }
            }

        }
        private void UpdateStatusAndTime()
        {
            var networkStatus = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
            txtTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            ApplicationDataContainer localSetting = ApplicationData.Current.LocalSettings;
            if (networkStatus != null)
            {
                ConnectionProfile profile = NetworkInformation.GetInternetConnectionProfile();
                if (profile == null)
                {
                    internetProfile = "Not contected to Internet";
                    networkAdapterId = "Not network adapter id";
                }
                else
                {
                    internetProfile = networkStatus.ProfileName;
                    var networkAdapterInfo = networkStatus.NetworkAdapter;
                    if (networkAdapterInfo == null)
                    {
                        networkAdapterId = "Not network adapter id";
                    }
                    else
                    {
                        networkAdapterId = networkAdapterInfo.NetworkAdapterId.ToString();
                    }
                }
                txtNetworkAdapter.Text = networkAdapterId;
                txtInternetProfile.Text = internetProfile;
                txtLevel.Text = networkStatus.GetNetworkConnectivityLevel().ToString();
            }
            else
            {
                txtLevel.Text = "No NetWork";
            }


        }
        private bool RegisterCompleteHandlerforBackgroundTask(IBackgroundTaskRegistration task)
        {
            bool taskRegistered = false;
            try
            {
                taskRegistered = true;
            }
            catch (Exception )
            {
            }
            return taskRegistered;
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var connectionProfile = NetworkInformation.GetInternetConnectionProfile();
                if (connectionProfile != null)
                {
                    internetProfile = connectionProfile.ProfileName;
                    var networkAdapterInfo = connectionProfile.NetworkAdapter;
                    if (networkAdapterInfo != null)
                    {
                        networkAdapterId = networkAdapterInfo.NetworkAdapterId.ToString();
                    }
                    else
                    {
                        networkAdapterId = "Not network adapter id";
                    }
                }
                else
                {
                    internetProfile = "Not contected to Internet";
                    networkAdapterId = "Not network adapter id";
                }
                var task = BackgroundTaskSample.RegisterBackgroundTask(BackgroundTaskSample.SampleBackgroundTaskEntryPoint,
                    BackgroundTaskSample.SampleBackgroundWithConditionName,
                    new SystemTrigger(SystemTriggerType.NetworkStateChange, false), null);

                UpdateButton(true);




            }
            catch (Exception)
            {

            }
        }

        private void unregisterButton_Click(object sender, RoutedEventArgs e)
        {
            BackgroundTaskSample.UnregisterBackgroundTasks(BackgroundTaskSample.SampleBackgroundWithConditionName);
            UpdateButton(false);
        }

        private void UpdateButton(bool registered)
        {
            RegisterButton.IsEnabled = !registered;
            unregisterButton.IsEnabled = registered;
        }
    }
}
