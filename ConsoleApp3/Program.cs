using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        /*
         Есть фигуры (круг, треугольник, прямоугольник), с различными свойствами, но над каждой фигурой можно производить одинаковые действия. 
         Фигуры должны уметь отдавать информацию о себе в определенном формате, которую некая функция будет выводить в какой-нибудь вывод 
         (консоль, текстовый файл). При этом некоторые фигуры могут быть вариациями других (эллипс, квадрат).
             */
        static void Main(string[] args)
        {
            List<Kvadrat> listKvadrat = Kvadrat.SetListKvadrat();
            List<Circle> listCircle = Circle.SetListCircle();
            List<Triangle> listTriangle = Triangle.SetListTriangle();

            Console.WriteLine("Kvadrat");
            for (int i = 0; i < listKvadrat.Count; i++)
            {
                Console.WriteLine($"[{i}]:Perimeter{listKvadrat[i].Perimeter():F2}");
                Console.WriteLine($"[{i}]:Square:{listKvadrat[i].Squire():F2}");
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("Circle");
            for (int i = 0; i < listCircle.Count; i++)
            {
                Console.WriteLine($"[{i}]:Perimeter{listCircle[i].Perimeter():F2}");
                Console.WriteLine($"[{i}]:Square:{listCircle[i].Squire():F2}");
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("Triangle");
            for (int i = 0; i < listTriangle.Count; i++)
            {
                Console.WriteLine($"[{i}]:Perimeter{listTriangle[i].Perimeter():F2}");
                Console.WriteLine($"[{i}]:Square:{listTriangle[i].Squire():F2}");
                Console.WriteLine("--------------------------");
            }

            Console.ReadLine();
        }
    }
}
