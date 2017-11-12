using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Сумиране_на_секунди2
{
    class Program
    {
        static void Main(string[] args)
        {
            var secounds = 0;
            for (int i = 0; i < 3; i++)
            {
                secounds += int.Parse(Console.ReadLine());
            }
            TimeSpan t = TimeSpan.FromSeconds(secounds);
            Console.WriteLine($"{t.ToString(@"m\:ss")}");
        }
    }
}
