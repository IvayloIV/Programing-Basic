using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var tomatolsKg = double.Parse(Console.ReadLine());
            var countKasetki = int.Parse(Console.ReadLine());
            var countBurkani = int.Parse(Console.ReadLine());

            var allKgLuteniza = tomatolsKg / 5D;
            var burkans = allKgLuteniza / 0.535;
            var kasetki = burkans / countBurkani;
            Console.WriteLine($"Total lutenica: {Math.Floor(allKgLuteniza)} kilograms.");

            if (kasetki > countKasetki)
            {
                var totalKasetki = kasetki - countKasetki;
                Console.WriteLine($"{Math.Floor(totalKasetki)} boxes left.");
                var leftJars = burkans - ((double)countKasetki * countBurkani);
                Console.WriteLine($"{Math.Floor(leftJars)} jars left.");
            }
            else
            {
                var totalKasetki = countKasetki - kasetki;
                Console.WriteLine($"{Math.Floor(totalKasetki)} more boxes needed.");
                var leftJars = ((double)countBurkani * countKasetki) - burkans;
                Console.WriteLine($"{Math.Floor(leftJars)} more jars needed.");
            }
        }
    }
}
