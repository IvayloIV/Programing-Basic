using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var player = int.Parse(Console.ReadLine());

            var present = 0;
            var sumPrice = 0;
            var adding = 10;
            var brother = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    present++;
                }
                else
                {
                    sumPrice += adding;
                    adding += 10;
                    brother++;
                }
            }

            var totalBalance = sumPrice + present * player - brother;

            if (totalBalance >= price)
            {
                Console.WriteLine($"Yes! {(totalBalance - price):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(price - totalBalance):f2}");
            }
        }
    }
}
