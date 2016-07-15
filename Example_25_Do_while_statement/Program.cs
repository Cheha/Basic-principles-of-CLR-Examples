using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_25_Do_while_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            m = -5;
            do
            {
                Console.WriteLine("Inside do-while loop");
            } while (m > 10);
            Console.WriteLine("Done m = "+m);
            Console.ReadLine();
        }
    }
}
