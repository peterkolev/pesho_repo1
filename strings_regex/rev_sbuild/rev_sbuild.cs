using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rev_sbuild
{
    class rev_sbuild
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string reverseString = ReverseString(inputString);
            Console.WriteLine(reverseString);
        }
        public static string ReverseString(string s)
            {
            StringBuilder sb = new StringBuilder();
                for (int i = s.Length-1; i>=0; i--)
			    {
                    sb.Append(s[i]);
			    }
                return sb.ToString();
            }


    }
}
