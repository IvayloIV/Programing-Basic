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
            var num = int.Parse(Console.ReadLine());

            var book = new List<string>();
            for (int q = 1; q <= 30; q++)
            {
                for (int w = 1; w <= 30; w++)
                {
                    for (int e = 1; e <= 30; e++)
                    {
                        if (q < w && w < e && q + w + e == num)
                        {
                            book.Add($"{q} + {w} + {e} = {num}");
                        }
                        if (q > w && w > e && q * w * e == num)
                        {
                            book.Add($"{q} * {w} * {e} = {num}");
                        }
                    }
                }
            }
            if (book.Count == 0)
            {
                Console.WriteLine($"No!");
            }
            else
            {
                Console.WriteLine(string.Join("\n", book));
            }
        }
    }
}
