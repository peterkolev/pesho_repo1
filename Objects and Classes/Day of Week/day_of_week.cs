//1. Day of Week from Objects and Classes Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni. 21.10.2016
//task: You are given a date in format day-month-year. Calculate and print the day of week in English.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    class day_of_week
    {
        static void Main(string[] args)
        {
            string textAsDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(textAsDate, "d-M-yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);

        }
    }
}
