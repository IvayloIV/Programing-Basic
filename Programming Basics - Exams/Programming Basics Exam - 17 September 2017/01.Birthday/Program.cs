using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            var weight = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var prozent = double.Parse(Console.ReadLine()) * 0.01;

            var v = lenght * weight * height;
            var allLitres = v * 0.001;
            var realLitres = allLitres * (1 - prozent);
            Console.WriteLine($"{realLitres:f3}");
        }
    }
}
