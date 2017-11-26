using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("1");
                return;
            }

            var firstNum = 1;
            var secoundNum = 1;

            for (int i = 0; i < n - 1; i++)
            {
                var fNext = firstNum + secoundNum;
                firstNum = secoundNum;
                secoundNum = fNext;
            }
            Console.WriteLine(secoundNum);
        }
    }
}
