using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursExam = int.Parse(Console.ReadLine());
            var minutesExam = int.Parse(Console.ReadLine());
            var hoursHere = int.Parse(Console.ReadLine());
            var minutesHere = int.Parse(Console.ReadLine());

            var startExamMin = hoursExam * 60 + minutesExam;
            var arriveMin = hoursHere * 60 + minutesHere;


            var n = startExamMin - arriveMin;
            var hours = Math.Abs(n) / 60;
            var minutes = Math.Abs(n) % 60;
            if (n < 0)
            {                
                Console.WriteLine($"Late");
                if (hours == 0)
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }
            else if (n >= 0 && n <= 30)
            {
                Console.WriteLine($"On time");
                Console.WriteLine($"{n} minutes before the start");
            }
            else
            {
                Console.WriteLine($"Early");
                if (hours == 0)
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }
        }
    }
}
