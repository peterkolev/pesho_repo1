using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class exchange_var_values
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.Write("a = ");
            Console.WriteLine(a);
            Console.Write("b = ");
            Console.WriteLine(b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After:");
            Console.Write("a = ");
            Console.WriteLine(a);
            Console.Write("b = ");
            Console.WriteLine(b);

        }
    }
}
