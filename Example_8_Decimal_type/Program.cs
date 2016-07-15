using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_8_Decimal_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use of decimal types");
            decimal pay, credit;
            pay = 110.0M;
            credit = pay * 12.0M;
            //Notice that the result is accurate to several decimal places
            Console.WriteLine("Credit is {0}", credit);
        }
    }
}
