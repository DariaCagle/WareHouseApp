using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareLib
{
    public class Ware
    {
        public string name;
        public double price;
        public string baseWare;
        public DateTime manufacturingDate;

        public DateTime ExpirationDate
        {
            get
            {
                switch (baseWare)
                {
                    case "bread":
                        return manufacturingDate.AddDays(3);
                    case "milk":
                        return manufacturingDate.AddDays(10);
                    case "butter":
                        return manufacturingDate.AddDays(30);
                    default:
                        return manufacturingDate;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {name}, price: {price}, expiration date: {ExpirationDate.ToShortDateString()}";
        }

    }
}
