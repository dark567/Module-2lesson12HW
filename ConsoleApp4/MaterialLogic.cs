using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MaterialLogic:IMaterial
    {
        public static Material[] GetMaterial
        {
            get
            {
                return Material._modelMaterial.ToArray();
            }
        }

        public static void AddMaterial(Material _modelMaterial)
        {
            Material._modelMaterial.Add(_modelMaterial);
        }

        public void Add(Material _modelMaterial)
        {
            Material._modelMaterial.Add(_modelMaterial);
        }

        public void Del(int index)
        {
            Material._modelMaterial.RemoveAt(index);
        }
    }
}
