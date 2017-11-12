using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Време___15_минути
{
    class Program
    {
        static void Main(string[] args)
        {
            var minutes = int.Parse(Console.ReadLine());
            var secound = int.Parse(Console.ReadLine());

            var current = minutes * 60;

            var all = current + secound + 15;

            var seconds123 = all % 60;
            var minutes123 = (all / 60) % 60;
            if (minutes123 >= 24)
            {
                minutes123 -= 24;
            }
            

            Console.WriteLine($"{minutes123}:{seconds123:d2}");
        }
    }
}
