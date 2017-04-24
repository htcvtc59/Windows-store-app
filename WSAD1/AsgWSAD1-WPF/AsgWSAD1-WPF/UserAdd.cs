using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace AsgWSAD1_WPF
{
    class UserAdd
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string group { get; set; }
        public string location { get; set; }
        public string avatar { get; set; }
        public string nameimg { get; set; }
        public BitmapImage imgavatar { get; set; }

        public override string ToString()
        {
            return name + " " + phone + " " + group + " " + location + " " + avatar + " " + nameimg + "\n";
        }
    }
}
