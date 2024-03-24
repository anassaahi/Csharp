using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bicycle
    {
        private int cadence;
        private int gear;
        private int speed;
        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
            Console.WriteLine("Bicycle executed");
        }
        public void SetCadence(int cadence)
        {
            this.cadence = cadence;

        }
        public void SetGear(int gear)
        {
            this.gear = gear;
        }
        public void Applybrake(int decrement)
        {
            speed -= decrement;
        }
        public void SpeedUp(int incriment) { 
            speed += incriment;
        }
        public void Showthis()
        {
            Console.WriteLine("{0}", cadence);
            Console.WriteLine("{0}", gear);
            Console.WriteLine("{0}", speed);

        }
    }
}
