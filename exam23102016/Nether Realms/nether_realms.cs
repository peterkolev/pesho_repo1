using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nether_Realms
{
    class nether_realms
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new char[] {',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(string.Join(" ",names));
        }
    }
}
