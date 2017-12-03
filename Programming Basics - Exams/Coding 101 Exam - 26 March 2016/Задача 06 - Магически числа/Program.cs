using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_06___Магически_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new List<string>();

            for (int q = 1; q <= 9; q++)
            {
                for (int w = 1; w <= 9; w++)
                {
                    for (int e = 1; e <= 9; e++)
                    {
                        for (int r = 1; r <= 9; r++)
                        {
                            for (int t = 1; t <= 9; t++)
                            {
                                for (int y = 1; y <= 9; y++)
                                {
                                    if (q * w * e * r * t * y == n)
                                    {
                                        book.Add($"{q}{w}{e}{r}{t}{y}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", book));
        }
    }
}
