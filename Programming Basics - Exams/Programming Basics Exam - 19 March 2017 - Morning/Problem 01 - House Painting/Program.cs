using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01___House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var walls = x * y;
            var windowSize = 2.25;
            var twhoWalls = 2 * walls - 2 * windowSize;
            var backDoor = x * x;
            var enter = 2.4;
            var frondAndBack = 2 * backDoor - enter;
            var allSize = twhoWalls + frondAndBack;
            var red = allSize / 3.4;
            Console.WriteLine($"{red:f2}");
            var sqareFlow = 2 * (x * y);
            var twoTringle = 2 * (x * h / 2);
            var allSize2 = sqareFlow + twoTringle;
            Console.WriteLine($"{(allSize2 / 4.3):f2}");
        }
    }
}
