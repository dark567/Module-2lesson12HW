using System.Collections.Generic;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public struct Point
    {
        public double X;
        public double Y;
    }

    public class Kvadrat : Figure, IKvadrat
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        public Kvadrat(Point a, Point b, Point c, Point d) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }

        public static List<Kvadrat> SetListKvadrat()
        {
            return new List<Kvadrat>
            {
             new Kvadrat( a: new Point { X = 0, Y = 0 }, b: new Point { X = 5, Y = 5 }, c: new Point { X = 10, Y = 5 } ,d: new Point { X = 10, Y = 0 }),
            new Kvadrat( a: new Point { X = 0, Y = 0 }, b: new Point { X = 5, Y = 2 }, c: new Point { X = 5, Y = 2 } ,d: new Point { X = 10, Y = 0 }),
            new Kvadrat( a: new Point { X = 0, Y = 0 }, b: new Point { X = 3, Y = 1 }, c: new Point { X = 6, Y = 4 } ,d: new Point { X = 9, Y = 0 }),
             new Kvadrat( a: new Point { X = 0, Y = 0 }, b: new Point { X = 5, Y = 5 }, c: new Point { X = 10, Y = 5 } ,d: new Point { X = 10, Y = 0 })
             };
        }

        /// <summary>
        /// Squire
        /// </summary>
        /// <returns></returns>
        public override double Squire()
        {
            return LengthAD(A, D) * LengthAB(A, B);
        }

        /// <summary>
        /// Perimeter
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return (LengthAD(A,D) + LengthAB(A,B)) * 2;
        }

        /// <summary>
        /// from Interface
        /// </summary>
        /// <returns></returns>
        public bool CheckEqualsSides()
        {
            return LengthAD(A, D) == LengthAB(A, B);
        }

        /// <summary>
        /// shirina
        /// </summary>
        /// <param name="a"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public double LengthAD(Point a, Point d)
        {
            return d.X - a.X;
        }
        /// <summary>
        /// lenght
        /// </summary>
        /// <param name="a"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double LengthAB(Point a, Point b)
        {
            return b.Y - a.Y;
        }
    }
}
