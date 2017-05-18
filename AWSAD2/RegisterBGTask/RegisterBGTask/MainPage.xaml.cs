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

namespace RegisterBGTask
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool r = false;
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void fnChkReg()
        {
            foreach (var t in BackgroundTaskRegistration.AllTasks)
            {
                if (t.Value.Name == "Update") { r = true; break; }
            }
            if (r) { btnRegister.Content = "UnRegister"; lbResult.Text = "Task UnRegister"; }
            if (!r) { btnRegister.Content = "Register"; lbResult.Text = "Task Register"; }
        }
        private void RegBgTask(string n , string p)
        {
            BackgroundTaskBuilder b = new BackgroundTaskBuilder();
            b.Name = n;
            b.TaskEntryPoint = p;
            b.SetTrigger(new SystemTrigger(SystemTriggerType.InternetAvailable,false));
            BackgroundTaskRegistration t = b.Register();

        }
        private void UnRegBgTask(string name)
        {
            foreach (var t in BackgroundTaskRegistration.AllTasks)
            {
                if (t.Value.Name == name) { t.Value.Unregister(true); }
            }
        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (r) { UnRegBgTask("Update");r = false; }else { RegBgTask("Update", "BackgroundTasks.Update"); }
            fnChkReg();
        }
    }
}
