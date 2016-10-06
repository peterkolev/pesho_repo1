//12.Master Numbers from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 04.10.2016
//Condition:
//A master number is an integer that holds the following properties:
//•	Is symmetric(palindrome), e.g. 5, 77, 282, 14341, 9553559.
//•	Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
//•	Holds at least one even digit, e.g. 232, 707, 6886, 87578.
//Write a program to print all master numbers in the range[1…n].
//Hints
//1.	Write 3 utility methods:
//•	IsPalindrome(int num)
//•	SumOfDigits(int num)
//•	ContainsEvenDigit(int num)
//2.	Loop through all numbers in range[1…n] and check every number with the helper methods.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 7; i <= number; i++)
            {
                if (IsPalindrome(i) == true && SumOfDigits(i) == true && ContainsEvenDigit(i) == true) Console.WriteLine(i);
            }
               
        }
        static bool IsPalindrome(int num)
        {
            int straight = num;
            int reverse = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reverse = (reverse * 10) + digit;
                num = num / 10;
            }
            if (straight == reverse) return true;
            else return false;
        }
        static bool SumOfDigits(int num)
        {
            
            int sum = 0;
            while (num>0)
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
            }
            if (sum % 7 == 0) return true;
            else return false;
        }
        static bool ContainsEvenDigit(int num)
        {
            int even = 0;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    even += 1;
                    break;
                }
                num = num / 10;
            }
            if (even == 1) return true;
            else return false;
        }
    }
}
