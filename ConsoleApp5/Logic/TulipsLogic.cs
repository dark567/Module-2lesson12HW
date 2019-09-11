using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Logic
{
    public class TulipsLogic
    {
        public static Tulips[] GetTulips
        {
            get
            {
                return Tulips._modelTulips.ToArray();
            }
        }

        public static void AddTulips(Tulips _modelTulips)
        {
            Tulips._modelTulips.Add(_modelTulips);
        }
    }
}
