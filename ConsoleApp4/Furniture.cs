using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Furniture : Manufacturer
    {
        private string manufacturerName;
        private int count;

        public Guid Id { get; set; }

        public static List<Furniture> _modelFurniture;

        public override string ManufacturerName
        {
            get { return "Produced by " + manufacturerName; }
            set { manufacturerName = value; }
        }

        public override int Count
        {
            get { return count; }
            set { count = value; }
        }

        static Furniture()
        {
            _modelFurniture = new List<Furniture>();

        }

        public Furniture(string _name, int _count)
        {
            this.manufacturerName = _name;
            if (_count < 0) this.count = 0;
            else this.count = _count;

        }
    }
}
