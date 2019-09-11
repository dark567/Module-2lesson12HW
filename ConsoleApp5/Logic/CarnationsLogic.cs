using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Logic
{
    public class CarnationsLogic
    {
        public static Carnations[] GetCarnations
        {
            get
            {
                return Carnations._modelCarnations.ToArray();
            }
        }

        public static void AddCarnations(Carnations _modelCarnations)
        {
            Carnations._modelCarnations.Add(_modelCarnations);
        }
    }
}
