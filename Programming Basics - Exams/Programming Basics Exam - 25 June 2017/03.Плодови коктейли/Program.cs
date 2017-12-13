using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Плодови_коктейли
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var size = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var price = 0D;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    price = count * 2D * 56D;
                }
                else if (size == "big")
                {
                    price = count * 5D * 28.70;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    price = count * 2D * 36.66;
                }
                else if (size == "big")
                {
                    price = count * 5D * 19.60;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price = count * 2D * 42.10;
                }
                else if (size == "big")
                {
                    price = count * 5D * 24.80;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    price = count * 2D * 20D;
                }
                else if (size == "big")
                {
                    price = count * 5D * 15.20;
                }
            }

            if (price > 1000)
            {
                price *= 0.5;
            }
            else if (price > 399)
            {
                price *= 0.85;
            }
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
