using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_30_Array_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr1 = new int[2, 2];
            //arr1[0, 0] = 1;
            //arr1[0, 1] = 2;
            //arr1[1, 0] = 3;
            //arr1[1, 1] = 4;

            //int[,] arr2 = new int[2, 2];
            //arr2[0, 0] = 1;
            //arr2[0, 1] = 2;
            //arr2[1, 0] = 7;
            //arr2[1, 1] = 8;

            //// suggest arrays are equals
            //bool flag = true;

            //for (int i = 0; i < arr1.GetLength(0); i++) {
            //    for (int j = 0; j < arr2.GetLength(1); j++) {
            //        if (arr1[i, j] != arr2[i, j]) {
            //            flag = false;
            //        }
            //    }
            //}
            bool flag = false;

            int[] arr1 = new int[2];
            arr1[0] = 1;
            arr1[1] = 1;

            int[] arr2 = new int[2];
            arr2[0] = 1;
            arr2[1] = 1;

            for (int i = 0; i < 2; i++) {
                if (arr1[i] == arr2[i]) {
                    flag = true;
                }
            }

            Console.WriteLine("Are arr1 and arr2 equals?");
            Console.WriteLine(flag);
            Console.ReadLine();
        }
    }
}
