using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace CustomControl
{
    public sealed partial class Control : UserControl
    {
        public Control()
        {
            this.InitializeComponent();
            txtUser.Text = "User";
            txtPass.Text = "Pass";
        }
        public delegate void ClickLogin();
        public event ClickLogin btnLogin;

        public string tbUser
        {
            get { return txtUser.Text; }
            set { txtUser.Text = value; }
        }
        public string tbPass
        {
            get { return txtPass.Text; }
            set { txtPass.Text = value; }
        }
        public Brush bgColor
        {
            set { txtUser.Background = value; }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (btnLogin != null)
            {
                btnLogin();
            }


        }



    }
}
