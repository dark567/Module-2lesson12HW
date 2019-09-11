using ConsoleApp5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Roses : Flowers, IRoses
    {
        private string type;
        private double price;
        private int count;
        private DateTime dataPost;

        public static List<Roses> _modelRoses;

        static Roses()
        {
            _modelRoses = new List<Roses>();

        }

        public Roses(string _type, double _price, int _count, DateTime? _dataPost)
        {
            this.type = _type;
            this.price = _price;
            this.count = _count;
            this.dataPost = _dataPost ?? DateTime.Now;
            //this.dataPost = _dataPost == null ? DateTime.Now: DateTime.Now;
        }

        public override string Type
        {
            get { return "Roses: " + type; }
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

        public override int Count
        {
            get
            {
                if (count > 0) return count;
                else throw new Exception("count < 0");
            }
            set { count = value; }
        }

        public void Obrezka()
        {
            Console.WriteLine("Obrezka");
        }
    }
}
