using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4___Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var doctors = 7;
            var pregledani = 0;
            var nepregledani = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    if (nepregledani > pregledani)
                    {
                        doctors++;
                    }
                }
                var p = int.Parse(Console.ReadLine());

                var currentSituation = p - doctors;

                if (currentSituation > 0)
                {
                    nepregledani += currentSituation;
                }

                if (doctors <= p)
                {
                    pregledani += doctors;
                }
                else
                {
                    pregledani += p;
                }
            }
            Console.WriteLine($"Treated patients: {pregledani}.");
            Console.WriteLine($"Untreated patients: {nepregledani}.");
        }
    }
}
