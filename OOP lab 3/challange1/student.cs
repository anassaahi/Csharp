using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challange1
{
    internal class student
    {

        public string Name;
        public int MatricMarks ;
        public int FscMarks ;
        public int EcatMarks ;
        public student(string name, int matricMarks, int fscMarks, int ecatMarks)
        {
            Name = name;
            MatricMarks = matricMarks;
            FscMarks = fscMarks;
            EcatMarks = ecatMarks;
        }
        public double CalculateAggregate()
        {
            double matricWeight = 0.3;
            double fscWeight = 0.4;
            double ecatWeight = 0.3;
            return (MatricMarks * matricWeight) + (FscMarks * fscWeight) + (EcatMarks * ecatWeight);
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Matric Marks: {MatricMarks}");
            Console.WriteLine($"Fsc Marks: {FscMarks}");
            Console.WriteLine($"Ecat Marks: {EcatMarks}");
            Console.WriteLine($"Aggregate: {CalculateAggregate():F2}");
            Console.WriteLine();
        }
    }
   
   
}
