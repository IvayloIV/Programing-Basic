using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01___Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var twoSides = a * (a / 2) * 2;
            var sqare = (a / 2) * (a / 2);
            var triangle = ((a / 2) * (b - (a / 2))) / 2;
            var backSide = sqare + triangle;
            var on = (a / 5) * (a / 5);
            var frontSide = backSide - on;
            var allWalls = twoSides + backSide + frontSide;
            var green = allWalls / 3;
            var flo = a * (a / 2) * 2;
            var red = flo / 5;
            Console.WriteLine($"{green:f2}");
            Console.WriteLine($"{red:f2}");
        }
    }
}
