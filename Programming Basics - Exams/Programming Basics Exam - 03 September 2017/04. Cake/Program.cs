using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = int.Parse(Console.ReadLine());
            var lenght = int.Parse(Console.ReadLine());

            var allSize = weight * lenght;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                var intInput = int.Parse(input);
                allSize -= intInput;
                if (allSize < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(allSize)} pieces more.");
                    return;
                }
            }
            Console.WriteLine($"{allSize} pieces are left.");
        }
    }
}
