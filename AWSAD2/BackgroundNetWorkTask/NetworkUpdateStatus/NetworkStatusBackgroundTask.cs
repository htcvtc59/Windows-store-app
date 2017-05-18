using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Networking.Connectivity;
using Windows.Storage;

namespace NetworkUpdateStatus
{
    public sealed class NetworkStatusBackgroundTask : IBackgroundTask
    {
        ApplicationDataContainer localSetting = ApplicationData.Current.LocalSettings;
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            Debug.WriteLine("Background" + taskInstance.Task.Name + "Starting....");
            taskInstance.Canceled += new BackgroundTaskCanceledEventHandler(OnCanceled);
            try
            {
                NetworkStateChangeEventDetails details = taskInstance.TriggerDetails as NetworkStateChangeEventDetails;
                localSetting.Values["HasNewConnectionCost"] = details.HasNewConnectionCost ? "New Connection Cost" : null;
                localSetting.Values["HasNewDomainConnectivityLevel"] = details.HasNewDomainConnectivityLevel ? "New Domain Connectivity Level" : null;
                localSetting.Values["HasNewHostNameList"] = details.HasNewHostNameList ? "New Host Name List" : null;
                localSetting.Values["HasNewInternetConnectionProfile"] = details.HasNewInternetConnectionProfile ? "New Internet Connection Profile" : null;
                localSetting.Values["HasNewNetworkConnectivityLevel"] = details.HasNewNetworkConnectivityLevel ? "New Network Connectivity Level" : null;

                ConnectionProfile profile = NetworkInformation.GetInternetConnectionProfile();
                if (profile == null)
                {
                    localSetting.Values["InternetProfile"] = "Not connected to Internet";
                    localSetting.Values["NetworkAdapterId"] = "Not connected to Internet";
                }
                else
                {
                    localSetting.Values["InternetProfile"] = profile.ProfileName;
                    var networkAdapterInfo = profile.NetworkAdapter;
                    if (networkAdapterInfo == null)
                    {
                        localSetting.Values["NetworkAdapterId"] = "Not connected to Internet";

                    }
                    else
                    {
                        localSetting.Values["NetworkAdapterId"] = networkAdapterInfo.NetworkAdapterId;

                    }

                }


            }
            catch (Exception e)
            {
                Debug.WriteLine("Unhandled exception" + e.ToString());
            }


        }

        private void OnCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason)
        {
            throw new NotImplementedException();
        }
    }
}
