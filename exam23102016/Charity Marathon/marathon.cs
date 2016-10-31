using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class marathon
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int avarageLaps = int.Parse(Console.ReadLine());
            int trackLenghtInMeters = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            //per day meters

         

            if (runners>trackCapacity)
            {
                runners = trackCapacity;
                int metersPerDay = (runners/days) * avarageLaps * trackLenghtInMeters;
                //days -> meters
                int totalMeters = days * metersPerDay;
                
                double moneyRaised = (totalMeters / 1000.00) * moneyPerKilometer;
                Console.WriteLine("Money raised: {0:f2}", moneyRaised);
            }
            else
            {
                double moneyRaised = 0.0;
                Console.WriteLine("Money raised: {0:f2}", moneyRaised);

            }




           
        }
    }
}
