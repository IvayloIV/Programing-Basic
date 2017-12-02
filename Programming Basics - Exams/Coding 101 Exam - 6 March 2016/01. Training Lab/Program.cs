using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine()) * 100;
            var h = double.Parse(Console.ReadLine()) * 100 - 100;

            var bur = (int)h / 70;
            var rows = (int)w / 120;
            Console.WriteLine(bur * rows - 3);
        }
    }
}
