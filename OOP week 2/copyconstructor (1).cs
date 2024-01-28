using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyconstructor
{
    internal class Class1
    {
        public Class1() {
            Console.WriteLine("Default constructor");
        }
        public Class1(Class1 n)
        {
            name = n.name;
            id = n.id;
            age = n.age;
            marks = n.marks;



        }
        public string name;
        public int id;
        public int age;
        public float marks;

    }
}
