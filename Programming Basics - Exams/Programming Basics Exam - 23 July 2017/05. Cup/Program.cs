using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var upperPoints = n;
            var upperHash = n * 3;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', upperPoints));
                Console.Write(new string('#', upperHash));
                Console.WriteLine(new string('.', upperPoints));
                upperPoints++;
                upperHash -= 2;
            }

            var middlePoints = n * 2 - 2;
            for (int i = 0; i < n / 2 + 2; i++)
            {
                if (i == n / 2 + 1)
                {
                    upperPoints--;
                }
                Console.Write(new string('.', upperPoints));
                Console.Write('#');
                if (i != n / 2 + 1)
                {
                    Console.Write(new string('.', middlePoints));
                    middlePoints -= 2;
                }
                else
                {
                    middlePoints += 2;
                    Console.Write(new string('#', middlePoints));
                }
                Console.Write('#');
                Console.WriteLine(new string('.', upperPoints));
                upperPoints++;
            }

            for (int i = 1; i <= n + 2; i++)
            {
                if (i == n / 2 + 1)
                {
                    Console.Write(new string('.', ((5 * n) - 10) / 2));
                    Console.Write("D^A^N^C^E^");
                    Console.WriteLine(new string('.', ((5 * n) - 10) / 2));
                }
                else
                {
                    Console.Write(new string('.', n * 2 - 2));
                    Console.Write(new string('#', n + 4));
                    Console.WriteLine(new string('.', n * 2 - 2));
                }
            }
        }
    }
}
