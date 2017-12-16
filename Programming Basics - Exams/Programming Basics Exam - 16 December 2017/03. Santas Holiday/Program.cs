using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            var allDays = int.Parse(Console.ReadLine());
            var where = Console.ReadLine();
            var exep = Console.ReadLine();

            var price = 0D;
            if (where == "room for one person")
            {
                price = 18;
            }
            else if (where == "apartment")
            {
                price = 25;
            }
            else if (where == "president apartment")
            {
                price = 35;
            }

            price *= (allDays - 1);

            if (allDays < 10)
            {
                if (where == "apartment")
                {
                    price = price - (price * 0.30);
                }
                else if (where == "president apartment")
                {
                    price = price - (price * 0.10);
                }
            }
            else if (allDays >= 10 && allDays <= 15)
            {
                if (where == "apartment")
                {
                    price = price - (price * 0.35);
                }
                else if (where == "president apartment")
                {
                    price = price - (price * 0.15);
                }
            }
            else if (allDays > 15)
            {
                if (where == "apartment")
                {
                    price = price - (price * 0.50);
                }
                else if (where == "president apartment")
                {
                    price = price - (price * 0.20);
                }
            }

            if (exep == "positive")
            {
                price = price + (price * 0.25);
            }
            else if (exep == "negative")
            {
                price = price - (price * 0.10);
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
