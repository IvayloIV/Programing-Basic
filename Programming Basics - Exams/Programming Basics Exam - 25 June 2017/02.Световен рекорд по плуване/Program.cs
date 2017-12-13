using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Световен_рекорд_по_плуване
{
    class Program
    {
        static void Main(string[] args)
        {
            var recordSec = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var timeInSec = double.Parse(Console.ReadLine());

            var needSwim = m * timeInSec;
            var r = Math.Floor(m / 15) * 12.5;
            var fullTime = needSwim + r;

            if (fullTime >= recordSec)
            {
                Console.WriteLine($"No, he failed! He was {(fullTime - recordSec):f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {(fullTime):f2} seconds.");
            }
        }
    }
}
