using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());

            var count = 0;
            var book = new List<string>();
            for (int i = 1; i <= q; i++)
            {
                for (int o = 1; o <= w; o++)
                {
                    if (e == count)
                    {
                        Console.WriteLine(string.Join(" ", book));
                        return;
                    }
                    book.Add($"({i} <-> {o})");
                    count++;
                }
            }
            Console.WriteLine(string.Join(" ", book));
        }
    }
}
