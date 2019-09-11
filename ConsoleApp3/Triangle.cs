using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Triangle : Figure, ITriangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Triangle(Point a, Point b, Point c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public static List<Triangle> SetListTriangle()
        {
            return new List<Triangle>
            {
             new Triangle( a: new Point { X = 0, Y = 0 }, b: new Point { X = 5, Y = 5 }, c: new Point { X = 10, Y = 5 }),
             new Triangle( a: new Point { X = 0, Y = 0 }, b: new Point { X = 5, Y = 2 }, c: new Point { X = 5, Y = 2 }),
             new Triangle( a: new Point { X = 0, Y = 0 }, b: new Point { X = 3, Y = 1 }, c: new Point { X = 6, Y = 4 })
             };
        }
        public override double Perimeter()
        {
            return Length(A, B) + Length(B, C) + Length(C, A);
        }

        public override double Squire()
        {
            return (Height(A, B, C) + TriangleBase(A, B, C)) / 2;
        }

        public double Length(Point a, Point b)
        {
            double aXbX;
            if (a.X < b.X) aXbX = b.X - a.X;
            else if (a.X > b.X) aXbX = a.X - b.X;
            else aXbX = 0;

            double aYbY = 0;
            if (a.Y < b.Y) aYbY = b.Y - a.Y;
            else if (a.Y > b.Y) aYbY = a.Y - b.Y;
            else aYbY = 0;

            return Convert.ToDouble(Math.Sqrt(Math.Pow((aXbX), 2) + Math.Pow((aYbY), 2)));
        }

        public double Height(Point a, Point b, Point c)
        {
            double yMax = Math.Max(a.Y, Math.Max(b.Y, c.Y));
            double yMin = Math.Min(a.Y, Math.Min(b.Y, c.Y));
            return yMax - yMin;
        }

        public double TriangleBase(Point a, Point b, Point c)
        {
            double xMax = Math.Max(a.X, Math.Max(b.X, c.X));
            double xMin = Math.Min(a.X, Math.Min(b.X, c.X));
            return xMax - xMin;
        }

    }
}
