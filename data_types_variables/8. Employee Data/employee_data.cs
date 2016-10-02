using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class employee_data
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = (char)('f');
            long personalId = 8306112507;
            uint employeNumber = 27563571;
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalId}");
            Console.WriteLine($"Unique Employee number: {employeNumber}");
        }
    }
}
