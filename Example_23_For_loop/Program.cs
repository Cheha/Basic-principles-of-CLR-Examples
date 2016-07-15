using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_23_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 1, lim = 10;

            for (int j = 1; j <= lim; j++) { 
                // multiplication
                res *= j;
                Console.WriteLine("j = {0}, res = res*=j = {1}", j, res);
            }
            Console.WriteLine("End res = {0}", res);
            Console.ReadLine();
        }
    }
}
