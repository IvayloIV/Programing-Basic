using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceSkumriq = double.Parse(Console.ReadLine());
            var priceCaca = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrit = double.Parse(Console.ReadLine());
            var kgMidi = double.Parse(Console.ReadLine());

            var pricePalad = priceSkumriq + (priceSkumriq * 0.6);
            var allPalad = kgPalamud * pricePalad;

            var priceSafr = priceCaca + (priceCaca * 0.8);
            var allSafr = kgSafrit * priceSafr;

            var allMidi = kgMidi * 7.50;
            var all = allPalad + allMidi + allSafr;
            Console.WriteLine($"{all:f2}");
        }
    }
}
