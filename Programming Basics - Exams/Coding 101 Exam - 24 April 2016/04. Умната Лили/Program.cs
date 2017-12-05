using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());
            var peralnq = double.Parse(Console.ReadLine());
            var gamePrice = int.Parse(Console.ReadLine());

            var brother = 0;
            var gameCount = 0;
            var allmoney = 0;
            var moneyAdd = 10;
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 1)
                {
                    gameCount++;
                }
                else
                {
                    brother++;
                    allmoney += moneyAdd;
                    moneyAdd += 10;
                }
            }

            var sellGames = gameCount * gamePrice;
            var allSum = allmoney + sellGames - brother;

            if (allSum >= peralnq)
            {
                var p = allSum - peralnq;
                Console.WriteLine($"Yes! {p:f2}");
            }
            else
            {
                var t = peralnq - allSum;
                Console.WriteLine($"No! {t:f2}");
            }
        }
    }
}
