using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_27_Multidimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] two_dim_arrray = new int[2, 2];

            two_dim_arrray[0, 0] = 1;
            two_dim_arrray[0, 1] = 2;
            two_dim_arrray[1, 0] = 3;
            two_dim_arrray[1, 1] = 4;

            Console.WriteLine("This is our two dimensional array:");
            Console.WriteLine("{0} {1}", two_dim_arrray[0,0], two_dim_arrray[0,1]);
            Console.WriteLine("{0} {1}", two_dim_arrray[1,0], two_dim_arrray[1,1]);
        }
    }
}
