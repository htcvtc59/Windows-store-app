using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMGmailAWSAD2
{
    public class MesHeader
    {
        [SQLite.PrimaryKey]
        public string idmes { get; set; }
        public string content { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txt3 { get; set; }
        public string txt4 { get; set; }

    }
}
