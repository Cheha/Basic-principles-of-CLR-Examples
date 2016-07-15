using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_21_if_else_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            if (6 < 4 * 3) {
                Console.WriteLine("6 < 4 * 3 - true"); // true
                if (50 < 4 * 3)
                {
                    Console.WriteLine("6 < 4 * 3 - true"); // true
                    Console.WriteLine(".........");
                }
               
            }
            if (6 < 4 * 3)
            {
                if (6 < i * 3) {
                    Console.WriteLine("if statement executes");
                }
                    
                else
                    Console.WriteLine("else executes");
            }
            if (6 < 4 * 3) {
                if (6 > i * 3)
                    Console.WriteLine("if statement executes");
                else
                    Console.WriteLine("else statement executes");
            }
        }
    }
}
