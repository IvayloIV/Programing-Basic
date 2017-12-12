using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02___Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var allGlasses = int.Parse(Console.ReadLine());
            var peoples = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var hours = 8 * peoples * workDays;
            var glasses = hours / 5;

            if (glasses < allGlasses)
            {
                Console.WriteLine($"Losses: {((allGlasses - glasses) * 4.2):f2}");
            }
            else
            {
                Console.WriteLine($"{((glasses - allGlasses) * 4.2):f2} extra money");
            }
        }
    }
}
