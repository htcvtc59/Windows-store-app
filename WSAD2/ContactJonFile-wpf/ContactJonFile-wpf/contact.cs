using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ContactJonFile_wpf
{   
    [DataContract]
    class contact
    {  
        [DataMember(Name ="name")]
        public string name { get; set; }
        [DataMember(Name ="phone")]
        public string phone { get; set; }
        [DataMember(Name ="group")]
        public string group { get; set; }                                                                                                      
    }
}
