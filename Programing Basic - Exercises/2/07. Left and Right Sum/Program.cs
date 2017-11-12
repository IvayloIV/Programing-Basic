using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftPart = 0;
            for (int i = 0; i < n; i++)
            {
                leftPart += int.Parse(Console.ReadLine());
            }

            var rightPart = 0;
            for (int i = 0; i < n; i++)
            {
                rightPart += int.Parse(Console.ReadLine());
            }

            if (leftPart == rightPart)
            {
                Console.WriteLine($"Yes, sum = {leftPart}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftPart - rightPart)}");
            }
        }
    }
}
