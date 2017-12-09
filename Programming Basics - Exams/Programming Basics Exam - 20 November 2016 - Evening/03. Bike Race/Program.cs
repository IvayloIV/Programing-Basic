using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var youngBikers = int.Parse(Console.ReadLine());
            var oldBikers = int.Parse(Console.ReadLine());
            var trais = Console.ReadLine();

            double priceYoung = 0;
            double priceOld = 0;

            if (trais == "trail")
            {
                priceYoung = 5.50;
                priceOld = 7;
            }
            else if (trais == "cross-country")
            {
                if (youngBikers + oldBikers >= 50)
                {
                    priceYoung = 6;
                    priceOld = 9.50 - (9.50 * 0.25);
                }
                else
                {
                    priceYoung = 8;
                    priceOld = 9.50;
                }
            }
            else if (trais == "downhill")
            {
                priceYoung = 12.25;
                priceOld = 13.75;
            }
            else if (trais == "road")
            {
                priceYoung = 20;
                priceOld = 21.50;
            }

            var sum = youngBikers * priceYoung + oldBikers * priceOld;
            var totalSum = sum * 0.95;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
