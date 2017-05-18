using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
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

namespace DeviceTesting
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            lstDevices.SelectionChanged += LstDevices_SelectionChanged;
        }

        private void LstDevices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstDevices.SelectedItem == Printer) { txtClassGuid.Text = "{0ECEF634-6EF0-472A-8085-5AD023CBCCD"; }
            else if (lstDevices.SelectedItem == WebCam) { txtClassGuid.Text = "{E5323777-F976-4F5B-9B55-B94699C46E44}"; }
            else if (lstDevices.SelectedItem == PortDevices) { txtClassGuid.Text = "{6AC27878-A6FA-4155-BA85-F98F491D4F33}"; }
        }

        private async void btnEnumerate_Click(object sender, RoutedEventArgs e)
        {
            var s = "System.Devices.InterfaceClassGuid:=\"" + txtClassGuid.Text + "\"";
            var i = await DeviceInformation.FindAllAsync(s, null);
            txtResult.Text = i.Count + "devices found\n\n";
            lstResult.Items.Clear();
            foreach (DeviceInformation d in i)
            {
                var id = "Id:" + d.Id;
                var name = d.Name;
                var isEnabled = "IsEnabled:" + d.IsEnabled;
                var item = id + " is \n" + name + " and \n" + isEnabled;
                lstResult.Items.Add(item);
            }

        }
    }
}
