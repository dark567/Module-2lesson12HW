using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*
         Создайте класс окружностей на плоскости, описав в нём все необходимые свойства, подобрав им понятные имена и правильные типы данных.
         Опишите в классе конструктор, позволяющий при создании нового объекта явно задать все его свойства. 
         Если это необходимо, то проверьте допустимость их значений в конструкторе (например, в классе обыкновенных дробей нельзя создавать дробь с нулевым знаменателем).
         Создайте в классе метод, проверяющий имеют ли две окружности равную площадь.
         С использованием построенного класса создайте две окружности: одну с центром в (0;0) и радиусом 12, а вторую с центром в (3;5) и радиусом 11. 
         Проверьте с помощью созданного метода равна ли их площадь и если равна, то выведите соответсвующее сообщение на экран.
             */
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(_centr: new Point { X = 0, Y = 0 }, _radios: 12);
            Circle circle2 = new Circle(_centr: new Point { X = 3, Y = 5 }, _radios: 11);
            Circle circle3 = new Circle(_centr: new Point { X = 0, Y = 0 }, _radios: 10);

            Console.WriteLine(circle1 == circle2 ? "circle1 = circle2" : "circle1 != circle2");

            Console.WriteLine(circle1.Equals(circle2) ? "circle1 equals circle2 " : "circle1 don't equals circle2");
            
            Console.WriteLine(circle1.EqualsSquareCircles(circle1, circle2)? "Square circles equals" : "Square circles do not equals");

            Console.ReadKey();
        }
    }
}
