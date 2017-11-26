using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Сбор_или_Произведение
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var isHere = false;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == n && a < b && b < c)
                        {
                            isHere = true;
                            Console.WriteLine($"{a} + {b} + {c} = {n}");
                        }
                        else if (a * b * c == n && a > b && b > c)
                        {
                            isHere = true;
                            Console.WriteLine($"{a} * {b} * {c} = {n}");
                        }
                    }
                }
            }

            if (!isHere)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
