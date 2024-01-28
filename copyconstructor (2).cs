using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyconstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 s1 = new Class1();
            s1.id = 1;
            Class1 s2 = new Class1(s1);
            s2.id = 2; 
            Console.WriteLine(s1.id);
            Console.WriteLine(s2.id);
            Console.Read();
        }
    }
}
