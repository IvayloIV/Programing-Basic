using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Снежинка
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var middlestarts = n;
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    Console.Write(new string('.', i));
                    Console.Write("*");
                    Console.Write(new string('.', middlestarts));
                    Console.Write("*");
                    Console.Write(new string('.', middlestarts));
                    Console.Write("*");
                    Console.WriteLine(new string('.', i));
                    middlestarts--;
                }
                else
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('*', 5));
                    Console.WriteLine(new string('.', i));
                }
            }
            Console.WriteLine(new string('*', 2 * n + 3));

            var points2 = n - 1;
            var middlePoints = 2;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', points2));
                    Console.Write(new string('*', 5));
                    Console.WriteLine(new string('.', points2));
                }
                else
                {
                    Console.Write(new string('.', points2));
                    Console.Write("*");
                    Console.Write(new string('.', middlePoints));
                    Console.Write("*");
                    Console.Write(new string('.', middlePoints));
                    Console.Write("*");
                    Console.WriteLine(new string('.', points2));
                    middlePoints++;
                }
                points2--;
            }
        }
    }
}
