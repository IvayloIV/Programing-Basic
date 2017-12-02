using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var book = new List<string>();

            for (int q = 1; q < n; q++)
            {
                for (int w = 1; w < n; w++)
                {
                    for (int e = 1; e <= h; e++)
                    {
                        for (int r = 1; r <= h; r++)
                        {
                            for (int t = Math.Max(q, w) + 1; t <= n; t++)
                            {
                                book.Add(($"{q}{w}{(char)(e + 96)}{(char)(r + 96)}{t}"));
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", book));
        }
    }
}
