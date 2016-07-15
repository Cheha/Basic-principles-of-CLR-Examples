using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_17_Modulus_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // int
            Console.WriteLine(7 % 3);
            // int
            Console.WriteLine(-7 % 3);
            // double
            Console.WriteLine(7.0 % 3.2);
            // decimal
            Console.WriteLine(7.0M % 3.2M);
            // double
            Console.WriteLine(-7.2 % 3.0);
        }
    }
}
