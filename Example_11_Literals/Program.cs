using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_11_Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            int ss = 1;
            //Inheriting from System.Object
            Console.WriteLine("Inheriting from System.Object");
            Console.WriteLine("9.GetHashCode() = {0}", 9.GetHashCode());
            Console.WriteLine("9.Equals(23) = {0}", 9.Equals(23));
            Console.WriteLine("9.ToString() = {0}", 9.ToString());
            Console.WriteLine("9.GetType() = {0}", 9.GetType());
        }
    }
}
