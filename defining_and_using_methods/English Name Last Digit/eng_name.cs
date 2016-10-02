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
            int number = int.Parse(Console.ReadLine());

        }
        static int LastNumberToWord(int n)
        {
            int lastNumber = n % 10;
            string word;
            if (lastNumber == 1)
            {
                return word = "one";
            }
            switch (lastNumber)
            {
                case 0: return word = "zero";
                
                    

            }
        }
    }
}
