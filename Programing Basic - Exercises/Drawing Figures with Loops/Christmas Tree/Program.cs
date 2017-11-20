using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var whitespase = n;
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(new string(' ', whitespase));

                for (int l = 1; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int l = 1; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                whitespase--;
            }
        }
    }
}
