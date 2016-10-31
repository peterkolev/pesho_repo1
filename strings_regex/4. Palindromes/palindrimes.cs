using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class palindrimes
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split(new char[] { '~','&','\\','/','@',',',' ', '!', '?', '.', '-', '$', '%', '#','(',')','+','-','*','^','_' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> printList = new List<string>();
            for (int i = 0; i < inputString.Length; i++)
            {

                char[] check1 = inputString[i].ToCharArray();
                char[] check2 = check1;
                string straitWord = new string(check2);
                Array.Reverse(check1);
                string backWord = new string(check1);
                if (straitWord==backWord)
                {
                    
                    printList.Add(straitWord);
                }
            }
            printList.Sort();
            Console.WriteLine(string.Join(", ",printList));
        }
    }
}

