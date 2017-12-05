using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var homeDays = n * 127;
            var worksDays = (365 - n) * 63;
            var allDay = homeDays + worksDays;

            if (30000 > allDay)
            {
                var current = 30000 - allDay;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{current / 60} hours and {current % 60} minutes less for play");
            }
            else
            {
                var current = allDay - 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{current / 60} hours and {current % 60} minutes more for play");
            }
        }
    }
}
