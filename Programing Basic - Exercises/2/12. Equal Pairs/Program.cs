using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));
            }

            var firstSum = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != firstSum)
                {
                    var delay = int.MinValue;
                    for (int k = 0; k < numbers.Count - 1; k++)
                    {
                        if (delay < Math.Abs(numbers[k] - numbers[k + 1]))
                        {
                            delay = Math.Abs(numbers[k] - numbers[k + 1]);
                        }
                    }
                    Console.WriteLine($"No, maxdiff={delay}");
                    return;
                }
            }
            Console.WriteLine($"Yes, value={firstSum}");
        }
    }
}
