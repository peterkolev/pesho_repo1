using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class var_hex
    {
        static void Main(string[] args)
        {
            string str16 = Console.ReadLine();
            
            Console.WriteLine(Convert.ToInt32(str16, 16));
            
        }
    }
}
