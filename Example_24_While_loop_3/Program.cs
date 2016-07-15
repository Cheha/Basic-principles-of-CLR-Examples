using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_24_While_loop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 8)
            {
                int j = 0;
                while (j < 8)
                {
                    Console.WriteLine(" j = " + j);
                    j++;
                    if (j == 4)
                        goto fin;
                }
                fin:
                    Console.WriteLine("Done. j = " + j + ". Press any key");
                    i++;
                    Console.WriteLine(" i = " + i);
                    if (i == 4)
                        break;
            }
            i++;            Console.WriteLine("Done. i = " + i + ". Press any key");
        }
    }
}
