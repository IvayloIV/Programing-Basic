using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var allTiles = double.Parse(Console.ReadLine());
            var wigthBack = double.Parse(Console.ReadLine());
            var lengthBack = double.Parse(Console.ReadLine());
            var siteTriangle = double.Parse(Console.ReadLine());
            var hightTriangle = double.Parse(Console.ReadLine());
            var priceOneBack = double.Parse(Console.ReadLine());
            var maistor = double.Parse(Console.ReadLine());

            var sizeBack = wigthBack * lengthBack;
            var sicePloch = siteTriangle * hightTriangle / 2;
            var needesPlock = Math.Ceiling(sizeBack / sicePloch) + 5;
            var sum = needesPlock * priceOneBack + maistor;

            if (sum <= allTiles)
            {
                Console.WriteLine($"{(allTiles - sum):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(sum - allTiles):f2} lv more.");
            }
        }
    }
}
