using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_29_Array_searching
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
            int_array[3] = 2;
            int_array[4] = 5;

            int position = -1;



            for (int i = 0; i < int_array.Length; i++)
            {
                if (int_array[i] == 8)
                {
                    position = i;
                }
            }

            Console.WriteLine("Array element with value = 2 has {0} index", position);
            Console.ReadLine();
        }
    }
}
