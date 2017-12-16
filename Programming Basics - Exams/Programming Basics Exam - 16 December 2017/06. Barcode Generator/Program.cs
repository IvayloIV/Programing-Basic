using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = Console.ReadLine();
            var end = Console.ReadLine();

            var book = new List<string>();
            for (int q = int.Parse(start[0].ToString()); q <= int.Parse(end[0].ToString()); q++)
            {
                for (int w = int.Parse(start[1].ToString()); w <= int.Parse(end[1].ToString()); w++)
                {
                    for (int e = int.Parse(start[2].ToString()); e <= int.Parse(end[2].ToString()); e++)
                    {
                        for (int r = int.Parse(start[3].ToString()); r <= int.Parse(end[3].ToString()); r++)
                        {
                            if (q % 2 == 1 && w % 2 == 1 && e % 2 == 1 && r % 2 == 1)
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
