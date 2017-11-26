using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var relult = 1;

            for (int i = 2; i <= n; i++)
            {
                relult *= i;
            }
            Console.WriteLine(relult);
        }
    }
}
