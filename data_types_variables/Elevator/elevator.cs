using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class elevator
    {
        static void Main(string[] args)
        {
            int nPersons = int.Parse(Console.ReadLine());
            int pCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)nPersons / pCapacity);
            Console.WriteLine(courses);
        }
    }
}
