using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var electricity = 0D;
            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                electricity += num;
            }
            var water = n * 20;
            var internet = n * 15;
            var sum = electricity + water + internet;
            var others = sum + (sum * 0.2);
            var average = (sum + others) / n;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
