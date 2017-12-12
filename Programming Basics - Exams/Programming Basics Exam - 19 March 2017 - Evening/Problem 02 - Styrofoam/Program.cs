using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02___Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMoney = double.Parse(Console.ReadLine());
            var sizeHouse = double.Parse(Console.ReadLine());
            var windowsCount = int.Parse(Console.ReadLine());
            var stiriopol = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var sizeHouseWhidoutJams = sizeHouse - windowsCount * 2.4;
            var sizeHouseJams = sizeHouseWhidoutJams + (sizeHouseWhidoutJams * 0.1);
            var needPacks = Math.Ceiling(sizeHouseJams / stiriopol) * price;

            if (needPacks <= allMoney)
            {
                Console.WriteLine($"Spent: {needPacks:f2}");
                Console.WriteLine($"Left: {(allMoney - needPacks):f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {(needPacks - allMoney):f2}");
            }
        }
    }
}
