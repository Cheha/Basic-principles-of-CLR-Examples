using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_14_Dynamic_initialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using a dynamic initialization");
            double side1 = 4.0;
            double side2 = 5.0;
            // Dynamically initialized hyp
            double hyp = Math.Sqrt((side1 * side1) + (side2 + side2));
            Console.WriteLine("Hypotenuse with sides {0} by {1} is {2}", side1, side2, hyp);
            Console.WriteLine("{0:#.###}", hyp);

        }
    }
}
