using ConsoleApp5.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        /*
         Необходимо реализовать иерархию цветов (розы, гвоздики, тюльпаны). Создать несколько объектов-цветов. 
         Собрать букет с определением его стоимости. В букет может входить несколько цветов одного типа.

        в принципе стандартный CRUD. Для разнообразия можно хранить в файле (save/load). 
        Все товары должны наследовать абстрактный класс с базовым набором полей (имя, цена, и т.д.) 
        + кастомный интерфейс (напр. сборка, разборка или что-то в этом духе).
             */
        static void Main(string[] args)
        {
            AddNEWListForExample();

            for (int i = 0; i < RosesLogic.GetRoses.Length; i++)
            {
                Console.WriteLine($"{RosesLogic.GetRoses[i].Type}:{RosesLogic.GetRoses[i].Price}:{RosesLogic.GetRoses[i].DataPost.ToString("dd-MM-yyyy")}");
            }
            Console.WriteLine(new string('-',35));
            for (int i = 0; i < CarnationsLogic.GetCarnations.Length; i++)
            {
                Console.WriteLine($"{CarnationsLogic.GetCarnations[i].Type}:{CarnationsLogic.GetCarnations[i].Price}:{CarnationsLogic.GetCarnations[i].DataPost.ToString("dd-MM-yyyy")}");
            }
            Console.WriteLine(new string('-', 35));
            for (int i = 0; i < TulipsLogic.GetTulips.Length; i++)
            {
                Console.WriteLine($"{TulipsLogic.GetTulips[i].Type}:{TulipsLogic.GetTulips[i].Price}:{TulipsLogic.GetTulips[i].DataPost.ToString("dd-MM-yyyy")}");
            }

            Console.ReadKey();

        }

        static void AddNEWListForExample()
        {
            RosesLogic.AddRoses(new Roses(_type: "Red Barhat", _price: 10.99, _count:13, _dataPost: null));
            RosesLogic.AddRoses(new Roses(_type: "Black Barhat", _price: 75, _count: 13, _dataPost: null));
            RosesLogic.AddRoses(new Roses(_type: "White Prince", _price: 16, _count: 13, _dataPost: null));

            CarnationsLogic.AddCarnations(new Carnations(_type: "Black Prince", _price: 10.99, _count: 13, _dataPost: null));
            CarnationsLogic.AddCarnations(new Carnations(_type: "White Barhat", _price: 10.99, _count: 13, _dataPost: null));
            CarnationsLogic.AddCarnations(new Carnations(_type: "Red Barhat", _price: 10.99, _count: 13, _dataPost: null));

            TulipsLogic.AddTulips(new Tulips(_type: "White Barhat", _price: 10.99, _count: 13, _dataPost: null));
            TulipsLogic.AddTulips(new Tulips(_type: "Red Barhat", _price: 10.99, _count: 13, _dataPost: null));
            TulipsLogic.AddTulips(new Tulips(_type: "Red Prince", _price: 10.99, _count: 13, _dataPost: null));

        }
    }
}
