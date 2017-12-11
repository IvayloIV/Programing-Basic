using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02___Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var peoples = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var allHours = peoples * workDays * 8;

            if (allHours >= neededHours)
            {
                Console.WriteLine($"{allHours - neededHours} hours left");
            }
            else
            {
                var needed = neededHours - allHours;
                Console.WriteLine($"{needed} overtime");
                Console.WriteLine($"Penalties: {needed * workDays}");
            }
        }
    }
}
