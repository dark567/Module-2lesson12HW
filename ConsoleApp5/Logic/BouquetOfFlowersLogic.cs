using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Logic
{
    class BouquetOfFlowersLogic
    {
        public static BouquetOfFlowers[] GetBouquetOfFlowers
        {
            get
            {
                return BouquetOfFlowers._bouquetOfFlowers.ToArray();
            }
        }

        public static void AddBouquetOfFlowers(BouquetOfFlowers _modelBouquetOfFlowers)
        {
            BouquetOfFlowers._bouquetOfFlowers.Add(_modelBouquetOfFlowers);
        }
    }
}
