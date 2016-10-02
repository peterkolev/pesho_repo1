using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class multiply
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }
        private static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEven = GetSumEvenNumber(number);
            int sumOdd = GetSumOddNumber(number);
            return sumEven * sumOdd;
        }
        private static int GetSumEvenNumber(int number)
        {
            int sum = 0;
            while (number>0)
            {
                int lastDigit = number % 10;
                if (lastDigit%2==0) sum += lastDigit;
                number = number / 10;
            }
            return sum;
        }
        private static int GetSumOddNumber(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0) sum +=lastDigit;
                number = number / 10;
            }
            return sum;
        }

    }
}
