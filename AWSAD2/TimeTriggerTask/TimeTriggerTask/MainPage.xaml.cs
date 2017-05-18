using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TimeTriggerTask
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
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);


            string taskName = "My Time Trigger";
            foreach (var task in BackgroundTaskRegistration.AllTasks)
            {
                if (task.Value.Name == taskName)
                    task.Value.Unregister(true);
            }
            BackgroundTaskBuilder builder = new BackgroundTaskBuilder();
            builder.Name = taskName;
            builder.TaskEntryPoint = "TriggerInterface.BGInterface";
            IBackgroundTrigger trigger = new TimeTrigger(15, false);
            builder.SetTrigger(trigger);
            builder.SetTrigger(new SystemTrigger(SystemTriggerType.NetworkStateChange, false));
            var t = builder.Register();



        }
    }
}
