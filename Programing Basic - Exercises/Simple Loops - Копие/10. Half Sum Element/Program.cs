using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers.Sum() - numbers[i])
                {
                    Console.WriteLine($"Yes Sum = {numbers[i]}");
                    return;
                }
            }
            Console.WriteLine($"No Diff = {Math.Abs(numbers.Max() - (numbers.Sum() - numbers.Max()))}");
        }
    }
}
