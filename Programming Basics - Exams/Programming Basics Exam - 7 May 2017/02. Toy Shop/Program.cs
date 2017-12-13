using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumTrip = double.Parse(Console.ReadLine());
            var countPuzel = int.Parse(Console.ReadLine());
            var countBarby = int.Parse(Console.ReadLine());
            var countBeer = int.Parse(Console.ReadLine());
            var countMinior = int.Parse(Console.ReadLine());
            var countBusses = int.Parse(Console.ReadLine());

            var allSum = countPuzel * 2.60 + countBarby * 3D + countBeer * 4.1 + countMinior * 8.20 + countBusses * 2D;

            if (countPuzel + countBarby + countBeer + countMinior + countBusses >= 50)
            {
                allSum *= 0.75;
            }
            allSum *= 0.90;
            if (allSum >= sumTrip)
            {
                Console.WriteLine($"Yes! {(allSum - sumTrip):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(sumTrip - allSum):f2} lv needed.");
            }
        }
    }
}
