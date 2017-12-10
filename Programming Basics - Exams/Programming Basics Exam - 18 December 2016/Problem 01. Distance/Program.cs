using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSpeed = int.Parse(Console.ReadLine());
            var firstHours = double.Parse(Console.ReadLine()) / 60;
            var secoundHours = double.Parse(Console.ReadLine()) / 60;
            var threeHours = double.Parse(Console.ReadLine()) / 60;

            var afterFirst = firstSpeed * firstHours;
            var t = firstSpeed + (firstSpeed * 0.1);
            var afterPower = (firstSpeed + (firstSpeed * 0.1)) * secoundHours;
            var afterSmaller = (t - (t * 0.05)) * threeHours;
            Console.WriteLine($"{(afterFirst + afterPower + afterSmaller):f2}");
        }
    }
}
