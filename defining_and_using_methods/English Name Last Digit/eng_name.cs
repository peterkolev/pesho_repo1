using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_Last_Digit
{
    class eng_name
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(LastNumberToWord(number));
        }
        static string LastNumberToWord(string n)
        {
            long number = Math.Abs(long.Parse(n));
            long lastNumber = number % 10;
            switch (lastNumber)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Wrong input";
            }
        }
    }
}
