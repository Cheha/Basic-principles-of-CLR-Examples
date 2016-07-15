using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_32_Copy_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] int_array = new int[7] { 89, 76, 45, 92, 67, 12, 99 };

            int[] int_array_copy = new int[7];

            for (int i = 0; i < int_array.Length - 1; i++) {
                int_array_copy[i] = int_array[i];
            }

            foreach (var arr_elem in int_array_copy) {
                Console.Write(arr_elem + " ");
            }
            
        }
    }
}
