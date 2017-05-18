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

namespace ASMGmailAWSAD2
{
    public sealed partial class MessageHeader : UserControl
    {
        public MessageHeader()
        {
            this.InitializeComponent();
        }
        //Tag
        public Visibility tagFirstPro
        {
            get { return tagFirst.Visibility; }
            set { tagFirst.Visibility = value; }
        }
        public Visibility tagSecondPro
        {
            get { return tagSecond.Visibility; }
            set { tagSecond.Visibility = value; }
        }
        //txt1
        public string txtHeader1
        {
            get { return txt1.Text; }
            set { txt1.Text = value; }
        }
        public FontFamily txtHeader1Font
        {
            get { return txt1.FontFamily; }
            set { txt1.FontFamily = value; }
        }
        //txt2
        public string txtHeader2
        {
            get { return txt2.Text; }
            set { txt2.Text = value; }
        }
        public FontFamily txtHeader2Font
        {
            get { return txt2.FontFamily; }
            set { txt2.FontFamily = value; }
        }
        //txt3
        public string txtHeader3
        {
            get { return txt3.Text; }
            set { txt3.Text = value; }
        }
        public FontFamily txtHeader3Font
        {
            get { return txt3.FontFamily; }
            set { txt3.FontFamily = value; }
        }
        //txt4
        public string txtHeader4
        {
            get { return txt4.Text; }
            set { txt4.Text = value; }
        }
        public FontFamily txtHeader4Font
        {
            get { return txt4.FontFamily; }
            set { txt4.FontFamily = value; }
        }
        //id
        public string txtId
        {
            get { return txtidmes.Text; }
            set { txtidmes.Text = value; }
        }
        //content
        public string txtContent
        {
            get { return txtcontent.Text; }
            set { txtcontent.Text = value; }
        }
        //check box
        public bool checkBoxMes
        {
            get { return (bool)checkBox.IsChecked; }
            set { checkBox.IsChecked = value; }
        }

        public Brush backgroundColorMes
        {
            get { return backgroundMes.Background; }
            set { backgroundMes.Background = value; }
        }
        public double opacityMes
        {
            get { return backgroundMes.Opacity; }
            set { backgroundMes.Opacity = value; }
        }

        public delegate void DetailMessage();

        public event RoutedEventHandler btnDetail;
        public event RoutedEventHandler btnChecked;
        public event RoutedEventHandler btnCheckedClick;

        private void btnDetailMes_Click(object sender, RoutedEventArgs e)
        {
            if (btnDetailMes != null)
                this.btnDetail(this, e);
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            if (btnChecked != null)
                this.btnChecked(this, e);
        }

        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
            if (btnCheckedClick != null)
                this.btnCheckedClick(this, e);
        }
    }
}
