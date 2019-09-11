using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public struct PointCircle
    {
        public int X;
        public int Y;
    }
    public class Circle : Figure
    {
        public Point Centr;
        public int Radius;



        public Circle(Point _centr, int _radios)
        {
            this.Centr = _centr;
            if (_radios <= 0) Console.WriteLine("Radius <= 0 !");
            else this.Radius = _radios;
        }

        public static List<Circle> SetListCircle()
        {
            return new List<Circle>
            {
             new Circle(_centr: new Point  { X = 0, Y = 0 }, _radios: 10),
             new Circle(_centr: new Point  { X = 2, Y = 1 }, _radios: 13),
             new Circle(_centr: new Point  { X = 0, Y = 5 }, _radios: 15)
             };
        }


        public override double Perimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override double Squire()
        {
            return Math.PI * Math.Pow(Radius, 2) * 0.5;
        }
    }
}
