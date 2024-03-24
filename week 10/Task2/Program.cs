using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cl = new Cylinder(10,20,"red");
             
            cl.SetColor("Green");
            cl.SetRadius(40);
            cl.SetHeight(50);
            Console.Write(cl.ToString());
            Console.ReadKey();
                

        }
    }
}
