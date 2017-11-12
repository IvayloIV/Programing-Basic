using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = Console.ReadLine();
            double b1 = Dolars(b);
            var c = Console.ReadLine();
            double c1 = Dolars(c);

            Console.WriteLine(Math.Round(a * b1 / c1, 2));
        }

        private static double Dolars(string b)
        {
            switch (b)
            {
                case "BGN":
                    return 1;                  
                case "USD":
                    return 1.79549;
                case "EUR":
                    return 1.95583;
                case "GBP":
                    return 2.53405;
                default:
                    return 0;
            }
        }
    }
}
