using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitkoin = double.Parse(Console.ReadLine());
            var iona = double.Parse(Console.ReadLine());
            var komm = double.Parse(Console.ReadLine()) / 100;

            var totalBitkoin = bitkoin * 1168;
            var totalIona = iona * 0.15;
            var totalLv = totalIona * 1.76;

            var allLv = (totalBitkoin + totalLv) / 1.95;
            var komisionna = komm * allLv;
            var result = allLv - komisionna;
            Console.WriteLine($"{result:f2}");
        }
    }
}
