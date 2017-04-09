using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
