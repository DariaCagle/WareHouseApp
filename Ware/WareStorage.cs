using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareLib
{
    public static class WareStorage
    {
        private const int StorageVolume = 10;

        private static List<Ware> storage = new List<Ware>();


        public static void Add(Ware s)
        {
            storage.Add(s);
        }

        public static int Count()
        {
            return storage.Count();
        }

        public static Ware[] GetWares()
        {
            return storage.ToArray();
        }

        public static int FreePlace
        {
            get
            {
                return StorageVolume - Count(); 
                
            }
        }
    }
}
