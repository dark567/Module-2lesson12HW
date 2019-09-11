using ConsoleApp5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Tulips : Flowers, ITulips
    {
        public string type;
        public double price;
        public int count;
        public DateTime dataPost;

        public static List<Tulips> _modelTulips;

        static Tulips()
        {
            _modelTulips = new List<Tulips>();

        }

        public Tulips(string _type, double _price, int _count, DateTime? _dataPost)
        {
            this.type = _type;
            this.price = _price;
            this.count = _count;
            this.dataPost = _dataPost ?? DateTime.Now;
        }

        public override string Type
        {
            get { return "Tulips: " + type; }
            set { type = value; }
        }

        public override double Price
        {
            get
            {
                if (price > 0) return price;
                else throw new Exception("price < 0");
            }
            set { price = value; }
        }

        public override DateTime DataPost
        {
            get { return dataPost; }
            set { dataPost = DateTime.Now; }
        }

        public override int Count {
            get {
                if (count > 0) return count;
                else throw new Exception("count < 0");
            }
            set { count = value; }
        }

        public void Poliv()
        {
            Console.WriteLine("Poliv");
        }
    }
}
