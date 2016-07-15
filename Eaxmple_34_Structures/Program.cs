using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eaxmple_34_Structures
{
    class Program
    {
        enum Sex { Male, Female };

        struct Animal
        {
            public string species;
            public string name;
            public int age;
            public Sex sex;
        }

        static void Main(string[] args)
        {
            Animal lion;
            lion.species = "lion";
            lion.name = "leo";
            lion.age = 7;
            lion.sex = Sex.Male;

            Animal lion2 = new Animal();
            lion2.species = lion.species;
            lion2.name = "King";
            lion2.age = 5;
            lion2.sex = Sex.Male;
        }
    }
}
