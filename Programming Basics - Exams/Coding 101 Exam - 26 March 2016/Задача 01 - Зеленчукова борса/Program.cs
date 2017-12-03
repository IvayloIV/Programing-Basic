using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01___Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetable = double.Parse(Console.ReadLine());
            var fruits = double.Parse(Console.ReadLine());
            var kgVegetable = int.Parse(Console.ReadLine());
            var kgFruits = int.Parse(Console.ReadLine());

            var priceVegetable = vegetable * kgVegetable;
            var priceFruits = fruits * kgFruits;
            Console.WriteLine($"{(priceVegetable + priceFruits) / 1.94}");
        }
    }
}
