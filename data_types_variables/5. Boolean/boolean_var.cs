using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_var
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool inPut = Convert.ToBoolean(input);
            if (inPut)
            {
                Console.WriteLine("Yes", inPut);
            }
            else Console.WriteLine("No");
        }
    }
}
