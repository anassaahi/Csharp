using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPselfassesment1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(); 
            student s2 = new student();
            Console.WriteLine(s1.age);
            Console.WriteLine(s2.age);
            Console.ReadKey();
            
        }
    }
}
