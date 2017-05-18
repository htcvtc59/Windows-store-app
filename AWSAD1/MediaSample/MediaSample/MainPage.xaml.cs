using MediaSample.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace MediaSample
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : Page
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


        public MainPage()
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

        List<StorageFile> listfile = new List<StorageFile>();
        private async void btnBrowser_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".mp4");
            picker.FileTypeFilter.Add(".avi");
            picker.FileTypeFilter.Add(".wmv");
            StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                listfile.Add(file);
                listVideo.ItemsSource = listfile;
            }



        }

        private async void listVideo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StorageFile file = listVideo.SelectedItem as StorageFile;
            if (file != null)
            {
                mediaplayVideo.SetSource(await file.OpenAsync(FileAccessMode.Read), file.ContentType);
                mediaplayVideo.Play();
            }


        }

        private async void btnNextVideo_Click(object sender, RoutedEventArgs e)
        {
            //var aa = listVideo.SelectedIndex();
            //StorageFile filefirst = listfile[0];
            //if (filefirst != null)
            //{
            //    mediaplayVideo.SetSource(await filefirst.OpenAsync(FileAccessMode.Read), filefirst.ContentType);
            //    mediaplayVideo.Play();
            //}
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            StorageFile filefirst = listfile[0];
            if (filefirst != null)
            {
                mediaplayVideo.SetSource(await filefirst.OpenAsync(FileAccessMode.Read), filefirst.ContentType);
                mediaplayVideo.Play();
            }

        }

        private async void btnLast_Click(object sender, RoutedEventArgs e)
        {
            int total = listfile.Count - 1;
            StorageFile filelast = listfile[total];
            if (filelast != null)
            {
                mediaplayVideo.SetSource(await filelast.OpenAsync(FileAccessMode.Read), filelast.ContentType);
                mediaplayVideo.Play();
            }

        }

        private void btnRepeat_Click(object sender, RoutedEventArgs e)
        {
            mediaplayVideo.Position = TimeSpan.Zero;
            mediaplayVideo.Play();


        }

        private void btnRamdom_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
