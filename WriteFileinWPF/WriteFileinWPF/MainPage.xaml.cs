using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WriteFileinWPF
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

        private async void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text.Length != 0
                && txtName.Text.Length != 0
                && txtMark.Text.Length != 0
                && cbbClass.SelectionBoxItem.ToString().Length != 0
                && radMale.IsChecked == true || radFemale.IsChecked == true
                )
            {
                string cbbclass = cbbClass.SelectionBoxItem.ToString();
                string gender = radMale.IsChecked == true ? "Male" : "Female";
                string id = txtID.Text;
                string name = txtName.Text;
                float mark = float.Parse(txtMark.Text);

                Student st = new Student() { id1 = id, name1 = name, mark1 = mark, class1 = cbbclass, gender1 = gender };


                var local = Windows.Storage.ApplicationData.Current.LocalFolder;
                var file = await local.CreateFileAsync("data.txt", Windows.Storage.CreationCollisionOption.OpenIfExists);
                await FileIO.AppendTextAsync(file, st.ToString());
                MessageDialog msg = new MessageDialog("Write Data Success");
                await msg.ShowAsync();

            }
            else
            {
                MessageDialog msgerr = new MessageDialog("Not Empty");
                await msgerr.ShowAsync();
            }


        }
        private async void btnRead_Click(object sender, RoutedEventArgs e)
        {
            var local = Windows.Storage.ApplicationData.Current.LocalFolder;
            List<Student> lstst = new List<Student>();
            var file = await local.GetFileAsync("data.txt");
            IList<string> lines = await FileIO.ReadLinesAsync(file);
            foreach (var item in lines)
            {
                string[] d = item.Split('#');
                Student std = new Student();
                std.id1 = d[0];
                std.name1 = d[1];
                std.mark1 = float.Parse(d[2]);
                std.class1 = d[3];
                std.gender1 = d[4];
                lstst.Add(std);

            }
           

            txtID.DataContext = lstst[0];
            txtName.DataContext = lstst[0];
            txtMark.DataContext = lstst[0];
            //int i=0;
            //switch (lstst[0].class1)
            //{
            //    case "Class A":
            //        i = 0;
            //        break;
            //    case "Class B":
            //        i = 1;
            //        break;
            //    case "Class C":
            //        i = 2;
            //        break;
            //    case "Class D":
            //        i = 3;
            //        break;
            //}
            //cbbClass.SelectedIndex = i;

            cbbClass.PlaceholderText= lstst[0].class1.ToString();

            switch (lstst[0].gender1)
            {
                case "Male":
                    radMale.IsChecked = true;
                    break;
                case "Female":
                    radFemale.IsChecked = true;
                    break;
                
            }

        }
    }
}
