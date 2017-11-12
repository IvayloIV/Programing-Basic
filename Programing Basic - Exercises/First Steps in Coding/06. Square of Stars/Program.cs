using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Квадрат_от_звездички
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FullStars(n);
            Middle(n);          
            FullStars(n);
        }

        private static void Middle(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                for (int k = 0; k < n - 2; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
        }

        private static void FullStars(int n)
        {
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}
