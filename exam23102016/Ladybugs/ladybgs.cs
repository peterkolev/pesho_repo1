using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class ladybgs
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            List<int> indexLadies = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> commands = new List<string>();
            for (int i = 0; i < 101; i++)
            {
                if (Console.ReadLine() == "end")
                {
                    break;
                }
                else


               {
                    commands.Insert(i,Console.ReadLine());
               }
            }
            //while (Console.ReadLine() == "end")
            //{
            //    commands.Add(Console.ReadLine());
            //}
            Console.WriteLine(string.Join(" ",commands));
          
        }
    }
}
