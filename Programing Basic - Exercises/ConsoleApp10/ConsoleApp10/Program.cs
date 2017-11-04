using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                var n = int.Parse(Console.ReadLine());
                var arr = new List<int>();
                for (var i = 0; i < n; i++)
                {
                    arr.Add(int.Parse(Console.ReadLine()));
                }

                foreach (var item in arr)
                {
                    if (item == arr.Sum() - item)
                    {
                        var sum = arr.Sum() - item;
                        Console.WriteLine("Yes");
                        Console.WriteLine("Sum  = " + sum);
                        return;
                    }
                }
                Console.WriteLine("No");
                var max = arr.Max();
                arr.Remove(arr.Max());
                Console.WriteLine("Diff = " + Math.Abs(arr.Sum() - max));
            }
        }
    }
}