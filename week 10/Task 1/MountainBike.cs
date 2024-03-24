using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MountainBike : Bicycle
    {
        private int setHeight;
        public MountainBike(int cadence,int speed, int some) : base(cadence, speed, some)
        {
            Console.WriteLine("MountainBike executed!");
        }
    }
}
