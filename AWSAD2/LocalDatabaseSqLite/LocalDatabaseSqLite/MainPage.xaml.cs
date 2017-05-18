using SQLite;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LocalDatabaseSqLite
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
       

        private async void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            string name = txtPName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            Product product = new Product();
            product.name = name;
            product.price = price;
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection("AppDB");
            await conn.InsertAsync(product);
            MessageDialog msg = new MessageDialog("Add new success");
            await msg.ShowAsync();
            
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(View));
        }
    }
}
