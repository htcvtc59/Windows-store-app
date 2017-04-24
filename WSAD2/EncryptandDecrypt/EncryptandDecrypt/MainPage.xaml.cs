using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

namespace EncryptandDecrypt
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

        private async void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            string plainString = txtPlainString.Text;
            string key = txtKey.Text;

            string encryptedString = await EncryptStringHelper(plainString, key);

            txtEncryptedString.Text = encryptedString;
        }

        private async void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            string encryptedString = txtEncryptedString.Text;
            string key = txtKey.Text;

            string decryptedString = await DecryptStringHelper(encryptedString, key);

            txtdecryptedString.Text = decryptedString;
        }

        private async Task<string> EncryptStringHelper(string plainString, string key)
        {
            try
            {
                var hashKey = GetMD5Hash(key);
                var decryptBuffer = CryptographicBuffer.ConvertStringToBinary(plainString, BinaryStringEncoding.Utf16BE);
                var AES = SymmetricKeyAlgorithmProvider.OpenAlgorithm(SymmetricAlgorithmNames.AesEcbPkcs7);
                var symmetricKey = AES.CreateSymmetricKey(hashKey);
                var encryptedBuffer = CryptographicEngine.Encrypt(symmetricKey, decryptBuffer, null);
                var encryptedString = CryptographicBuffer.EncodeToBase64String(encryptedBuffer);
                return encryptedString;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        private async Task<string> DecryptStringHelper(string encryptedString, string key)
        {
            try
            {
                var hashKey = GetMD5Hash(key);
                IBuffer decryptBuffer = CryptographicBuffer.DecodeFromBase64String(encryptedString);
                var AES = SymmetricKeyAlgorithmProvider.OpenAlgorithm(SymmetricAlgorithmNames.AesEcbPkcs7);
                var symmetricKey = AES.CreateSymmetricKey(hashKey);
                var decryptedBuffer = CryptographicEngine.Decrypt(symmetricKey, decryptBuffer, null);
                string decryptedString = CryptographicBuffer.ConvertBinaryToString(BinaryStringEncoding.Utf16BE, decryptedBuffer);
                return decryptedString;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        private static IBuffer GetMD5Hash(string key)
        {
            IBuffer bufferUTF8Msg = CryptographicBuffer.ConvertStringToBinary(key, BinaryStringEncoding.Utf16BE);
            HashAlgorithmProvider hashAlgorithmProvider = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha512);
            IBuffer hashBuffer = hashAlgorithmProvider.HashData(bufferUTF8Msg);
            if (hashBuffer.Length != hashAlgorithmProvider.HashLength)
            {
                throw new Exception("There was an error creating the hash");
            }
            return hashBuffer;
        }

    }
}
