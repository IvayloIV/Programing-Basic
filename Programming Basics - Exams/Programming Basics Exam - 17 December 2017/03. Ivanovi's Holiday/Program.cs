using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ivanovi_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var where = Console.ReadLine();
            var transport = Console.ReadLine();

            var price = 0D;
            if (where == "Miami")
            {
                if (days >= 1 && days <= 10)
                {
                    price = days * (2 * 24.99 + 3 * 14.99);
                }
                else if (days >= 11 && days <= 15)
                {
                    price = days * (2 * 22.99 + 3 * 11.99);
                }
                else if (days > 15)
                {
                    price = days * (2 * 20D + 3 * 10D);
                }
            }
            else if (where == "Canary Islands")
            {
                if (days >= 1 && days <= 10)
                {
                    price = days * (2 * 32.50 + 3 * 28.50);
                }
                else if (days >= 11 && days <= 15)
                {
                    price = days * (2 * 30.50 + 3 * 25.60);
                }
                else if (days > 15)
                {
                    price = days * (2 * 28D + 3 * 22D);
                }
            }
            else if (where == "Philippines")
            {
                if (days >= 1 && days <= 10)
                {
                    price = days * (2 * 42.99 + 3 * 39.99);
                }
                else if (days >= 11 && days <= 15)
                {
                    price = days * (2 * 41D + 3 * 36D);
                }
                else if (days > 15)
                {
                    price = days * (2 * 38.50 + 3 * 32.40);
                }
            }
            price = price + price * 0.25;

            var priceTransport = 0D;

            if (transport == "train")
            {
                priceTransport = 2 * 22.30 + 3 * 12.50;
            }
            else if (transport == "bus")
            {
                priceTransport = 2 * 45D + 3 * 37D;
            }
            else if (transport == "airplane")
            {
                priceTransport = 2 * 90D + 3 * 68.50;
            }
            var allPrice = priceTransport + price;
            Console.WriteLine($"{allPrice:f3}");
        }
    }
}
