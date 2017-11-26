using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigChar = char.Parse(Console.ReadLine());
            var smallChar1 = char.Parse(Console.ReadLine());
            var smallChar2 = char.Parse(Console.ReadLine());
            var smallChar3 = char.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());

            var count = 0;
            for (char q = 'A'; q <= bigChar; q++)
            {
                for (char w = 'a'; w <= smallChar1; w++)
                {
                    for (char e = 'a'; e <= smallChar2; e++)
                    {
                        for (char r = 'a'; r <= smallChar3; r++)
                        {
                            for (int t = 0; t <= num; t++)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(count - 1);
            }

        }
    }
}
