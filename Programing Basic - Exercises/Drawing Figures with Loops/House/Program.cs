using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var unterTipe = (int)Math.Ceiling((double)n / 2) - 1;

            for (int i = 1; i <= (int)Math.Ceiling((double)n / 2); i++)
            {
                Console.Write(new string('-', unterTipe));
                Console.Write(new string('*', n - unterTipe * 2));
                Console.WriteLine(new string('-', unterTipe));
                unterTipe--;
            }

            var endFigure = Math.Floor((double)n / 2);

            for (int i = 0; i < endFigure; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }

        }
    }
}
