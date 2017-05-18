using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ConnectLive
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
        List<ContactDetails> s;
        public List<ContactDetails> Details { get { return s; } set { s = value; } }

        private async void btnContact_Click(object sender, RoutedEventArgs e)
        {
            Details = new List<ContactDetails>();
            var p = new ContactPicker();
            p.CommitButtonText = "Pick Contact";
            var selectedContact = await p.PickSingleContactAsync();
            Details.Add(new ContactDetails(selectedContact));
            lstContact.ItemsSource = Details;

        }

     


    }
    public class ContactDetails
    {
        public string ContactName { get; private set; }
        public BitmapImage ContactImage { get; private set; }
        public Visibility CanShow { get; set; }
        public List<string> PhoneNumbers { get; set; }
        public List<string> ContactEmails { get; set; }

        public ContactDetails(ContactInformation c)
        {
            PhoneNumbers = new List<string>();
            ContactEmails = new List<string>();
            CanShow = Visibility.Visible;
            ContactName = c.Name;
            foreach (var item in c.PhoneNumbers)
                PhoneNumbers.Add(item.Value);
            foreach (var item in c.Emails)
                ContactEmails.Add(item.Value);
        }
    }
}
