using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareLib;

namespace WareHouseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WareManager wareManager = new WareManager();
            wareManager.CheckWare();
            Console.ReadKey();
        }
    }
}
