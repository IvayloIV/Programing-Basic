using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstDay = double.Parse(Console.ReadLine());

            var allKg = firstDay;
            for (int i = 0; i < n; i++)
            {
                var nextDay = double.Parse(Console.ReadLine());
                firstDay = firstDay + firstDay * (nextDay / 100D);
                allKg += firstDay;
            }

            if (allKg >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(allKg - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - allKg)} more kilometers");
            }
        }
    }
}
