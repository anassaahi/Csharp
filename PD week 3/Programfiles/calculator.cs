using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class calculator
    {
        public float num1;
        public float num2;
        public float sum(float num1, float num2) {
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
    }
}
