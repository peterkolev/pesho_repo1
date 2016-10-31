using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam23102016
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long avarageLaps = long.Parse(Console.ReadLine());
            long trackLenghtInMeters = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            long maxRunners = trackCapacity * days;

            if (maxRunners>=runners)
            {

                long totalMeters = runners * avarageLaps * trackLenghtInMeters;
                double totalKilometers = totalMeters / 1000.00;
                double totalMoney = totalKilometers * moneyPerKilometer;
                Console.WriteLine("Money raised: {0:f2}",totalMoney);

            }
            else if(maxRunners < runners)
            {
                long totalMeters = trackCapacity * days * avarageLaps * trackLenghtInMeters;
                double totalKilometers = totalMeters / 1000.00;
                double totalMoney = totalKilometers * moneyPerKilometer;
                Console.WriteLine("Money raised: {0:f2}", totalMoney);
            }

        }
    }
}
