using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_35_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.Write("Hi, ");
            Console.Write(name);
            Console.WriteLine("!");
            Console.ReadKey();
        }
    }
}
