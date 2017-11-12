using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs((x2 - x1) * (y2 - y1)));
            Console.WriteLine(Math.Abs((x2 - x1)) * 2 + Math.Abs((y2 - y1)) * 2);
        }
    }
}
