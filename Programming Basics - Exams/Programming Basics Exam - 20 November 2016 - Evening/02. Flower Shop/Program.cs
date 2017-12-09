using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolii = int.Parse(Console.ReadLine());
            var zumzuli = int.Parse(Console.ReadLine());
            var roze = int.Parse(Console.ReadLine());
            var cactus = int.Parse(Console.ReadLine());
            var pricePresent = double.Parse(Console.ReadLine());

            var sum = magnolii * 3.25 + zumzuli * 4 + roze * 3.5 + cactus * 8;
            var dds = sum * 0.05;
            var allSum = sum - dds;

            if (pricePresent > allSum)
            {
                var summ = Math.Ceiling(pricePresent - allSum);
                Console.WriteLine($"She will have to borrow {summ} leva.");
            }
            else
            {
                var summ = Math.Floor(allSum - pricePresent);
                Console.WriteLine($"She is left with {summ} leva.");
            }
        }
    }
}
