using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_3
{
    internal class Student:Person
    {
        private string Program;
        private int Year;
        private double Fee;
       public Student(string name,string address,string Program,int Year,double Fee) :base(name,address) { 
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;

        }
        public string GetProgram()
        {
            return Program;
        }
        public void SetProgram(string Program)
        {
            this.Program= Program;
        }
        public int GetYear()
        {
            return this.Year
                ;
        }
        public void SetYear(int Year)
        {
            this.Year = Year;
        }
        public double GetFee()
        {
            return this.Fee;
        }
        public void SetFee(double Fee)
        {
            this.Fee = Fee;
        }
        
    }
}
