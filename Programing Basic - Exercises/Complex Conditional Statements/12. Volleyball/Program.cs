using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var leap = Console.ReadLine();
            var celebrate = double.Parse(Console.ReadLine());
            var weekends = double.Parse(Console.ReadLine());

            var worksDay = 48 - weekends;
            var weedDaysOff = worksDay * 3 / 4;
            var sundayDays = Math.Round(celebrate * 2 / 3, 3);
            var gamesInWeedOff = celebrate * 6.67;

            var allWeeks = weedDaysOff + weekends + sundayDays;
            var current = allWeeks;

            if (leap == "leap")
            {
                allWeeks *= 0.15;
            }

            var allGamesWeek = current + allWeeks;

            if (leap == "normal")
            {
                allGamesWeek /= 2;
            }

            Console.WriteLine($"{Math.Floor(allGamesWeek)}");
        }
    }
}
