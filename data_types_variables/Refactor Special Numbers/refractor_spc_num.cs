using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class refractor_spc_num
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= n; num++)
            {
                int sum = 0;
                int workNumber = num;
                while (workNumber > 0)
                {
                    
                    sum += workNumber % 10;
                    workNumber = workNumber / 10;
                }
                bool specialNumber = (sum == 5) || (sum == 7) || (sum== 11);
                Console.WriteLine($"{num} -> {specialNumber}");
                
            }


        }
    }
}
