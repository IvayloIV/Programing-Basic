using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var even = 0;
            var odd = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    even += int.Parse(Console.ReadLine());
                }
                else
                {
                    odd += int.Parse(Console.ReadLine());
                }
            }

            if (even == odd)
            {
                Console.WriteLine($"Yes, sum = {even}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(odd - even)}");
            }
        }
    }
}
