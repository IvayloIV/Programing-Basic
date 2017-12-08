using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var under5 = 0;
            var under12 = 0;
            var under25 = 0;
            var under40 = 0;
            var under41 = 0;

            var all = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                all += num;
                if (num <= 5)
                {
                    under5 += num;
                }
                else if (num > 5 && num <= 12)
                {
                    under12 += num;
                }
                else if (num > 12 && num <= 25)
                {
                    under25 += num;
                }
                else if (num > 25 && num <= 40)
                {
                    under40 += num;
                }
                else if (num > 40)
                {
                    under41 += num;
                }
            }

            Console.WriteLine($"{((double)under5 / all * 100):f2}%");
            Console.WriteLine($"{((double)under12 / all * 100):f2}%");
            Console.WriteLine($"{((double)under25 / all * 100):f2}%");
            Console.WriteLine($"{((double)under40 / all * 100):f2}%");
            Console.WriteLine($"{((double)under41 / all * 100):f2}%");
        }
    }
}
