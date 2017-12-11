using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05___SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var poitsUpper = (12 * n - 6) / 2;
            var hastags = 1;
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(new string('.', poitsUpper));
                Console.Write(new string('#', hastags));
                Console.WriteLine(new string('.', poitsUpper));
                hastags += 6;
                poitsUpper -= 3;
            }

            var leftPoints = 2;
            var rightPoint = 3;
            var count = 1;
            for (int i = 1; i <= n * 2 - 2; i++)
            {
                if (i == n * 2 - 2)
                {
                    Console.Write('@');
                }
                else
                {
                    Console.Write('|');
                }
                Console.Write(new string('.', leftPoints));
                Console.Write(new string('#', (12 * n - 5) - 1 - leftPoints - rightPoint));
                Console.WriteLine(new string('.', rightPoint));
                if (count <= n - 2)
                {
                    leftPoints += 3;
                    rightPoint += 3;
                }
                count++;
            }
        }
    }
}
