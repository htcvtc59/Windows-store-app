using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZingMp3App
{
    [DataContract]
    public class ArtistList
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string link { get; set; }
    }

   [DataContract]
    public class Datum
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public int order { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string artist { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string cover { get; set; }
        [DataMember]
        public List<ArtistList> artist_list { get; set; }
        [DataMember]
        public List<string> qualities { get; set; }
        [DataMember]
        public List<string> source_list { get; set; }
        [DataMember]
        public string source_base { get; set; }
        [DataMember]
        public string lyric { get; set; }
        [DataMember]
        public string mv_link { get; set; }
    }
    [DataContract]
    public class RootObject
    {
        [DataMember]
        public string msg { get; set; }
        [DataMember]
        public List<Datum> data { get; set; }
    }

}
