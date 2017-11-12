using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(a * 1.8 + 32, 2));
        }
    }
}
