using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            var countDancers = int.Parse(Console.ReadLine());
            var countPoints = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var where = Console.ReadLine();

            var money = countDancers * countPoints;

            if (where == "Abroad")
            {
                money += (money * 0.5);
            }

            if (season == "summer")
            {
                if (where == "Bulgaria")
                {
                    money -= (money * 0.05);
                }
                else if (where == "Abroad")
                {
                    money -= (money * 0.1);
                }
            }
            else if (season == "winter")
            {
                if (where == "Bulgaria")
                {
                    money -= (money * 0.08);
                }
                else if (where == "Abroad")
                {
                    money -= (money * 0.15);
                }
            }
            var t = money * 0.75;
            Console.WriteLine($"Charity - {t:f2}");
            money *= 0.25;
            money /= countDancers;
            Console.WriteLine($"Money per dancer - {money:f2}");
        }
    }
}
