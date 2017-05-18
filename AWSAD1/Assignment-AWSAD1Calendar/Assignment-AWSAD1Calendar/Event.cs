using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Assignment_AWSAD1Calendar
{
    [DataContract]
    public class Event
    {
        [DataMember]
        public string NameEvent { get; set; }
        [DataMember]
        public string DayS { get; set; }
        [DataMember]
        public string MonthS { get; set; }
        [DataMember]
        public string YearS { get; set; }
        [DataMember]
        public string HourS { get; set; }
        [DataMember]
        public string AMPMS { get; set; }
        //
        [DataMember]
        public string DayE { get; set; }
        [DataMember]
        public string MonthE { get; set; }
        [DataMember]
        public string YearE { get; set; }
        [DataMember]
        public string HourE { get; set; }
        [DataMember]
        public string AMPME { get; set; }
        //
        [DataMember]
        public string Description { get; set; }


    }
    

    public class EventManager
    {
        private const string JSONFILENAME = "event.json";
        public static async Task<List<Event>> GetEvent()
        {
            List<Event> events = new List<Event>();

            string content = String.Empty;
            await ApplicationData.Current.LocalFolder.CreateFileAsync(JSONFILENAME, CreationCollisionOption.OpenIfExists);
            var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);
            using (StreamReader reader = new StreamReader(myStream))
            {
                content = await reader.ReadToEndAsync();
                if (content.Length != 0)
                {
                    DataContractJsonSerializer seri = new DataContractJsonSerializer(typeof(List<Event>));
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content));

                    List<Event> myEvent = (List<Event>)seri.ReadObject(ms);


                    events = myEvent;
                }
            }
            return events;
        }

    }



}
