using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Парична_награда
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var aware = double.Parse(Console.ReadLine());

            var sum = 0D;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum += (num * 2);
                }
                else
                {
                    sum += num;
                }
            }
            Console.WriteLine($"The project prize was {(sum * aware):f2} lv.");
        }
    }
}
