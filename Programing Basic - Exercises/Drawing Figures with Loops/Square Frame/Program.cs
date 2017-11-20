using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Shape(n);
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("|");
                for (int l = 0; l < n - 2; l++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Shape(n);
        }

        private static void Shape(int n)
        {
            Console.Write("+");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
