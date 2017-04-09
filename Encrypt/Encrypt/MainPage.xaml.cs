using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Encrypt
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

        private void btnEncode_Click(object sender, RoutedEventArgs e)
        {
            string hashAlgorithm = HashAlgorithmNames.Sha512;
            HashAlgorithmProvider hashAlgorithmProvider = HashAlgorithmProvider.OpenAlgorithm(hashAlgorithm);
            CryptographicHash hashObj = hashAlgorithmProvider.CreateHash();
            string content = txtContent.Text;
            IBuffer buffStr = CryptographicBuffer.ConvertStringToBinary(content, BinaryStringEncoding.Utf16BE);
            hashObj.Append(buffStr);
            IBuffer buffHash = hashObj.GetValueAndReset();
            string hashStr = CryptographicBuffer.EncodeToBase64String(buffHash);
            
            txtEncode.Text = hashStr;


        }

        private void btnDecode_Click(object sender, RoutedEventArgs e)
        {
            string strBase64 = txtEncode.Text;
            IBuffer buffer = CryptographicBuffer.DecodeFromBase64String(strBase64);
            string strbase = CryptographicBuffer.ConvertBinaryToString(BinaryStringEncoding.Utf16BE,buffer);
            
            string strBase64New = CryptographicBuffer.EncodeToBase64String(buffer);

            txtDecode.Text = strbase;
            

        }
    }
}
