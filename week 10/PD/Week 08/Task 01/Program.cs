﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ANas", "kjsgs", "CS", 2023, 50000);
            Console.WriteLine(s1.To_String());
            s1.SetFee(9000);
            s1.SetAdress("jdhsjjs");
            Console.WriteLine(s1.To_String());
            Staff staff = new Staff("ishy", "jhdu", "UET", 50000);
            Console.WriteLine(staff.To_String());
            staff.SetPay(12000);
            staff.SetSchool("UMT");
            Console.WriteLine(staff.To_String());
            Console.ReadKey();
        }
    }
}
