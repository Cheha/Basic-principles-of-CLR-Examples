using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_10_Boolean_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use boolean");
            bool logic;
            logic = false;
            if (9 < 10) {
                logic = true;
            }
            Console.WriteLine("9 < 10 is {0}", logic);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
        }
    }
}
