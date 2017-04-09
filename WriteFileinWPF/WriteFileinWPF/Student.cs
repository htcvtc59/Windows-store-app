using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFileinWPF
{
    class Student
    {
        public string id1 { get; set; }
        public string name1 { get; set; }
        public float mark1 { get; set; }
        public string class1 { get; set; }
        public string gender1 { get; set; }


        public override string ToString()
        {
            return id1 + "#" + name1 + "#" + mark1 + "#" + class1 + "#" + gender1;
        }

    }
}
