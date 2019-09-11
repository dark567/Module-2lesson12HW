using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Material
    {
        public double Height { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }

        public static List<Material> _modelMaterial;

        static Material()
        {
            _modelMaterial = new List<Material>();
        }

        public Material(double height, double lenght, double weight, string type = "n/a")
        {
            this.Height = height;
            this.Length = lenght;
            this.Weight = weight;
            this.Type = type;
        }


    }
}
