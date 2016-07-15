using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_16_Casting_and_type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type convertions
            Console.WriteLine("Type conversions ");
            short nmb1 = 10, nmb2 = 10;
            int nmsum;
            int x = 5, y = 6;
            // implicit convertion
            nmsum = nmb1 + nmb2;
            Console.WriteLine("Explicity");
            Console.WriteLine("{0} + {1} = {2}", nmb1, nmb2, nmsum);
            x = 30000;
            nmb2 = 30000;
            Console.WriteLine("Casting");
            // An explicit conversion exists (are you missing a cast?)
            nmsum = (short)(nmb1 + nmb2);
            //the result of our addition is completely incorrect
            Console.WriteLine("{0} + {1} = {2}", nmb1, nmb2, nmsum);
            byte studByte = 0;
            int studInt = 260;
            // Eplicitly case - no loss
            studByte = Convert.ToByte(studInt);
            Console.WriteLine("Value of byte is {0}", studByte);
        }
    }
}
