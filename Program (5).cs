using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfassessment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student num1 = new student(26,"anas",18,"male");
            student num2 = new student(27, "anas", 18, "male");
            student num3 = new student(28, "anas", 18, "male");
            student[] students = new student[] {num1,num2,num3};
            for (int i = 0; i < 3; i++) {
                Console.WriteLine(students[i].id);
            }
            Console.ReadKey();
            /*
             Console.WriteLine(num1.id);
            Console.WriteLine(num2.id);
            Console.ReadKey();*/

        }
    }
}
