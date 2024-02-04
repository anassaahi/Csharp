using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            Console.WriteLine("Enter the first number : ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            num2 = float.Parse(Console.ReadLine()); 
            calculator calculator = new calculator();
            float sum = calculator.sum(num1, num2);
            float multipy = calculator.multiply(num1, num2);
            float divide = calculator.divide(num1, num2);
            float subtract = calculator.subtract(num1, num2);
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"multiply = {multipy}");
            Console.WriteLine($"divide = {divide}");
            Console.WriteLine($"subtract = {subtract}");
            Console.ReadKey();

        }
    }
}
