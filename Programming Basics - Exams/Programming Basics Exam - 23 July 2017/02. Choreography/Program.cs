using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            var countSteeps = int.Parse(Console.ReadLine());
            var countPeoples = int.Parse(Console.ReadLine());
            var daysForStyding = int.Parse(Console.ReadLine());

            var steepsForDay = Math.Ceiling(((double)countSteeps / daysForStyding) / countSteeps * 100);
            var allDancers = steepsForDay / countPeoples;

            if (steepsForDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {allDancers:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {allDancers:f2}% steps to be learned per day.");
            }
        }
    }
}
