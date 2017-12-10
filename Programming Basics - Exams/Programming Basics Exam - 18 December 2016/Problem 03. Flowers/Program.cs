using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var harizantemi = int.Parse(Console.ReadLine());
            var roze = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var day = Console.ReadLine();

            var priceHaraz = 0D;
            var priceRose = 0D;
            var priceLaleta = 0D;

            if (season == "Spring" || season == "Summer")
            {
                priceHaraz = 2;
                priceRose = 4.10;
                priceLaleta = 2.5;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceHaraz = 3.75;
                priceRose = 4.50;
                priceLaleta = 4.15;
            }

            var sumBok = priceHaraz * harizantemi + priceRose * roze + priceLaleta * laleta;

            if (day == "Y")
            {
                sumBok = sumBok + sumBok * 0.15; 
            }

            if (laleta > 7 && season == "Spring")
            {
                sumBok = sumBok - sumBok * 0.05;
            }

            if (roze >= 10 && season == "Winter")
            {
                sumBok = sumBok - sumBok * 0.1;
            }

            if (harizantemi + roze + laleta > 20)
            {
                sumBok = sumBok - sumBok * 0.2;
            }
            sumBok += 2;
            Console.WriteLine($"{sumBok:f2}");
        }
    }
}
