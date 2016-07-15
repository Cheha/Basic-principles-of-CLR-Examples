using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_20_Shift_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch tm = new System.Diagnostics.Stopwatch();
            tm.Start();
            byte pow = 1 << 5;
            tm.Stop();
            Console.WriteLine("Left-shift time = {0}", tm.Elapsed.TotalMilliseconds);
            // first time
            tm.Reset();
            tm.Start();
            byte mathPow = (byte)Math.Pow(2, 5);
            tm.Stop();
            Console.WriteLine("Math time = {0}", tm.Elapsed.TotalMilliseconds);
            // second time
        }
    }
}
