using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double under3 = 0;
            double under11 = 0;
            double hupe12 = 0;
            double allTones = 0;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                allTones += num;
                if (num <= 3)
                {
                    under3 += num;
                }
                else if (num >= 4 && num <= 11)
                {
                    under11 += num;
                }
                else if (num >= 12)
                {
                    hupe12 += num;
                }
            }

            var averageTons = (double)(under3 * 200 + under11 * 175 + hupe12 * 120) / allTones;
            var withBus = (double)under3 / allTones * 100D;
            var withKam = (double)under11 / allTones * 100D;
            var withTrain = (double)hupe12 / allTones * 100D;
            Console.WriteLine($"{averageTons:f2}");
            Console.WriteLine($"{withBus:f2}%");
            Console.WriteLine($"{withKam:f2}%");
            Console.WriteLine($"{withTrain:f2}%");
        }
    }
}
