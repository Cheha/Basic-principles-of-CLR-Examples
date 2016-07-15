using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_26_Array_definition
{
    class Program
    {
        static void Main(string[] args)
        {
            // array definition
            int[] int_array = new int[5];
            // array initialization
            int_array[0] = 5;
            int_array[1] = 6;
            int_array[2] = 3;
            int_array[3] = 33;
            int_array[4] = 5;
            // error
            //int_array[5] = 4;

            for (int i = 0; i < int_array.Length; i++) {
                Console.WriteLine("int_array[{0}]: {1}", i, int_array[i]);
            }
        }
    }
}
