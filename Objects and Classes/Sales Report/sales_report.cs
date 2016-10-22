//7.	Sales Report from Objects and Classes Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni. 22.10.2016
//task:Write a class Sale holding the following data: town, product, price, quantity. Read a list of sales and calculate and print the total sales by town as shown in the output. Order alphabetically the towns in the output.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    class sales_report
    {
        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();
            var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t).ToArray();
            foreach (string town in towns)
            {
                decimal salesByTown = sales.Where(s => s.Town == town).Select(s => s.Price * s.Quantity).Sum();
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
            }

        }
        static Sale ReadSale()
        {
            string[] items = Console.ReadLine().Split(' ');

            return new Sale()
            {
                Town = items[0],
                Product = items[1],
                Price = decimal.Parse(items[2]),
                Quantity = decimal.Parse(items[3])
            };
        }
        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i <n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }

        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            
        }
    }
}
