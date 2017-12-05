using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());

            var allSquare = n * n;
            var squarePeika = m * o;
            var pokriv = allSquare - squarePeika;
            var plashPlosh = w * l;
            var needPlosht = pokriv / plashPlosh;
            var p = needPlosht * 0.2;
            Console.WriteLine($"{needPlosht:f2}");
            Console.WriteLine($"{p:f2}");

        }
    }
}
