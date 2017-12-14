using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var aCm = double.Parse(Console.ReadLine()) * 100;

            var sizeArea = (lenght * 100) * (width * 100);
            var sizeWardrobe = aCm * aCm;
            var sizePeika = sizeArea / 10;
            var freeSize = sizeArea - sizePeika - sizeWardrobe;

            Console.WriteLine($"{Math.Floor(freeSize / (40 + 7000))}");

        }
    }
}
