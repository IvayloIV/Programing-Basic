using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            var weight = int.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var priceLit = double.Parse(Console.ReadLine());
            var kg = double.Parse(Console.ReadLine());

            var lenghtMech = 2 * lenght + 2 * weight;
            var priceMech = lenghtMech * priceLit;
            var sizeMech = lenghtMech * height;
            var kgMech = sizeMech * kg;
            Console.WriteLine($"{lenghtMech}");
            Console.WriteLine($"{priceMech:f2}");
            Console.WriteLine($"{kgMech:f3}");
        }
    }
}
