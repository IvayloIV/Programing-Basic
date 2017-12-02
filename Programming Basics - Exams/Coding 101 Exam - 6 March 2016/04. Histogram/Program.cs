using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var under200 = 0;
            var under400 = 0;
            var under600 = 0;
            var under800 = 0;
            var under1000 = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    under200++;
                }
                else if (num >= 200 && num < 400)
                {
                    under400++;
                }
                else if (num >= 400 && num < 600)
                {
                    under600++;
                }
                else if (num >= 600 && num < 800)
                {
                    under800++;
                }
                else if (num >= 800)
                {
                    under1000++;
                }
            }

            Console.WriteLine($"{(((double)under200 / n) * 100):f2}");
            Console.WriteLine($"{(((double)under400 / n) * 100):f2}");
            Console.WriteLine($"{(((double)under600 / n) * 100):f2}");
            Console.WriteLine($"{(((double)under800 / n) * 100):f2}");
            Console.WriteLine($"{(((double)under1000 / n) * 100):f2}");
        }
    }
}
