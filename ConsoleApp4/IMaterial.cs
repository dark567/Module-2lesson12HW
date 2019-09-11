using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IMaterial
    {
        void Add(Material _modelMaterial);
        void Del(int index);
    }
}
