using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_12_Literals_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use literals
            Console.WriteLine("Use literals");
            // ul, uL, Ul, UL, lu, lU, Lu, LU
            ulong myint, myint1;
            myint = 16LU;
            Console.WriteLine(myint);
            Console.WriteLine("Hexadecimal literals");
            myint = 0xFF; // 225
            myint1 = 0x10; // 16
            Console.WriteLine("{0} {1}", myint, myint1);
        }
    }
}
