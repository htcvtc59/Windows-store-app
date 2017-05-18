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
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ReadWriteJsonObjS
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

        private void btnWriteJson_Click(object sender, RoutedEventArgs e)
        {
            writeJson();
        }

        private void btnReadJson_Click(object sender, RoutedEventArgs e)
        {
            readJson();
        }

        private const string JSONFILENAME = "car.json";
        public async void writeJson()
        {
            //List Buy Car
            List<BuyCar> myCar = new List<BuyCar>();
            var lstcar = new List<Car>();
            lstcar.Add(new Car() { id = int.Parse(tbIdCar.Text), make = tbMakeCar.Text, model = tbModelCar.Text, year = int.Parse(tbYearCar.Text) });
            myCar.Add(new BuyCar() { namecar = tbNameCar.Text, car = lstcar });
            //add more than car
            string content = String.Empty;
            var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);
            using (StreamReader reader = new StreamReader(myStream))
            {
                content = await reader.ReadToEndAsync();
                if (content.Length != 0)
                {
                    DataContractJsonSerializer seri = new DataContractJsonSerializer(typeof(List<BuyCar>));
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content));

                    List<BuyCar> buy = (List<BuyCar>)seri.ReadObject(ms);
                    myCar.AddRange(buy);
                    await ms.FlushAsync();
                }


            }
            //write
            var serializer = new DataContractJsonSerializer(typeof(List<BuyCar>));
            using (var stream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(
                JSONFILENAME,
                CreationCollisionOption.ReplaceExisting))
            {
                serializer.WriteObject(stream,myCar);
            }

            await new MessageDialog("Write success").ShowAsync();

        }
        //public async void readJson()
        //{
        //    string content = String.Empty;
        //    var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);
        //    using (StreamReader reader = new StreamReader(myStream))
        //    {
        //        content = await reader.ReadToEndAsync();

        //        DataContractJsonSerializer seri = new DataContractJsonSerializer(typeof(BuyCar));
        //        MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content));

        //        BuyCar buy = (BuyCar)seri.ReadObject(ms);
        //    }
        //}



        public async void readJson()
        {

            string content = String.Empty;
            var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);
            using (StreamReader reader = new StreamReader(myStream))
            {
                content = await reader.ReadToEndAsync();
                if (content.Length != 0)
                {
                    DataContractJsonSerializer seri = new DataContractJsonSerializer(typeof(List<BuyCar>));
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content));

                    List<BuyCar> myCar  = (List<BuyCar>)seri.ReadObject(ms);

                   
                    //List<Car> lstCar = new List<Car>();
                    //foreach (BuyCar item in myCar)
                    //{
                    //    lstCar.AddRange(item.car);
                    //}
                    //lvCar.ItemsSource = lstCar;
                    lvCar.ItemsSource = myCar;

                }
            }
        }



    }
}
