using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBrother = double.Parse(Console.ReadLine());
            var secoundBrother = double.Parse(Console.ReadLine());
            var threeBrother = double.Parse(Console.ReadLine());
            var father = double.Parse(Console.ReadLine());

            var allTime = 1 / (1 / firstBrother + 1 / secoundBrother + 1 / threeBrother);
            var timeForBreak = allTime + allTime * 0.15;

            Console.WriteLine($"Cleaning time: {timeForBreak:f2}");
            if (timeForBreak < father)
            {             
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(father - timeForBreak)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(timeForBreak - father)} hours.");
            }
        }
    }
}
