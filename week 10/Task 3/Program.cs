using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ahmed","ABC","CS",4,22.99);
            Staff staff = new Staff("Ali","EFC","UET",40.09);
            Console.WriteLine($"Student" + " " + student.GetName() + " " + student.GetAddress() + " " + student.GetProgram() + " " + student.GetYear() + " " +student.GetFee());
            Console.WriteLine();
            Console.WriteLine($"Staff" + " " + staff.GetName() + " " + staff.GetAddress() + " " + staff.GetSchool() + " " +staff.GetPay());
            Console.ReadKey();
        }
    }
}
