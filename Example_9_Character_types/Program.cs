using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_9_Character_types
{
    class Program
    {
        static void Main(string[] args)
        {
            char myChar;
            myChar = 'C';
            Console.WriteLine("char.IsDigit('c'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('c'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello there', 5): {0}", char.IsWhiteSpace("Hello there", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello there', 6): {0}", char.IsWhiteSpace("Hello there", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
        }
    }
}
