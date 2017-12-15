using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeDog = Console.ReadLine();
            var typeDog = Console.ReadLine();
            var addedInternet = Console.ReadLine();
            var money = int.Parse(Console.ReadLine());

            var price = 0D;
            if (typeDog == "Small")
            {
                if (timeDog == "one")
                {
                    price = 9.98;
                }
                else if (timeDog == "two")
                {
                    price = 8.58;
                }
            }
            else if (typeDog == "Middle")
            {
                if (timeDog == "one")
                {
                    price = 18.99;
                }
                else if (timeDog == "two")
                {
                    price = 17.09;
                }
            }
            else if (typeDog == "Large")
            {
                if (timeDog == "one")
                {
                    price = 25.98;
                }
                else if (timeDog == "two")
                {
                    price = 23.59;
                }
            }
            else if (typeDog == "ExtraLarge")
            {
                if (timeDog == "one")
                {
                    price = 35.99;
                }
                else if (timeDog == "two")
                {
                    price = 31.79;
                }
            }

            if (addedInternet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.50;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }
            }

            if (timeDog == "two")
            {
                price *= 0.9625;
            }

            var allSum = price * money;
            Console.WriteLine($"{allSum:f2} lv.");
        }
    }
}
