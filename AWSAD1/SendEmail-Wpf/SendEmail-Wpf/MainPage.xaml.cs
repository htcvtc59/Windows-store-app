using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
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

namespace SendEmail_Wpf
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
        StorageFile AttachFile;
        private async void btnAttachFile_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker filePicker = new FileOpenPicker();
            filePicker.FileTypeFilter.Clear();
            filePicker.FileTypeFilter.Add(".doc");
            filePicker.FileTypeFilter.Add(".png");
            filePicker.FileTypeFilter.Add(".txt");
            filePicker.FileTypeFilter.Add(".jpg");
            AttachFile = await filePicker.PickSingleFileAsync();

        }

        private async void btnSend_Click(object sender, RoutedEventArgs e)
        {
            MailBuilder myMail = new MailBuilder();
            string message = string.Empty;
            txtMessage.Document.GetText(Windows.UI.Text.TextGetOptions.AdjustCrlf, out message);
            myMail.Html = message;
            myMail.Subject = txtSubject.Text;
            await myMail.AddAttachment(AttachFile);
            myMail.To.Add(new MailBox(txtTo.Text));
            myMail.From.Add(new MailBox(txtFrom.Text));
            myMail.Cc.Add(new MailBox(txtCC.Text));
            myMail.Bcc.Add(new MailBox(txtBCc.Text));
            IMail email = myMail.Create();
            using (Smtp smtp = new Smtp())
            {
                await smtp.Connect("smtp.gmail.com",587);
                await smtp.UseBestLoginAsync("osxunixl@gmail.com", "Osxunix97");
                await smtp.SendMessageAsync(email);
                await smtp.CloseAsync();
                await new MessageDialog("mail send success").ShowAsync();


            }


        }
    }
}
