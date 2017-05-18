using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZingMp3App
{
    [DataContract]
    public class Datum2
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string artist { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string cover { get; set; }
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
    public class RootObject2
    {
        [DataMember]
        public int msg { get; set; }
        [DataMember]
        public List<Datum2> data { get; set; }
    }


}
