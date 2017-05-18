using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabaseSqLite
{
    public class Product
    {
        [SQLite.AutoIncrement, SQLite.PrimaryKey]
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
    }
}
