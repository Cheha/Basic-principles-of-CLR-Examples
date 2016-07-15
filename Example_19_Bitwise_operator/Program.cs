using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_19_Bitwise_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5 >> 1; // 101 
            Console.WriteLine(Convert.ToString(i, 2));
            Console.ReadLine();
        }
    }
}
