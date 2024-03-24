using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Cylinder : Circle
    {
        private double height = 1.0;
        public Cylinder()
        {

        }
        public Cylinder(double height)
        {
            this.height = height;
        }
        public Cylinder(double height, double radius)
        {
            this.height = height;

        }
        public Cylinder(double height, double radius, string color)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return height;

        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetVolume ()
        {
            return 100 * height * GetRadius();
        }
    }
}
