using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__Name_
{
    class hello_name
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(GetName(name));
             
        }
        static string GetName(string n)
        {
            string concatenate = "Hello, " + n+'!';
            return concatenate;
        }

    }
}
