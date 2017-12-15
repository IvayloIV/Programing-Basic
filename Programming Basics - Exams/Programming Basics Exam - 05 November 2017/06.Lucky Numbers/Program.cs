using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var book = new List<string>();
            for (int q = 1; q <= 9; q++)
            {
                for (int w = 1; w <= 9; w++)
                {
                    for (int e = 1; e <= 9; e++)
                    {
                        for (int r = 1; r <= 9; r++)
                        {
                            if (q + w == e + r && num % (q + w) == 0)
                            {
                                book.Add($"{q}{w}{e}{r}");
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", book));
        }
    }
}
