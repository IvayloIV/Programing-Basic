using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {n}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The number is not even.");
                    }
                }
                catch {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
