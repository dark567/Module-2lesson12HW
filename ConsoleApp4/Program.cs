namespace ConsoleApp4
{
    class Program
    {
        /*
         Напишите программу создания базы данных некоторого магазина мебели который еще торгует и сырьем.
         Мебель характеризуется производителем, сырье - размерами.
             */
        static void Main(string[] args)
        {
            AddNEWListForExample();

            foreach (var item in FurnitureLogic.GetFurniture)
            {
                System.Console.WriteLine($"Manufacturer:{item.ManufacturerName}, Count:{item.Count}");
            }

            foreach (var item in MaterialLogic.GetMaterial)
            {
                System.Console.WriteLine($"Material:{item.Type}, Height:{item.Height}, Length:{item.Length}, Weight:{item.Weight}");
            }


            System.Console.ReadKey();
        }

        /// <summary>
        /// Add FIRST List For Example
        /// </summary>
        static void AddNEWListForExample()
        {
            FurnitureLogic.AddFurniture(new Furniture(_name: "Anders Hejlsberg", _count: 10));
            FurnitureLogic.AddFurniture(new Furniture(_name: "Nike", _count: 15));
            FurnitureLogic.AddFurniture(new Furniture(_name: "Bosh", _count: 10));


            MaterialLogic.AddMaterial(new Material(type: "Woden", lenght: 100, height: 15, weight: 5));
            MaterialLogic.AddMaterial(new Material(type: "Metal", lenght: 100, height: 15, weight: 10.21));
            MaterialLogic.AddMaterial(new Material(type: "Sand", lenght: 100, height: 15, weight: 250));
        }
    }
}
