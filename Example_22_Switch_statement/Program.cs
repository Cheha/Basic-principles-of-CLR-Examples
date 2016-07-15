using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_22_Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value...");
            int a = int.Parse(Console.ReadLine());
            switch (a) { 
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.ReadLine();
        }
    }
}
