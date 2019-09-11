using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Manufacturer
    {
        public abstract string ManufacturerName { get; set; }
        public abstract int Count { get; set; }
    }
}
