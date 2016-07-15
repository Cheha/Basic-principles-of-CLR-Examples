using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_25_While_loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 8)
            {
                i++;
                Console.WriteLine(" i = " + i);
                if (i == 4)
                    break;
            }
            i++;
            Console.WriteLine("Done. i = " + i + ". Press any key");
        }
    }
}
