using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            var allDays = int.Parse(Console.ReadLine());

            var allLiters = 0D;
            var allSum = 0D;
            for (int i = 0; i < allDays; i++)
            {
                var kolRakia = double.Parse(Console.ReadLine());
                var degree = double.Parse(Console.ReadLine());
                allLiters += kolRakia;
                allSum += (kolRakia * degree);
            }
            var sumDegree = allSum / allLiters;

            Console.WriteLine($"Liter: {allLiters:f2}");
            Console.WriteLine($"Degrees: {sumDegree:f2}");

            if (sumDegree < 38)
            {
                Console.WriteLine($"Not good, you should baking!");
            }
            else if (sumDegree >= 38 && sumDegree <= 42)
            {
                Console.WriteLine($"Super!");
            }
            else if (sumDegree > 42)
            {
                Console.WriteLine($"Dilution with distilled water!");
            }
        }
    }
}
