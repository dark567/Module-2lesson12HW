using ConsoleApp5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class BouquetOfFlowers : IBouquetOfFlowers
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public static List<BouquetOfFlowers> _bouquetOfFlowers;

        static BouquetOfFlowers()
        {
            _bouquetOfFlowers = new List<BouquetOfFlowers>();
        }

        public BouquetOfFlowers(string name, string type, int count, double price)
        {
            this.Name = name;
            this.Type = type;
            this.Count = count;
            this.Price = price;
        }
    }
}
