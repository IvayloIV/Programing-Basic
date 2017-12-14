using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countDancers = int.Parse(Console.ReadLine());

            var energyLost = 0D;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (i % 2 == 1 && num % 2 == 1)
                {
                    energyLost += (countDancers * 30);
                }
                else if (i % 2 == 0 && num % 2 == 0)
                {
                    energyLost += (countDancers * 68);
                }
                else if (i % 2 == 1 && num % 2 == 0)
                {
                    energyLost += (countDancers * 49);
                }
                else if (i % 2 == 0 && num % 2 == 1)
                {
                    energyLost += (countDancers * 65);
                }
            }
            var allEnergy = 100 * n * countDancers;
            var unlossedEnergy = allEnergy - energyLost;
            var unLossedEnergyPerDay = unlossedEnergy / n / countDancers;
            if (unLossedEnergyPerDay <= 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {unLossedEnergyPerDay:f2}");
            }
            else
            {
                Console.WriteLine($"They feel good! Energy left: {unLossedEnergyPerDay:f2}");
            }

        }
    }
}
