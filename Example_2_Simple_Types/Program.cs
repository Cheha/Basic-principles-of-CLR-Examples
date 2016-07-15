using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_Simple_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code example #2:
            int b1 = 0;
            System.Int32 b2 = 0;


            //Code example #3:
            Console.WriteLine("Using new keyword to creating new variables");
            bool f = new bool();
            int i = new int();
            double d = new double();

            object ss = new object();

            Console.WriteLine("new bool, new int, new double");
            Console.WriteLine("{0},{1},{2}", f, i, d);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
