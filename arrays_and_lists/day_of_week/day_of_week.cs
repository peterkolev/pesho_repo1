// 1.Day of Week from Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni 08.10.2016
//Condition: Enter a day number [1…7] and print the day name (in English) or “Invalid Day!”. Use an array of strings.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_of_week
{
    class day_of_week
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());
            if  (n>0 && n<8)
            {
                Console.WriteLine((days[n-1]));
            }
            else Console.WriteLine("Invalid Day!");
        }
    }
}
