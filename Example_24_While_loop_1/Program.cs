using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_24_While_loop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 8)
            {
                i++;
                if (i == 4)
                {
                    i++;
                    Console.WriteLine("Inside if loop :{0}", i);
                    break; // vs break;
                }
                Console.WriteLine("Inside while loop: {0}", i);
            }
            Console.WriteLine("Done. i = "+i + ". Press any key");
            Console.ReadLine();
        }
    }
}
