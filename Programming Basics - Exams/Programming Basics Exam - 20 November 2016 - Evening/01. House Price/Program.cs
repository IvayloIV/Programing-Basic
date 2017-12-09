using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var theSmallestRoom = double.Parse(Console.ReadLine());
            var kitchenSize = double.Parse(Console.ReadLine());
            var kvM = double.Parse(Console.ReadLine());

            var twoRoom = theSmallestRoom + (theSmallestRoom * 0.1);
            var threeRoom = twoRoom + (twoRoom * 0.1);
            var bathroom = (double)theSmallestRoom / 2;
            var allSize = theSmallestRoom + kitchenSize + twoRoom + threeRoom + bathroom;
            var allSizeWithkot = allSize + (allSize * 0.05);
            var price = allSizeWithkot * kvM;
            Console.WriteLine($"{price:f2}");
        }
    }
}
