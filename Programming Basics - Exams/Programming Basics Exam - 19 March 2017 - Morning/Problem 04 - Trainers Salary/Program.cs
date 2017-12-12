using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());

            var book = new Dictionary<string, int>
            {
                ["Jelev"] = 0,
                ["RoYaL"] = 0,
                ["Roli"] = 0,
                ["Trofon"] = 0,
                ["Sino"] = 0,
                ["Others"] = 0
            };
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                if (book.ContainsKey(name))
                {
                    book[name]++;
                }
                else
                {
                    book["Others"]++;
                }
            }

            foreach (var currentName in book)
            {
                Console.WriteLine($"{currentName.Key} salary: {(money / ((double)n / currentName.Value)):f2} lv");
            }
        }
    }
}
