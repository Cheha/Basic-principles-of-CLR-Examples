using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_31_Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bubble sort implementation
            int[] int_array = new int[7] { 89, 76, 45, 92, 67, 12, 99 };

            for (int i = 0; i < int_array.Length - 1; i++)
            {
                for (int j = 0; j < int_array.Length - 1; j++)
                {
                    if (int_array[j + 1] < int_array[j])
                    {
                        var temp = int_array[j];
                        int_array[j] = int_array[j + 1];
                        int_array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Array after sorting: ");
            foreach (var arr_elem in int_array)
            {
                Console.Write("{0} ", arr_elem);
            }
        }
    }
}
