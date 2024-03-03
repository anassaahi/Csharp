using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPD
{
    internal class calculator
    {
        float number1;
        float number2;

        public calculator(float num1, float num2)
        {
            number1 = num1;
            number2 = num2;
            
        }
        public float sum(float num1, float num2)
        {
            return num1 + num2;
        }
        public float subtract(float num1, float num2)
        {
            return num1 - num2;
        }
        public float multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public float divide(float num1, float num2)
        {
            return num1 / num2;
        }
        public float modulo(float num1, float num2)
        {
            return num1 % num2;
        }
    }
}
