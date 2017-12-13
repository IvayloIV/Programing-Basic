using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Благотворителна_кампания
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var countSweet = int.Parse(Console.ReadLine());
            var countCake = int.Parse(Console.ReadLine());
            var countGofreti = int.Parse(Console.ReadLine());
            var countPump = int.Parse(Console.ReadLine());

            var cakes = countCake * 45D;
            var gofreti = countGofreti * 5.80;
            var pumpcake = countPump * 3.20;
            var forOneDay = (cakes + gofreti + pumpcake) * countSweet;
            var allSum = forOneDay * days;
            var afterFee = allSum - (allSum / 8);
            Console.WriteLine($"{afterFee:f2}");
        }
    }
}
