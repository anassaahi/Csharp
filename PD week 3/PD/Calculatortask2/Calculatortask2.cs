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
        public double sqrt(double num)
        {
            return Math.Sqrt(num);
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
        public double Exp(double exponent)
        {
            return Math.Exp(exponent);
        }
        public double Log(double number)
        {
            return Math.Log(number);
        }
        private double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180.0);
        }
        public double Sin(double angleDegrees)
        {
            double angleRadians = DegreesToRadians(angleDegrees);
            return Math.Sin(angleRadians);
        }

        public double Cos(double angleDegrees)
        {
            double angleRadians = DegreesToRadians(angleDegrees);
            return Math.Cos(angleRadians);
        }

        public double Tan(double angleDegrees)
        {
            double angleRadians = DegreesToRadians(angleDegrees);
            return Math.Tan(angleRadians);
        }
    }
}

