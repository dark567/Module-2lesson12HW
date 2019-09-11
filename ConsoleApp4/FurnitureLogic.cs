using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class FurnitureLogic
    {

        public static Furniture[] GetFurniture
        {
            get
            {
                return Furniture._modelFurniture.ToArray();
            }
        }

        public static void AddFurniture(Furniture _modelMaterial)
        {
            Furniture._modelFurniture.Add(_modelMaterial);
        }
    }
}
