using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Dwarf_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var allMoney = int.Parse(Console.ReadLine());

            var price = 0D;
            for (int i = 0; i < n; i++)
            {
                var product = Console.ReadLine();

                if (product == "sand clock")
                {
                    price += 2.20;
                }
                else if (product == "magnet")
                {
                    price += 1.50;
                }
                else if (product == "cup")
                {
                    price += 5;
                }
                else if (product == "t-shirt")
                {
                    price += 10;
                }
            }
            if (price <= allMoney)
            {
                Console.WriteLine($"Santa Claus has {(allMoney - price):f2} more leva left!");
            }
            else
            {
                Console.WriteLine($"Santa Claus will need {(price - allMoney):f2} more leva.");
            }
        }
    }
}
