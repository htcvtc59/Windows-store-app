using AsgWSAD1_WPF.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace AsgWSAD1_WPF
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class View : Page
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


        public View()
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

            loadpage();


        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length != 0)
            {
                List<UserAdd> lstUser = new List<UserAdd>();
                var local = ApplicationData.Current.LocalFolder;

                var file = await local.GetFileAsync(@"\Data\data.txt");
                IList<string> lines = await FileIO.ReadLinesAsync(file);
                foreach (var item in lines)
                {
                    string[] d = item.Split(' ', '\n');
                    UserAdd user = new UserAdd();
                    user.name = d[0];
                    user.phone = d[1];
                    user.group = d[2];
                    user.location = d[3];
                    user.avatar = d[4];
                    user.nameimg = d[5];
                    user.imgavatar = await loadimg(d[5]);

                    lstUser.Add(user);
                }


                UserAdd addus = lstUser.Find(x => x.name.Contains(txtName.Text));
                List<UserAdd> lstU = new List<UserAdd>();
                lstU.Add(addus);
                lstBox.ItemsSource = lstU;





            }
            else
            {
                await new MessageDialog("Enter search name").ShowAsync();
            }



        }

        private async void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            int a = lstBox.SelectedIndex;
            if (a != -1)
            {
                var local = ApplicationData.Current.LocalFolder;
                List<UserAdd> lolstUser = new List<UserAdd>();
                var file = await local.GetFileAsync(@"\Data\data.txt");
                IList<string> lines = await FileIO.ReadLinesAsync(file);
                foreach (var item in lines)
                {
                    string[] d = item.Split(' ', '\n');
                    UserAdd user = new UserAdd();
                    user.name = d[0];
                    user.phone = d[1];
                    user.group = d[2];
                    user.location = d[3];
                    user.avatar = d[4];
                    user.nameimg = d[5];
                    user.imgavatar = await loadimg(d[5]);

                    lolstUser.Add(user);
                }

                UserAdd muluser = new UserAdd() { name = lolstUser[a].name, phone = lolstUser[a].phone, group = lolstUser[a].group };
                if (this.Frame != null)
                {
                    this.Frame.Navigate(typeof(Edit), muluser);
                }
            }
            else
            {
                MessageDialog msg = new MessageDialog("Click Item");
                await msg.ShowAsync();
            }


        }


        private async void loadpage()
        {
            var local = ApplicationData.Current.LocalFolder;
            List<UserAdd> lolstUser = new List<UserAdd>();
            var file = await local.GetFileAsync(@"\Data\data.txt");
            IList<string> lines = await FileIO.ReadLinesAsync(file);
            foreach (var item in lines)
            {
                string[] d = item.Split(' ', '\n');
                UserAdd user = new UserAdd();
                user.name = d[0];
                user.phone = d[1];
                user.group = d[2];
                user.location = d[3];
                user.avatar = d[4];
                user.nameimg = d[5];
                user.imgavatar = await loadimg(d[5]);

                lolstUser.Add(user);
            }
            lstBox.ItemsSource = lolstUser;

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

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                loadpage();

            }
        }

        private async void lstBox_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            int a = lstBox.SelectedIndex;
            if (a != -1)
            {
                var local = ApplicationData.Current.LocalFolder;
                List<UserAdd> lolstUser = new List<UserAdd>();
                var file = await local.GetFileAsync(@"\Data\data.txt");
                IList<string> lines = await FileIO.ReadLinesAsync(file);
                foreach (var item in lines)
                {
                    string[] d = item.Split(' ', '\n');
                    UserAdd user = new UserAdd();
                    user.name = d[0];
                    user.phone = d[1];
                    user.group = d[2];
                    user.location = d[3];
                    user.avatar = d[4];
                    user.nameimg = d[5];
                    user.imgavatar = await loadimg(d[5]);

                    lolstUser.Add(user);
                }

                UserAdd muluser = new UserAdd() { name = lolstUser[a].name, phone = lolstUser[a].phone, group = lolstUser[a].group };
                if (this.Frame != null)
                {
                    this.Frame.Navigate(typeof(Edit), muluser);
                }
            }
            else
            {
                MessageDialog msg = new MessageDialog("Click Item");
                await msg.ShowAsync();
            }

        }
    }
}
