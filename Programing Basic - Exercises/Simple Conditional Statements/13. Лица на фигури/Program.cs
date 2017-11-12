using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Лица_на_фигури
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var n = double.Parse(Console.ReadLine());
                Console.WriteLine(n * n);
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine(a * h);
            }
            else if (figure == "circle")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a * Math.PI);
            }
            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine((a * b) / 2);
            }
        }
    }
}
