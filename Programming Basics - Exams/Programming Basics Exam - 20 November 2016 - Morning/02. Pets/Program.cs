using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var dog = double.Parse(Console.ReadLine());
            var cat = double.Parse(Console.ReadLine());
            var turtle = double.Parse(Console.ReadLine()) / 1000;

            var foodDog = days * dog;
            var foodCat = days * cat;
            var foodTurtle = days * turtle;
            var allNeededFood = foodDog + foodCat + foodTurtle;

            if (allNeededFood <= food)
            {
                var p = Math.Floor(food - allNeededFood);
                Console.WriteLine($"{p} kilos of food left.");
            }
            else
            {
                var t = Math.Ceiling(allNeededFood - food);
                Console.WriteLine($"{t} more kilos of food are needed.");
            }
        }
    }
}
