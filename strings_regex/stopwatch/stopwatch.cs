using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            Stopwatch st = new Stopwatch();
            st.Start();
            for (int i = 0; i <50000; i++)
            {
                result.Append(Convert.ToString(i, 2) + "\n");
            }
            st.Stop();
            Console.WriteLine(st.Elapsed);
            //Console.WriteLine(result);

        }
    }
}
