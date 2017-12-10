using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var under3 = 0D;
            var under4 = 0D;
            var under5 = 0D;
            var under6 = 0D;
            var sum = 0D;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                sum += num;
                if (num <= 2.99)
                {
                    under3++;
                }
                else if (num <= 3.99)
                {
                    under4++;
                }
                else if (num <= 4.99)
                {
                    under5++;
                }
                else
                {
                    under6++;
                }
            }
            Console.WriteLine($"Top students: {(under6 / n * 100):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(under5 / n * 100):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(under4 / n * 100):f2}%");
            Console.WriteLine($"Fail: {(under3 / n * 100):f2}%");
            Console.WriteLine($"Average: {(sum / n):f2}");
        }
    }
}
