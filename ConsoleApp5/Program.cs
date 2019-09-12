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
            Console.WriteLine($"Flower Type\t\t Price\t\tDataPost");
            for (int i = 0; i < RosesLogic.GetRoses.Length; i++)
            {
                Console.WriteLine($"{RosesLogic.GetRoses[i].Type,5}\t {RosesLogic.GetRoses[i].Price,5}\t{RosesLogic.GetRoses[i].DataPost.ToString("dd-MM-yyyy"),17}");
            }
            Console.WriteLine(new string('-',50));
            for (int i = 0; i < CarnationsLogic.GetCarnations.Length; i++)
            {
                Console.WriteLine($"{CarnationsLogic.GetCarnations[i].Type,1}\t{CarnationsLogic.GetCarnations[i].Price,5}\t{CarnationsLogic.GetCarnations[i].DataPost.ToString("dd-MM-yyyy"),17}");
            }
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < TulipsLogic.GetTulips.Length; i++)
            {
                Console.WriteLine($"{TulipsLogic.GetTulips[i].Type,5}\t {TulipsLogic.GetTulips[i].Price,5}\t{TulipsLogic.GetTulips[i].DataPost.ToString("dd-MM-yyyy"),17}");
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Bouquet Name\t\t Type\t\t\tPrice\tCount");
            for (int i = 0; i < BouquetOfFlowersLogic.GetBouquetOfFlowers.Length; i++)
            {
                Console.WriteLine($"{BouquetOfFlowersLogic.GetBouquetOfFlowers[i].Name,5}\t{BouquetOfFlowersLogic.GetBouquetOfFlowers[i].Type,5}\t {BouquetOfFlowersLogic.GetBouquetOfFlowers[i].Price,5}\t{BouquetOfFlowersLogic.GetBouquetOfFlowers[i].Count,5}");
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

            Random ran = new Random();
            int count;
            for (int i = 0; i < RosesLogic.GetRoses.Length; i++)
            {
                count = ran.Next(1, 21);
               BouquetOfFlowersLogic.AddBouquetOfFlowers(new BouquetOfFlowers(name: $"Perfect Bouquet_{i}", type: RosesLogic.GetRoses[i].Type, count: count, priceOut: RosesLogic.GetRoses[i].Price));
            }
            for (int i = 0; i < CarnationsLogic.GetCarnations.Length; i++)
            {
                count = ran.Next(1, 21);
                BouquetOfFlowersLogic.AddBouquetOfFlowers(new BouquetOfFlowers(name: $"Perfect Bouquet_{i}", type: CarnationsLogic.GetCarnations[i].Type, count: count, priceOut: CarnationsLogic.GetCarnations[i].Price));
            }
            for (int i = 0; i < TulipsLogic.GetTulips.Length; i++)
            {
                count = ran.Next(1, 21);
                BouquetOfFlowersLogic.AddBouquetOfFlowers(new BouquetOfFlowers(name: $"Perfect Bouquet_{i}", type: TulipsLogic.GetTulips[i].Type, count: count, priceOut: TulipsLogic.GetTulips[i].Price));
            }
        }
    }
}
