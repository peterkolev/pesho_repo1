using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Latin_Letters
{
    class triples_latin
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int p1 = 0; p1 <n; p1++)
            {
                for (int p2 = 0; p2 < n; p2++)
                {
                    for (int p3 = 0; p3 < n; p3++)
                    {
                        char letter1 = (char)('a' + p1);
                        char letter2 = (char)('a' + p2);
                        char letter3 = (char)('a' + p3);
                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);

                    }
                }
            }
        }
    }
}
