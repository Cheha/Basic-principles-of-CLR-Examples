using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use byte, int
            Console.WriteLine("Use byte, int");
            byte y;
            int sum;
            sum = 0;
            // No need control for y < 50
            for (y = 1; y <= 50; y++) {
                //sum = sum + y;
                sum += y;
            }
            Console.WriteLine("Summ for 50: " + sum);

        }
    }
}
