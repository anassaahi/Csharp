using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Circle
    {
        private double radius;
        private string color = "red";
        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle (string color, double radius)
        {
            this.color = color;
            this.radius = radius;

        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius (double radius)
        {
            this.radius = radius;
        }
        public string GetColor ()
        {
            return color;

        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public double Getarea()
        {
            return radius;

        }
        public string Tostring ()
        {
            string var;
            var = "Circle [ Radius = " + radius + ", Color = " + color + " ]";
            return var;
        }
    }
}
