using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Trapecia> listTrap = Trapecia.GetSampleProducts();

           // listTrap = Trapecia.GetSampleProducts();

            for (int i = 0; i < listTrap.Count; i++)
            {
                Console.WriteLine($"list[{i}]:{listTrap[i].CheckRavn()}");
                Console.WriteLine($"list[{i}]:LengthSides:{listTrap[i].LengthSides():F2}");
                Console.WriteLine($"list[{i}]:Perimeter{listTrap[i].Perimeter():F2}");
                Console.WriteLine($"list[{i}]:Square:{listTrap[i].Square()}");
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine($"Count List:{listTrap.Where(n => n.Square() > listTrap.Average(p => p.Square())).Count()}, where List Square > {listTrap.Average(n => n.Square())}");

            Console.ReadLine();
        }


    }
}
