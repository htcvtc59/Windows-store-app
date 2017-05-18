using ExamContact.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ExamContact
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class SearchContact : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public SearchContact()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="Common.NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="Common.NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="Common.NavigationHelper.LoadState"/>
        /// and <see cref="Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion



        private const string JSONFILENAME = @"\Data\contact.json";
        public async void readJson()
        {

            string content = String.Empty;
            var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);
            using (StreamReader reader = new StreamReader(myStream))
            {
                content = await reader.ReadToEndAsync();
                if (content.Length != 0)
                {
                    DataContractJsonSerializer seri = new DataContractJsonSerializer(typeof(List<Contact>));
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content));

                    List<Contact> myContact = (List<Contact>)seri.ReadObject(ms);

                    if (tbNames.Text.Length != 0)
                    {
                        List<Contact> lstUser = new List<Contact>();



                        Contact cont = myContact.Find(x => x.name.Contains(tbNames.Text));
                        //List<Contact> lstCont = new List<Contact>();
                        //lstCont.Add(cont);
                        if (cont != null)
                        {

                            List<Contact> lstCont = new List<Contact>();
                            lstCont.Add(cont);
                            tbNames.DataContext = cont;
                            tbNumbers.DataContext = cont;
                            cbbGroups.ItemsSource = lstCont;

                            //Test them cbb
                            cbbGroups.DisplayMemberPath = "group";
                            cbbGroups.SelectionChanged += CbbGroups_SelectionChanged;
                            cbbGroups.SelectedValuePath = "name";



                            tbImages.DataContext = cont;
                            imgContact.Source = await loadimg(cont.nameimage);
                        }




                    }
                    else
                    {
                        await new MessageDialog("Enter search name").ShowAsync();
                    }


                }
            }
        }

        private async void CbbGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //await new MessageDialog((cbbGroups.SelectedItem as Contact).name).ShowAsync();
            await new MessageDialog(cbbGroups.SelectedValue.ToString()).ShowAsync();
        }

        private async Task<BitmapImage> loadimg(string nameimg)
        {
            BitmapImage bit = null;
            var local = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFolder folder = await local.GetFolderAsync("Data");
            IReadOnlyList<StorageFile> files = await folder.GetFilesAsync();

            foreach (StorageFile item in files)
            {
                if (item.Name.Equals(nameimg))
                {
                    StorageFile sfile = await folder.GetFileAsync(nameimg);
                    bit = await bitmap(sfile);
                }
            }

            return bit;

        }
        private async Task<BitmapImage> bitmap(StorageFile file)
        {
            BitmapImage bit;
            IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read);
            BitmapImage bitmapImage = new BitmapImage();
            await bitmapImage.SetSourceAsync(fileStream);
            bit = bitmapImage;

            return bit;

        }




        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            readJson();

        }
    }
}
