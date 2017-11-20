using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Шевица
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = (3 * n - 1) / 2;

            Console.Write(new string('.', points));
            Console.Write("x");
            Console.WriteLine(new string('.', points));

            Console.Write(new string('.', points - 1));
            Console.Write("/x\\");
            Console.WriteLine(new string('.', points - 1));

            Console.Write(new string('.', points - 1));
            Console.Write("x|x");
            Console.WriteLine(new string('.', points - 1));

            var starts2 = n;
            var average = (int)Math.Ceiling((double)n / 2);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', ((3 * n) - (starts2 * 2) - 1) / 2));
                Console.Write(new string('x', starts2));
                Console.Write("|");
                Console.Write(new string('x', starts2));
                Console.WriteLine(new string('.', ((3 * n) - (starts2 * 2) - 1) / 2));

                if (i < average)
                {
                    starts2++;
                }
                else
                {
                    starts2--;
                }
            }

            var points3 = (3 * n - 3) / 2;
            Console.Write(new string('.', points3));
            Console.Write("/x\\");
            Console.WriteLine(new string('.', points3));

            Console.Write(new string('.', points3));
            Console.Write("\\x/");
            Console.WriteLine(new string('.', points3));

            starts2 = n;
            average = (int)Math.Ceiling((double)n / 2);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', ((3 * n) - (starts2 * 2) - 1) / 2));
                Console.Write(new string('x', starts2));
                Console.Write("|");
                Console.Write(new string('x', starts2));
                Console.WriteLine(new string('.', ((3 * n) - (starts2 * 2) - 1) / 2));

                if (i < average)
                {
                    starts2++;
                }
                else
                {
                    starts2--;
                }
            }

            Console.Write(new string('.', points - 1));
            Console.Write("x|x");
            Console.WriteLine(new string('.', points - 1));

            Console.Write(new string('.', points - 1));
            Console.Write("\\x/");
            Console.WriteLine(new string('.', points - 1));

            Console.Write(new string('.', points));
            Console.Write("x");
            Console.WriteLine(new string('.', points));
        }
    }
}
