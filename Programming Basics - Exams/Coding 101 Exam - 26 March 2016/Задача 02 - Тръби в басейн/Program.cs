using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_02___Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var first = int.Parse(Console.ReadLine());
            var secound = int.Parse(Console.ReadLine());
            var time = double.Parse(Console.ReadLine());

            var first1 = first * time;
            var secound1 = secound * time;
            var all = first1 + secound1;

            if (all > v)
            {
                Console.WriteLine($"For {time} hours the pool overflows with {(all - v):f1} liters.");
            }
            else
            {
                Console.WriteLine($"The pool is {(int)(all / (v / 100D))}% full. Pipe 1: {(int)(first1 / (all / 100D))}%. Pipe 2: {(int)(secound1 / (all / 100D))}%.");
            }
        }
    }
}
