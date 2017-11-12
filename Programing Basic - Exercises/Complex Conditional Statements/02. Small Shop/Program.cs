using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var country = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            var price = 0.0;
            if (country == "Sofia")
            {
                if (product == "coffee")
                {
                    price = 0.5;
                }
                else if (product == "water")
                {
                    price = 0.8;
                }
                else if (product == "beer")
                {
                    price = 1.2;
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                }
                else if (product == "peanuts")
                {
                    price = 1.60;
                }
            }
            else if (country == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40;
                }
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.15;
                }
                else if (product == "sweets")
                {
                    price = 1.30;
                }
                else if (product == "peanuts")
                {
                    price = 1.50;
                }
            }
            else if (country == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45;
                }
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.10;
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                }
                else if (product == "peanuts")
                {
                    price = 1.55;
                }
            }
            Console.WriteLine(price * quantity);
        }
    }
}
