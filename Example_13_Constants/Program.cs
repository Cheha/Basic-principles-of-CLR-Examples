using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_13_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use constants");
            const long c_seconds = 60;
            const long c_minutes = 60;
            const long c_hours = 24;
            const long secondsPerDay = c_seconds * c_minutes * c_hours;
            Console.WriteLine("Seconds per day: {0}", secondsPerDay);
        }
    }
}
