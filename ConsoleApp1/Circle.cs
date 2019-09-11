using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Point
    {
        public double X;
        public double Y;
    }
    public class Circle : ICircle
    {
        public Point Centr;
        public int Radius;

        public Circle(Point _centr, int _radios)
        {
            this.Centr = _centr;
            if (_radios <= 0) Console.WriteLine("Radius <= 0 !");
            else this.Radius = _radios;
        }

        public double SquareCircle()
        {
            return Math.PI * Math.Pow(Radius,2)*0.5;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Circle circle = (Circle)obj;
                return (this.Radius == circle.Radius) && (this.Centr.X == circle.Centr.X && this.Centr.Y == circle.Centr.Y);
            }
        }

        public override string ToString()
        {
            return String.Format($"Circle({this.Radius}, {this.Centr})");
        }


        public bool EqualsSquareCircles(Circle circle1, Circle circle2)
        {
            return circle1.SquareCircle() == circle2.SquareCircle();
        }
    }
}
