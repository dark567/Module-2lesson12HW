using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Logic
{
    public class RosesLogic
    {
        public static Roses[] GetRoses
        {
            get
            {
                return Roses._modelRoses.ToArray();
            }
        }

        public static void AddRoses(Roses _modelRoses)
        {
            Roses._modelRoses.Add(_modelRoses);
        }
    }
}
