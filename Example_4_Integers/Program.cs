using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // use long
            Console.WriteLine("Using integers");
            long minutes;
            long hours;
            minutes = 5300;
            //Our course in minutes
            hours = minutes / 45;
            Console.WriteLine("Our course in academyc hours: " + hours + " hours");
            Console.WriteLine("Our course in academyc hours: {0} hours {1}", hours, hours);
            Console.WriteLine("Our course in academyc hours: {0} hours (inherited)", hours.ToString());
            Console.WriteLine();

            String.Format("Our course in academyc hours: {0} hours {1}", hours, hours);
        }
    }
}
