using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public struct Point
    {
        public double X;
        public double Y;
    }

    public class Trapecia : Figure
    {
        public Point A { get; set; }
        public Point B { get; set; }

        public Point C { get; set; }
        public Point D { get; set; }

        public Trapecia(Point A, Point B, Point C, Point D) : base()
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }

        public static List<Trapecia> GetSampleProducts()
        {
            return new List<Trapecia>
            {
             new Trapecia( A: new Point { X = 0, Y = 0 }, B: new Point { X = 5, Y = 5 }, C: new Point { X = 10, Y = 5 } ,D: new Point { X = 10, Y = 0 }),
            new Trapecia( A: new Point { X = 0, Y = 0 }, B: new Point { X = 5, Y = 2 }, C: new Point { X = 5, Y = 2 } ,D: new Point { X = 10, Y = 0 }),
            new Trapecia( A: new Point { X = 0, Y = 0 }, B: new Point { X = 3, Y = 1 }, C: new Point { X = 6, Y = 4 } ,D: new Point { X = 9, Y = 0 }),
             new Trapecia( A: new Point { X = 0, Y = 0 }, B: new Point { X = 5, Y = 5 }, C: new Point { X = 10, Y = 5 } ,D: new Point { X = 10, Y = 0 })
             };
        }

        public override bool CheckRavn()
        {
            double lengthA = LengthAB(A, B);
            double lengthB = LengthAB(C, D);

            return lengthA == lengthB ? true : false;
        }

        public override double LengthSides()
        {
            double lengthA = LengthAB(A, B);
            double lengthB = LengthAB(C, D);

            return lengthA + lengthB;
        }

        public override double Perimeter()
        {
            double lengthA = LengthAB(A, B);
            double lengthB = LengthAB(C, D);
            double lengthC = LengthCD(C, B);
            double lengthD = LengthCD(D, A);

            return lengthA + lengthB + lengthC + lengthD;
        }

        public override double Square()
        {
            double lengthB = LengthCD(C, B);
            double lengthC = LengthCD(D, A);
            double h = Convert.ToDouble(B.Y - A.Y);

            return ((lengthB + lengthC) * h) / 2;
        }

        public double LengthAB(Point a, Point b)
        {
            return Convert.ToDouble(Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2)));
        }
        public double LengthCD(Point a, Point b)
        {
            return Convert.ToDouble(a.X - b.X);
        }


    }


}
