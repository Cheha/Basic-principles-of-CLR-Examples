using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_6_Floating_point_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use floating-point types");
            double r;
            double area;
            area = 100.0;
            r = Math.Sqrt(area / Math.PI);
            Console.WriteLine("Radius is " + r);
        }
    }
}
