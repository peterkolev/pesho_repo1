using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class harvest
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grape = x * y;
            double wine = (((4 * grape / 10)) / 2.5);

            //Console.WriteLine(grape);
            //Console.WriteLine(wine);

            if (wine < z)
            {
                double wineOne = Math.Floor(z - wine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", wineOne);
                Console.WriteLine();


            }

            if (wine >= z)
            {
                double wineOne = Math.Floor(wine);
                double wineLeft = Math.Ceiling(wine - z);
                double wineWorks = Math.Ceiling(wineLeft / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", wineOne);
                Console.WriteLine("{0} liters left -> {1} liters per person.", wineLeft, wineWorks);
            }




        }
    }
}
