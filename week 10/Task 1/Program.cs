using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MountainBike mon = new MountainBike(10,19,45);
            mon.Showthis();
            mon.SetCadence(12);
            mon.Applybrake(5);
            mon.Showthis();
            Console.ReadKey();
            
        }
    }
}
