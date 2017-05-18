using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Background;
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

namespace ExamAWSAD2
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

        private async void AddTile()
        {
            if (txtTile.Text.Length != 0)
            {
                TileText text = new TileText();
                text.text = txtTile.Text;
                var local = ApplicationData.Current.LocalFolder;
                await local.CreateFileAsync(@"\Data\data.txt", CreationCollisionOption.OpenIfExists);
                var file = await local.CreateFileAsync(@"\Data\data.txt", CreationCollisionOption.ReplaceExisting);
                await FileIO.AppendTextAsync(file, text.ToString());
            }
        }

        private void btnRegisterStart_Click(object sender, RoutedEventArgs e)
        {
            AddTile();
            BackgroundTaskBuilder builder = new BackgroundTaskBuilder();
            builder.Name = "Wifi Checking";
            builder.TaskEntryPoint = "BackgroundTaskInternet.BGTaskInterface";
            SystemTrigger trigger = new SystemTrigger(SystemTriggerType.NetworkStateChange, false);
            builder.SetTrigger(trigger);
            BackgroundTaskRegistration task = builder.Register();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            foreach (var task in BackgroundTaskRegistration.AllTasks)
            {
                task.Value.Unregister(true);
            }

        }
    }
}
