using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExamContact
{
    [DataContract]
    class Contact
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string number { get; set; }
        [DataMember]
        public string group { get; set; }
        [DataMember]
        public string image { get; set; }
        [DataMember]
        public string nameimage { get; set; }
    }
}
