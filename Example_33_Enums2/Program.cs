using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_33_Enums2
{
    class Program
    {
        enum Days { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            int weekday_start = (int)Days.Mon;
            int weekday_end = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", weekday_start);
            Console.WriteLine("Friday: {0}", weekday_end);
            Console.ReadLine();
        }
    }
}
