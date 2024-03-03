using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            float num1 = 0;
            float num2 = 0;
            calculator c = new calculator(num1, num2);
            while (true)
            {
                option = menu();
                if (option == 1)
                {
                    takeinput(ref num1, ref num2);
                    Console.Clear();
                }
                else if(option == 2) 
                {
                    float sum  = c.sum(num1, num2);
                    Console.WriteLine("SUM of the numbers is :{0}",sum);
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    Console.Clear();


                }
                else if (option == 3)
                {
                    float sub = c.subtract(num1, num2);
                    Console.WriteLine("SUBTRACTION of the numbers is :{0}", sub);
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == 4)
                {
                    float mul = c.multiply(num1, num2);
                    Console.WriteLine("MULTIPLY of the numbers is :{0}", mul);
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == 5)
                {
                    float div = c.divide(num1, num2);
                    Console.WriteLine("divison of the numbers is :{0}", div);
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == 6)
                {
                    float mod = c.modulo(num1, num2);
                    Console.WriteLine("MODULO of the numbers is :{0}", mod);
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (option == 7)
                {
                    Environment.Exit(0);
                }
               


            }
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1.Enter the value            ");
            Console.WriteLine("2.Add                                     ");
            Console.WriteLine("3.Subtract                                ");
            Console.WriteLine("4.Multiply                                ");
            Console.WriteLine("5.Divide                                  ");
            Console.WriteLine("6.Modulo                                  ");
            Console.WriteLine("7.Exit");
            Console.Write("Enter Option number:");
            option = int.Parse(Console.ReadLine());
            return option;

        }
        static void takeinput(ref float num1, ref float num2)
        {
            Console.Write("Enter the first number: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = float.Parse(Console.ReadLine());
            
        }
        
    }
}
