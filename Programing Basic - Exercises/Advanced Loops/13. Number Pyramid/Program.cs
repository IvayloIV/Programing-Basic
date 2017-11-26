using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var number = 0;
            var repeats = 1;
            while (n != number)
            {
                number++;
                for (int i = 1; i < repeats; i++)
                {
                    if (number == n)
                    {
                        break;
                    }
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine(number);
                repeats++;
            }
        }
    }
}
