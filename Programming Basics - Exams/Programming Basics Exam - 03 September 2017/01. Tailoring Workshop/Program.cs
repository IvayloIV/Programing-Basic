using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqarleTable = int.Parse(Console.ReadLine());
            var lenghtOgSqarleTable = double.Parse(Console.ReadLine());
            var wenghtTable = double.Parse(Console.ReadLine());

            var allSizeFlot = sqarleTable * (lenghtOgSqarleTable + 0.60) * (wenghtTable + 0.60);
            var allSizeKareta = sqarleTable * (lenghtOgSqarleTable / 2) * (lenghtOgSqarleTable / 2);
            var priceDolards = allSizeFlot * 7 + allSizeKareta * 9;
            Console.WriteLine($"{priceDolards:f2} USD");
            var priceLv = priceDolards * 1.85;
            Console.WriteLine($"{priceLv:f2} BGN");
        }
    }
}
