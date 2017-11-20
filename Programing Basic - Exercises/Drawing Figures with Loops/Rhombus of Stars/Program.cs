using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var tup = n - 1;
            var stars = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', tup));

                for (int t = 1; t <= stars; t++)
                {
                    if (t % 2 == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                stars += 2;
                tup--;
            }

            stars -= 4;
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string(' ', i));
                for (int k = 1; k <= stars; k++)
                {
                    if (k % 2 == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                stars -= 2;
            }
        }
    }
}
