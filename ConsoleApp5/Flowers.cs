using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Flowers
    {
        public abstract string Type { get; set; }
        public abstract double Price { get; set; }
        public abstract int Count { get; set; }
        public abstract DateTime DataPost { get; set; }
    }
}
