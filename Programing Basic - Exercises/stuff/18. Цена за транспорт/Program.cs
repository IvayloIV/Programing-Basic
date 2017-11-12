using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Цена_за_транспорт
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var day = Console.ReadLine();

            if (n < 20)
            {
                if (day == "day")
                {
                    Console.WriteLine($"{(0.70 + n * 0.79):f2}");
                }
                else if (day == "night")
                {

                    Console.WriteLine($"{(0.70 + n * 0.90):f2}");
                }
            }
            else if (n >= 100)
            {
                Console.WriteLine($"{(n * 0.06):f2}");
            }
            else if (n >= 20)
            {
                Console.WriteLine($"{(n * 0.09):f2}");
            }
            
        }
    }
}
