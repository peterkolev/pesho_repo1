using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class centuries2nanosec
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = (int)centuries * 100;
            int days = (int)(years * 365.2422);
            uint hours = (uint)(days * 24);
            ulong minutes =(ulong)(hours * 60);
            ulong seconds = (ulong)(minutes * 60);
            ulong milliseconds = (ulong)(seconds * 1000);
            ulong microseconds = milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;
            
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
