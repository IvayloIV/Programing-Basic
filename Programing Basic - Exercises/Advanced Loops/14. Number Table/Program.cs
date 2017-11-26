using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var numbersCount = 0;
                var maxNum = n;
                for (int k = i; k <= n; k++)
                {
                    numbersCount++;
                    Console.Write(k + " ");
                }


                while (numbersCount != n)
                {
                    maxNum--;
                    Console.Write(maxNum + " ");
                    numbersCount++;
                }
                Console.WriteLine();
            }
        }
    }
}
