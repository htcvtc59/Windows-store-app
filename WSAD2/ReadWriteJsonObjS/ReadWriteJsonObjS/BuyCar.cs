using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteJsonObjS
{
    [DataContract]
    class BuyCar
    {
        [DataMember]
        public string namecar { get; set; }
        [DataMember]
        public List<Car> car;
    }
    [DataContract]
    public class Car
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string make { get; set; }
        [DataMember]
        public string model { get; set; }
        [DataMember]
        public int year { get; set; }
    }
}
