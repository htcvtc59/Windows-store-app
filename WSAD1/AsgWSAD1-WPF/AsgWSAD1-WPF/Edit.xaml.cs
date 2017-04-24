using AsgWSAD1_WPF.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace AsgWSAD1_WPF
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Edit : Page
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


        public Edit()
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


        string namen;
        string phonen;
        string groupn;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
            UserAdd user = e.Parameter as UserAdd;
            if (user != null)
            {
                UserAdd u = new UserAdd();
                namen = user.name;
                phonen = user.phone;
                groupn = user.group;

                txtName2.DataContext = user;
                txtPhone2.DataContext = user;
                txtGroup2.DataContext = user;
            }

        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtName2.Text.Length != 0
               && txtPhone2.Text.Length != 0
               && txtGroup2.Text.Length != 0)
            {

                string names = txtName2.Text;
                string phones = txtPhone2.Text;
                string groups = txtGroup2.Text;

                var local = ApplicationData.Current.LocalFolder;
                List<UserAdd> lstUser = new List<UserAdd>();
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

                    lstUser.Add(user);
                }


                UserAdd addu = lstUser.Find(x => x.name.Contains(namen) && x.phone.Contains(phonen) && x.group.Contains(groupn));

                addu.name = names;
                addu.phone = phones;
                addu.group = groups;
                int a = lstUser.IndexOf(addu);
                lstUser.Insert(a, addu);
                List<UserAdd> lstUse = new List<UserAdd>();
                lstUser.Remove(addu);
                lstUse.AddRange(lstUser);
                string abc = "";
                for (int i = 0; i < lstUse.Count; i++)
                {
                    UserAdd user = new UserAdd();
                    user.name = lstUse[i].name;
                    user.phone = lstUse[i].phone;
                    user.group = lstUse[i].group;
                    user.location = lstUse[i].location;
                    user.avatar = lstUse[i].avatar;
                    user.nameimg = lstUse[i].nameimg;
                    user.imgavatar = lstUse[i].imgavatar;
                    abc += user.ToString();

                }
                var files = await local.CreateFileAsync(@"\Data\data.txt", CreationCollisionOption.OpenIfExists);
                await FileIO.WriteTextAsync(files, abc);


                await new MessageDialog("Save Data Success").ShowAsync();
                txtName2.Text = "";
                txtPhone2.Text = "";
                txtGroup2.Text = "";






            }
            else
            {
                await new MessageDialog("Not Empty").ShowAsync();
            }
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txtName2.Text.Length != 0
                         && txtPhone2.Text.Length != 0
                         && txtGroup2.Text.Length != 0)
            {


                var local = ApplicationData.Current.LocalFolder;
                List<UserAdd> lstUser = new List<UserAdd>();
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

                    lstUser.Add(user);
                }

                UserAdd addu = lstUser.Find(x => x.name.Contains(namen) && x.phone.Contains(phonen) && x.group.Contains(groupn));
                string ab = addu.nameimg;

                StorageFolder folder = await local.GetFolderAsync("Data");
                IReadOnlyList<StorageFile> sfileimg = await folder.GetFilesAsync();

                foreach (StorageFile item in sfileimg)
                {
                    if (item.Name.Equals(ab))
                    {
                         await item.DeleteAsync();
                        
                    }
                }


                List<UserAdd> lstUse = new List<UserAdd>();
                lstUser.Remove(addu);
                lstUse.AddRange(lstUser);
                string abc = "";
                for (int i = 0; i < lstUse.Count; i++)
                {
                    UserAdd user = new UserAdd();
                    user.name = lstUse[i].name;
                    user.phone = lstUse[i].phone;
                    user.group = lstUse[i].group;
                    user.location = lstUse[i].location;
                    user.avatar = lstUse[i].avatar;
                    user.nameimg = lstUse[i].nameimg;
                    user.imgavatar = lstUse[i].imgavatar;
                    abc += user.ToString();

                }
                var files = await local.CreateFileAsync(@"\Data\data.txt", CreationCollisionOption.OpenIfExists);
                await FileIO.WriteTextAsync(files, abc);

                await new MessageDialog("Delete Data Success").ShowAsync();
                txtName2.Text = "";
                txtPhone2.Text = "";
                txtGroup2.Text = "";
                
            }
            else
            {
                await new MessageDialog("Not Empty").ShowAsync();
            }






        }
    }
}
