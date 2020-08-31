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
            ware.manufacturingDate = manufacturingDate; ;
            return ware;
        }

        public void CheckWare()
        {
            Ware w1 = CreateWare("White Milk", 19.50, "milk", new DateTime(2020, 08, 29));
            WareStorage.Add(w1);
            Console.WriteLine(w1.ToString());

            Ware w2 = CreateWare("Cereal Bread", 10.05, "bread", new DateTime(2020, 08, 31));
            WareStorage.Add(w2);
            Console.WriteLine(w2.ToString());

            Ware w3 = CreateWare("Delicious", 10.05, "butter", new DateTime(2020, 08, 10));
            WareStorage.Add(w3);
            Console.WriteLine(w3.ToString());

            Ware w4 = CreateWare("Whole-wheat Bread", 10.05, "bread", new DateTime(2020, 08, 30));
            WareStorage.Add(w4);
            Console.WriteLine(w4.ToString());

            Console.WriteLine($"Free storage volume: {WareStorage.FreePlace}");
        }
    }
}
