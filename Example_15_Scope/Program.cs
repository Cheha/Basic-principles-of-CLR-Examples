using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_15_Scope
{
    class Program
    {
        static int myy = 0;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrate block scope");
            int myx = 20;
            
            if (myx == 20) {
                myy = 10;
                Console.WriteLine("myx & myy: {0} {1}", myx, myy);
                myx = myy * 2;
            }
            var x = myy;
            // myy = 1000; // Error
            Console.WriteLine("myx is {0}", myy);
            Console.ReadLine();
        }

        static void MyFunc() {
            int xxx = 55;
            var x = myy;
        }
    }
}
