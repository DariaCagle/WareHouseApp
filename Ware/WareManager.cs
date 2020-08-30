using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareLib
{
    public class WareManager
    {
        private Ware CreateWare(string name, double price, string baseWare, DateTime manufacturingDate)
        {
            Ware ware = new Ware();
            ware.name = name;
            ware.price = price;
            ware.baseWare = baseWare;
            ware.manufacturingDate = manufacturingDate;;
            return ware;
        }

        public void CheckWare()
        {
            Ware w1 = CreateWare("White Milk", 19.50, "milk", new DateTime(2020, 08, 07));
            Console.WriteLine(w1.ToString());

            Ware w2 = CreateWare("Cereal Bread", 10.05, "bread", new DateTime(2020, 08, 15));
            Console.WriteLine(w2.ToString());
        }
    }
}
