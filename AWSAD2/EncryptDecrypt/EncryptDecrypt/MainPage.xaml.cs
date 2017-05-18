using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace EncryptDecrypt
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

        public static byte[] Encrypt(string plainText,string pw,string salt)
        {
            IBuffer pwBuffer = CryptographicBuffer.ConvertStringToBinary(pw, BinaryStringEncoding.Utf8);
            IBuffer saltBuffer = CryptographicBuffer.ConvertStringToBinary(salt, BinaryStringEncoding.Utf16LE);
            IBuffer plainBuffer = CryptographicBuffer.ConvertStringToBinary(plainText, BinaryStringEncoding.Utf16LE);
            KeyDerivationAlgorithmProvider key = KeyDerivationAlgorithmProvider.OpenAlgorithm("PBKDF2_SHA1");
            KeyDerivationParameters parm = KeyDerivationParameters.BuildForPbkdf2(saltBuffer,1000);
            CryptographicKey ckey = key.CreateKey(pwBuffer);
            IBuffer keyMaterial = CryptographicEngine.DeriveKeyMaterial(ckey, parm, 32);
            CryptographicKey dkey = key.CreateKey(pwBuffer);
            IBuffer saltMaterial = CryptographicEngine.DeriveKeyMaterial(dkey, parm, 16);
            SymmetricKeyAlgorithmProvider sp = SymmetricKeyAlgorithmProvider.OpenAlgorithm("AES_CBC_PKCS7");
            CryptographicKey symkey = sp.CreateSymmetricKey(keyMaterial);
            IBuffer resultBuffer = CryptographicEngine.Encrypt(symkey, plainBuffer, saltMaterial);
            byte[] result;
            CryptographicBuffer.CopyToByteArray(resultBuffer, out result);
            return result;
        }
        public static string Decrypt(byte[] encryptval,string pw,string salt)
        {
            IBuffer pwBuffer = CryptographicBuffer.ConvertStringToBinary(pw, BinaryStringEncoding.Utf8);
            IBuffer saltBuffer = CryptographicBuffer.ConvertStringToBinary(salt, BinaryStringEncoding.Utf16LE);
            IBuffer cipherBuffer = CryptographicBuffer.CreateFromByteArray(encryptval);
            KeyDerivationAlgorithmProvider key = KeyDerivationAlgorithmProvider.OpenAlgorithm("PBKDF2_SHA1");
            KeyDerivationParameters parm = KeyDerivationParameters.BuildForPbkdf2(saltBuffer, 1000);
            CryptographicKey ckey = key.CreateKey(pwBuffer);
            IBuffer keyMaterial = CryptographicEngine.DeriveKeyMaterial(ckey, parm, 32);
            CryptographicKey dkey = key.CreateKey(pwBuffer);
            IBuffer saltMaterial = CryptographicEngine.DeriveKeyMaterial(dkey, parm, 16);
            SymmetricKeyAlgorithmProvider sp = SymmetricKeyAlgorithmProvider.OpenAlgorithm("AES_CBC_PKCS7");
            CryptographicKey symmKey = sp.CreateSymmetricKey(keyMaterial);
            IBuffer resultBuffer = CryptographicEngine.Decrypt(symmKey,cipherBuffer,saltMaterial);
            string result = CryptographicBuffer.ConvertBinaryToString(BinaryStringEncoding.Utf16LE, resultBuffer);
            return result; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte[] encrypt;
            encrypt = Encrypt(txtText.Text, "pw", "salt");
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            txtEncrypted.Text = encoding.GetString(encrypt, 0, encrypt.Count());
            txtDecrypted.Text = Decrypt(encrypt, "pw", "salt");
        }


    }
}
