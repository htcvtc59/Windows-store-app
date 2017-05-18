using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static ASMGmailAWSAD2.UserProfileInfo;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ASMGmailAWSAD2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ServiceGmail serviceGmail = new ServiceGmail();
        static int valuenext = 26;
        static int i = 1;
        List<string> listIdMes = new List<string>();
        public MainPage()
        {
            this.InitializeComponent();
            dataMesInDB();
            gridHeadDetail.Visibility = Visibility.Collapsed;
            gridHeadAllMes.Visibility = Visibility.Visible;
            gridDetailMes.Visibility = Visibility.Collapsed;
            gridAllMes.Visibility = Visibility.Visible;
            gridHeadinDetail.Visibility = Visibility.Collapsed;
            //gridColorInbox.Background = ConvertColor(255, 255, 255);
        }


        //Get data from DB
        public async void dataMesInDB()
        {
            try
            {
                SQLiteAsyncConnection conn = new SQLiteAsyncConnection("DBMail");
                List<MesHeader> listMes = new List<MesHeader>();
                List<MesUnread> listMesUnread = new List<MesUnread>();
                List<MesImportant> listImportant = new List<MesImportant>();
                //list important
                var resultimportant = await conn.QueryAsync<MesImportant>("select * from mesimportant");
                foreach (var item in resultimportant)
                {
                    MesImportant mesimportant = new MesImportant();
                    mesimportant.idimportant = item.idimportant;
                    listImportant.Add(mesimportant);

                }
                //list all message
                var result = await conn.QueryAsync<MesHeader>("select * from mesheader");
                //Progress Bar
                await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                proBar3.Maximum = result.Count);
                for (int i = 0; i < result.Count; i++)
                {
                    MesHeader mes = new MesHeader();
                    mes.idmes = result[i].idmes;
                    mes.txt1 = result[i].txt1;
                    mes.txt2 = result[i].txt2;
                    mes.txt3 = result[i].txt3;
                    mes.txt4 = result[i].txt4;
                    mes.content = result[i].content;
                    listMes.Add(mes);
                    await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    proBar3.Value = i);
                }
                //list unread
                var resultunread = await conn.QueryAsync<MesUnread>("select * from mesunread");
                foreach (var item in resultunread)
                {
                    MesUnread mesunread = new MesUnread();
                    mesunread.idmes = item.idmes;
                    mesunread.txt1 = item.txt1;
                    mesunread.txt2 = item.txt2;
                    mesunread.txt3 = item.txt3;
                    mesunread.txt4 = item.txt4;
                    mesunread.content = item.content;
                    listMesUnread.Add(mesunread);

                }

                if (listMes.Count <= 26)
                {
                    txtTotalMes.Text = string.Format("1-{0} of {1}", listMes.Count, listMes.Count);
                    btnRightMes.IsEnabled = false; btnLeftMes.IsEnabled = false;
                }
                else
                {
                    txtTotalMes.Text = string.Format("1-{0} of {1}", 26, listMes.Count);
                    btnRightMes.Background = ConvertColor(61, 98, 128);
                    btnLeftMes.IsEnabled = false;
                }
                await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                proBar4.Maximum = 26);
                for (int i = 0; i < 26; i++)
                {
                    MessageHeader userControlMessage = new MessageHeader();
                    userControlMessage.Name = "Mes" + i;
                    if (i % 2 == 0)
                    {
                        userControlMessage.backgroundColorMes = ConvertColor(242, 244, 246);
                    }
                    else
                    {
                        userControlMessage.backgroundColorMes = ConvertColor(249, 250, 249);
                    }

                    //important
                    foreach (var item in listImportant)
                    {
                        if (item.idimportant == listMes[i].idmes)
                        {
                            userControlMessage.tagSecondPro = Visibility.Visible;
                            userControlMessage.tagFirstPro = Visibility.Collapsed;
                        }
                    }
                    //id all vs id unread 
                    foreach (MesUnread mes in listMesUnread)
                    {
                        if (mes.idmes == listMes[i].idmes)
                        {
                            userControlMessage.backgroundColorMes = ConvertColor(72, 137, 181);
                            userControlMessage.opacityMes = 0.6;
                        }
                    }

                    userControlMessage.txtHeader1 = listMes[i].txt1;
                    userControlMessage.txtHeader2 = listMes[i].txt2;
                    userControlMessage.txtHeader3 = "-" + listMes[i].txt3;
                    string[] str = listMes[i].txt4.Replace("-", "+").Split('+');

                    userControlMessage.txtHeader4 = str[0];
                    userControlMessage.txtId = listMes[i].idmes;
                    userControlMessage.txtContent = listMes[i].content;


                    userControlMessage.txtHeader1Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");
                    userControlMessage.txtHeader2Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");
                    userControlMessage.txtHeader3Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");
                    userControlMessage.txtHeader4Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");

                    userControlMessage.Margin = new Thickness(0, 0, 0, 5);
                    gridMes.Children.Add(userControlMessage);
                    userControlMessage.btnDetail += UserControlMessage_btnDetail;
                    userControlMessage.btnCheckedClick += UserControlMessage_btnCheckedClick;
                    await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    proBar4.Value = i);
                }
            }
            catch (Exception) { }
            finally
            {
                //ProgressBar
                proBar3.Visibility = Visibility.Collapsed;
                proBar4.Visibility = Visibility.Collapsed;
            }

        }

        private void UserControlMessage_btnCheckedClick(object sender, RoutedEventArgs e)
        {
            MessageHeader userControlMessage = sender as MessageHeader;
            if (userControlMessage.checkBoxMes == true)
            {
                listIdMes.Add(userControlMessage.txtId);
            }
            else if (userControlMessage.checkBoxMes == false)
            {
                listIdMes.Remove(userControlMessage.txtId);
            }
        }



        private void UserControlMessage_btnDetail(object sender, RoutedEventArgs e)
        {
            MessageHeader userControlMessage = sender as MessageHeader;
            string token = userControlMessage.txtContent;
            byte[] byteDecode = Decode(token);
            string strDecode = System.Text.Encoding.UTF8.GetString(byteDecode, 0, byteDecode.Length);
            webviewContent.NavigateToString(strDecode);
            gridHeadDetail.Visibility = Visibility.Visible;
            gridHeadAllMes.Visibility = Visibility.Collapsed;
            gridDetailMes.Visibility = Visibility.Visible;
            gridAllMes.Visibility = Visibility.Collapsed;
            gridHeadinDetail.Visibility = Visibility.Visible;
            txtHeadinDetail.Text = userControlMessage.txtHeader2;
            //await new MessageDialog(userControlMessage.txtId).ShowAsync();
        }
        public static byte[] Decode(string input)
        {
            var output = input;
            output = output.Replace('-', '+'); // 62nd char of encoding
            output = output.Replace('_', '/'); // 63rd char of encoding
            switch (output.Length % 4) // Pad with trailing '='s
            {
                case 0: break; // No pad chars in this case
                case 2: output += "=="; break; // Two pad chars
                case 3: output += "="; break; // One pad char
                default: throw new Exception("Illegal base64url string!");
            }
            var converted = Convert.FromBase64String(output); // Standard base64 decoder
            return converted;
        }

        //convert rbg to arbg
        public static Brush ConvertColor(int r, int g, int b)
        {
            return new SolidColorBrush(Windows.UI.Color.FromArgb(Convert.ToByte(255), Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserCredential credential = await serviceGmail.getCredential();
                if (credential != null)
                {

                    UserProfile userProfile = await serviceGmail.getProfileService(credential);
                    if (userProfile != null)
                    {
                        bool show;
                        show = (ShowH.Visibility == Visibility.Visible) ? true : false;
                        ShowH.Visibility = (show == false) ? Visibility.Visible : Visibility.Collapsed;

                        threadFill.Fill = new SolidColorBrush(Colors.OrangeRed);
                        var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
                        timer.Start();
                        timer.Tick += Timer_Tick;

                        userEmail.DataContext = userProfile;
                        userName.DataContext = userProfile;
                        userPicture.Source = new BitmapImage(new Uri(userProfile.picture));

                    }
                }
                else
                {
                    await serviceGmail.getCredential();
                }
            }
            catch (Exception) { }


        }

        private void Timer_Tick(object sender, object e)
        {
            threadFill.Fill = new SolidColorBrush(Colors.Orange);

        }

        private async void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserCredential credential = await serviceGmail.getCredential();
                if (credential != null)
                {
                    await credential.RevokeTokenAsync(CancellationToken.None);
                    credential = null;
                    ShowH.Visibility = Visibility.Collapsed;

                }

                //Drop table in sqlite and delete usercontrol

                gridMes.Children.Clear();
                SQLiteAsyncConnection conn = new SQLiteAsyncConnection("DBMail");
                await conn.DropTableAsync<MesHeader>();
                gridHeadDetail.Visibility = Visibility.Collapsed;
                gridHeadAllMes.Visibility = Visibility.Visible;
                gridDetailMes.Visibility = Visibility.Collapsed;
                gridAllMes.Visibility = Visibility.Visible;
                gridHeadinDetail.Visibility = Visibility.Collapsed;
                //Progress Bar
                proBar1.Visibility = Visibility.Collapsed;
                proBar2.Visibility = Visibility.Collapsed;
                proBar3.Visibility = Visibility.Collapsed;
                proBar4.Visibility = Visibility.Collapsed;
                txtTotalMes.Text = "";
                btnLeftMes.Background = null;
                btnLeftMes.IsEnabled = false;
                btnRightMes.Background = null;
                btnRightMes.IsEnabled = false;

            }
            catch (Exception) { }
        }

        //send mail
        private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes)
              .Replace('+', '-')
              .Replace('/', '_')
              .Replace("=", "");
        }

        private async void btnCompose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserCredential credential = await serviceGmail.getCredential();
                if (credential != null)
                {
                    UserProfile userProfile = await serviceGmail.getProfileService(credential);
                    ShowHideCompose.Visibility = Visibility.Visible;
                    helloUser.Text = "Hello " + userProfile.name;
                    txtEmailSend.Text = "";
                    txtSubject.Text = "";
                    txtContentSend.Text = "";
                }
            }
            catch (Exception) { }

        }

        private async void btnSendCompose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserCredential credential = await serviceGmail.getCredential();
                if (credential != null)
                {
                    var service = new GmailService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = "Gmail API",
                    });
                    string plainText = string.Format("To: {0}\r\n" +
                                   "Subject: {1}\r\n" +
                                   "Content-Type: text/html; charset=us-ascii\r\n\r\n" +
                                   "<h1>{2}</h1>", txtEmailSend.Text, txtSubject.Text, txtContentSend.Text);

                    var newMsg = new Google.Apis.Gmail.v1.Data.Message();
                    newMsg.Raw = Base64UrlEncode(plainText.ToString());
                    service.Users.Messages.Send(newMsg, "me").Execute();
                    ShowHideCompose.Visibility = Visibility.Collapsed;
                }
            }
            catch (Exception) { }
        }

        private void btnCloseCompose_Click(object sender, RoutedEventArgs e)
        {
            ShowHideCompose.Visibility = Visibility.Collapsed;
        }

        private void btnBackMes_Click(object sender, RoutedEventArgs e)
        {
            gridMes.Children.Clear();
            reloadwithPage(i);
            gridHeadDetail.Visibility = Visibility.Collapsed;
            gridHeadAllMes.Visibility = Visibility.Visible;
            gridDetailMes.Visibility = Visibility.Collapsed;
            gridAllMes.Visibility = Visibility.Visible;
            gridHeadinDetail.Visibility = Visibility.Collapsed;
        }

        private async void btnReloadMes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserCredential credential = await serviceGmail.getCredential();
                var getProfile = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
                if (credential != null && getProfile != null)
                {
                    SQLiteAsyncConnection conn = new SQLiteAsyncConnection("DBMail");
                    await conn.DropTableAsync<MesHeader>();
                    await conn.DropTableAsync<MesUnread>();
                    await conn.DropTableAsync<MesImportant>();
                    await conn.CreateTablesAsync<MesHeader, MesUnread, MesImportant>();
                    List<MesHeader> lstMes = serviceGmail.getAllMail(credential);
                    List<MesUnread> lstMesUnread = serviceGmail.getMesUnread(credential);
                    List<MesImportant> lstImportant = serviceGmail.getMesImportant(credential);
                    //bike
                    showbike.Visibility = Visibility.Visible;
                    showStoryboard.Begin();
                    if (lstImportant != null)
                    {
                        foreach (MesImportant item in lstImportant)
                        {
                            MesImportant mesimportant = new MesImportant();
                            mesimportant.idimportant = item.idimportant;
                            await conn.InsertAsync(mesimportant);
                        }
                    }

                    if (lstMes != null)
                    {
                        //Progress Bar
                        await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                        proBar1.Maximum = lstMes.Count);
                        for (int i = 0; i < lstMes.Count; i++)
                        {
                            MesHeader mes = new MesHeader();
                            mes.idmes = lstMes[i].idmes;
                            mes.txt1 = lstMes[i].txt1;
                            mes.txt2 = lstMes[i].txt2;
                            mes.txt3 = lstMes[i].txt3;
                            mes.txt4 = lstMes[i].txt4;
                            mes.content = lstMes[i].content;
                            await conn.InsertAsync(mes);
                            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                            proBar1.Value = i);
                        }
                    }

                    if (lstMesUnread != null)
                    {
                        //unread
                        await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                        proBar2.Maximum = lstMesUnread.Count);
                        for (int i = 0; i < lstMesUnread.Count; i++)
                        {
                            MesUnread mesunread = new MesUnread();
                            mesunread.idmes = lstMesUnread[i].idmes;
                            mesunread.txt1 = lstMesUnread[i].txt1;
                            mesunread.txt2 = lstMesUnread[i].txt2;
                            mesunread.txt3 = lstMesUnread[i].txt3;
                            mesunread.txt4 = lstMesUnread[i].txt4;
                            mesunread.content = lstMesUnread[i].content;
                            await conn.InsertAsync(mesunread);
                            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                            proBar2.Value = i);
                        }
                    }
                }
            }
            catch (Exception) { }
            finally
            {
                gridMes.Children.Clear();
                dataMesInDB();
                //ProgressBar
                proBar1.Visibility = Visibility.Collapsed;
                proBar2.Visibility = Visibility.Collapsed;
                showStoryboard.Stop();
                showbike.Visibility = Visibility.Collapsed;
                btnRightMes.IsEnabled = true;
            }

        }

        private async void btnDeleteMes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SQLiteAsyncConnection conn = new SQLiteAsyncConnection("DBMail");
                var result = await conn.QueryAsync<MesHeader>("select * from mesheader");
                foreach (MesHeader item in result)
                {
                    foreach (var itemid in listIdMes)
                    {
                        if (itemid.Contains(item.idmes))
                        {
                            MesHeader mes = new MesHeader();
                            mes.idmes = item.idmes;
                            mes.content = item.content;
                            mes.txt1 = item.txt1;
                            mes.txt2 = item.txt2;
                            mes.txt3 = item.txt3;
                            mes.txt4 = item.txt4;
                            await conn.DeleteAsync(mes);
                        }
                    }
                }
                gridMes.Children.Clear();
                reloadwithPage(i);
            }
            catch (Exception) { }


        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
        private async void btnRightMes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                gridMes.Children.Clear();
                btnLeftMes.Background = ConvertColor(61, 98, 128);
                SQLiteAsyncConnection conn = new SQLiteAsyncConnection("DBMail");
                List<MesHeader> listMes = new List<MesHeader>();
                var result = await conn.QueryAsync<MesHeader>("select * from mesheader");
                int total = result.Count;
                valuenext += 26;
                if (valuenext <= total)
                {
                    txtTotalMes.Text = string.Format("{0}-{1} of {2}", ++i, valuenext, result.Count);
                    leftRightMesDB(valuenext - 26);
                    btnRightMes.Background = ConvertColor(61, 98, 128);
                    btnLeftMes.Background = ConvertColor(61, 98, 128);
                    btnRightMes.IsEnabled = true;
                    btnLeftMes.IsEnabled = true;
                }
                else
                {
                    txtTotalMes.Text = string.Format("{0}-{1} of {2}", ++i, result.Count, result.Count);
                    leftRightMesDB(valuenext - 26);
                    btnLeftMes.Background = ConvertColor(61, 98, 128);
                    btnLeftMes.IsEnabled = true;
                    btnRightMes.Background = null;
                    btnRightMes.IsEnabled = false;
                }

            }
            catch (Exception) { }

        }

        private async void btnLeftMes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                gridMes.Children.Clear();
                btnLeftMes.Background = ConvertColor(61, 98, 128);
                SQLiteAsyncConnection conn = new SQLiteAsyncConnection("DBMail");
                List<MesHeader> listMes = new List<MesHeader>();
                var result = await conn.QueryAsync<MesHeader>("select * from mesheader");
                int total = result.Count;
                valuenext -= 26;
                txtTotalMes.Text = string.Format("{0}-{1} of {2}", --i, valuenext, result.Count);

                if (i > 2)
                {
                    leftRightMesDB(valuenext - 26 - 26);
                    btnLeftMes.Background = ConvertColor(61, 98, 128);
                    btnLeftMes.IsEnabled = true;
                    btnRightMes.Background = ConvertColor(61, 98, 128);
                    btnRightMes.IsEnabled = true;

                }

                if (i == 1)
                {
                    leftRightMesDB(valuenext - 26);
                    btnRightMes.Background = ConvertColor(61, 98, 128);
                    btnRightMes.IsEnabled = true;
                    btnLeftMes.Background = null;
                    btnLeftMes.IsEnabled = false;
                }
                if (i == 2)
                {
                    leftRightMesDB(valuenext - 26);
                    btnLeftMes.Background = ConvertColor(61, 98, 128);
                    btnRightMes.Background = ConvertColor(61, 98, 128);
                    btnRightMes.IsEnabled = true;
                    btnLeftMes.IsEnabled = true;
                }

            }
            catch (Exception) { }
        }


        //Data left and right
        public async void leftRightMesDB(int start)
        {
            try
            {
                SQLiteAsyncConnection conn = new SQLiteAsyncConnection("DBMail");
                List<MesHeader> listMes = new List<MesHeader>();
                List<MesUnread> listMesUnread = new List<MesUnread>();
                List<MesImportant> listImportant = new List<MesImportant>();

                //list important
                var resultimportant = await conn.QueryAsync<MesImportant>("select * from mesimportant");
                foreach (var item in resultimportant)
                {
                    MesImportant mesimportant = new MesImportant();
                    mesimportant.idimportant = item.idimportant;
                    listImportant.Add(mesimportant);

                }
                //list message all
                var result = await conn.QueryAsync<MesHeader>("select * from mesheader");
                for (int i = 0; i < result.Count; i++)
                {
                    MesHeader mes = new MesHeader();
                    mes.idmes = result[i].idmes;
                    mes.txt1 = result[i].txt1;
                    mes.txt2 = result[i].txt2;
                    mes.txt3 = result[i].txt3;
                    mes.txt4 = result[i].txt4;
                    mes.content = result[i].content;
                    listMes.Add(mes);
                }
                //list message unread
                var resultunread = await conn.QueryAsync<MesUnread>("select * from mesunread");
                foreach (var item in resultunread)
                {
                    MesUnread mesunread = new MesUnread();
                    mesunread.idmes = item.idmes;
                    mesunread.txt1 = item.txt1;
                    mesunread.txt2 = item.txt2;
                    mesunread.txt3 = item.txt3;
                    mesunread.txt4 = item.txt4;
                    mesunread.content = item.content;
                    listMesUnread.Add(mesunread);

                }

                for (int i = start; i < listMes.Count; i++)
                {
                    MessageHeader userControlMessage = new MessageHeader();
                    userControlMessage.Name = "Mes" + i;
                    if (i % 2 == 0)
                    {
                        userControlMessage.backgroundColorMes = ConvertColor(242, 244, 246);
                    }
                    else
                    {
                        userControlMessage.backgroundColorMes = ConvertColor(249, 250, 249);
                    }
                    //important
                    foreach (var item in listImportant)
                    {
                        if (item.idimportant == listMes[i].idmes)
                        {
                            userControlMessage.tagSecondPro = Visibility.Visible;
                            userControlMessage.tagFirstPro = Visibility.Collapsed;
                        }
                    }
                    //id all vs id unread 
                    foreach (MesUnread mes in listMesUnread)
                    {
                        if (mes.idmes == listMes[i].idmes)
                        {
                            userControlMessage.backgroundColorMes = ConvertColor(72, 137, 181);
                            userControlMessage.opacityMes = 0.6;
                        }
                    }

                    userControlMessage.txtHeader1 = listMes[i].txt1;
                    userControlMessage.txtHeader2 = listMes[i].txt2;
                    userControlMessage.txtHeader3 = "-" + listMes[i].txt3;
                    string[] str = listMes[i].txt4.Replace("-", "+").Split('+');

                    userControlMessage.txtHeader4 = str[0];
                    userControlMessage.txtId = listMes[i].idmes;
                    userControlMessage.txtContent = listMes[i].content;


                    userControlMessage.txtHeader1Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");
                    userControlMessage.txtHeader2Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");
                    userControlMessage.txtHeader3Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");
                    userControlMessage.txtHeader4Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");

                    userControlMessage.Margin = new Thickness(0, 0, 0, 5);
                    gridMes.Children.Add(userControlMessage);
                    userControlMessage.btnDetail += UserControlMessage_btnDetail;
                    userControlMessage.btnCheckedClick += UserControlMessage_btnCheckedClick;
                }


            }
            catch (Exception) { }


        }


        //Search
        public async void searchMail(string keyword)
        {

            SQLiteAsyncConnection conn = new SQLiteAsyncConnection("DBMail");
            List<MesHeader> listMes = new List<MesHeader>();
            List<MesImportant> listImportant = new List<MesImportant>();
            //list important
            var resultimportant = await conn.QueryAsync<MesImportant>("select * from mesimportant");
            foreach (var item in resultimportant)
            {
                MesImportant mesimportant = new MesImportant();
                mesimportant.idimportant = item.idimportant;
                listImportant.Add(mesimportant);

            }

            var result = await conn.QueryAsync<MesHeader>("select * from mesheader");

            for (int i = 0; i < result.Count; i++)
            {
                MesHeader mes = new MesHeader();
                mes.idmes = result[i].idmes;
                mes.txt1 = result[i].txt1;
                mes.txt2 = result[i].txt2;
                mes.txt3 = result[i].txt3;
                mes.txt4 = result[i].txt4;
                mes.content = result[i].content;
                listMes.Add(mes);
            }
            List<MesHeader> listSearch = listMes.FindAll(x => x.txt1.Contains(keyword)
            || x.txt2.Contains(keyword) || x.txt3.Contains(keyword));

            for (int i = 0; i < listSearch.Count; i++)
            {
                MessageHeader userControlMessage = new MessageHeader();
                userControlMessage.Name = "Mes" + i;
                if (i % 2 == 0)
                {
                    userControlMessage.backgroundColorMes = ConvertColor(242, 244, 246);
                }
                else
                {
                    userControlMessage.backgroundColorMes = ConvertColor(249, 250, 249);
                }
                //important
                foreach (var item in listImportant)
                {
                    if (item.idimportant == listMes[i].idmes)
                    {
                        userControlMessage.tagSecondPro = Visibility.Visible;
                        userControlMessage.tagFirstPro = Visibility.Collapsed;
                    }
                }
                userControlMessage.txtHeader1 = listSearch[i].txt1;
                userControlMessage.txtHeader2 = listSearch[i].txt2;
                userControlMessage.txtHeader3 = "-" + listSearch[i].txt3;
                string[] str = listSearch[i].txt4.Replace("-", "+").Split('+');

                userControlMessage.txtHeader4 = str[0];
                userControlMessage.txtId = listSearch[i].idmes;
                userControlMessage.txtContent = listSearch[i].content;


                userControlMessage.txtHeader1Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");
                userControlMessage.txtHeader2Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");
                userControlMessage.txtHeader3Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");
                userControlMessage.txtHeader4Font = new FontFamily("RobotoFont/Roboto-Thin.ttf#Roboto");

                userControlMessage.Margin = new Thickness(0, 0, 0, 5);
                gridMes.Children.Add(userControlMessage);
                userControlMessage.btnDetail += UserControlMessage_btnDetail;
                userControlMessage.btnCheckedClick += UserControlMessage_btnCheckedClick;
            }

        }

        private void txtKeyWordS_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (txtKeyWordS.Text.Length == 0)
            {
                gridMes.Children.Clear();
                reloadwithPage(i);
            }
            else
            {
                gridMes.Children.Clear();
                searchMail(txtKeyWordS.Text);
            }
        }


        //Reload with page 
        public async void reloadwithPage(int page)
        {
            try
            {
                SQLiteAsyncConnection conn = new SQLiteAsyncConnection("DBMail");
                var result = await conn.QueryAsync<MesHeader>("select * from mesheader");
                if (valuenext <= result.Count)
                {
                    txtTotalMes.Text = string.Format("{0}-{1} of {2}", i, valuenext, result.Count);
                }
                else
                {
                    txtTotalMes.Text = string.Format("{0}-{1} of {2}", i, result.Count, result.Count);
                }

                if (page == 1)
                {
                    leftRightMesDB(0);
                    btnRightMes.Background = ConvertColor(61, 98, 128);
                    btnLeftMes.Background = null;
                    btnRightMes.IsEnabled = true;
                    btnLeftMes.IsEnabled = false;
                }
                if (page >= 2)
                {
                    leftRightMesDB(valuenext - 26);
                    //btnLeftMes.Background = ConvertColor(61, 98, 128);
                    //btnLeftMes.IsEnabled = true;
                    //btnRightMes.Background = ConvertColor(61, 98, 128);
                    //btnRightMes.IsEnabled = true;
                }


            }
            catch (Exception) { }
        }

    }
}
