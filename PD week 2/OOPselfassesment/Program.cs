using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPselfassesment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.grade = 'A';
            s1.age = 1;
            Console.WriteLine(s1.grade);
            Console.WriteLine(s1.age);
            Console.Read();
        }
    }
}
