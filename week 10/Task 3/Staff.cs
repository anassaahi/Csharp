using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_3
{
    internal class Staff:Person
    {
        private string School;
        private double Pay;
        public Staff(string name,string address,string School,double Pay):base(name,address)
        {
            this.School = School;
            this.Pay = Pay;

            
        }
        public string GetSchool()
        {
            return School;
        }
        public double GetPay()
        {
            return Pay;
        }
        public void SetSchool(string school)
        {
            this.School = school;
        }
        public void SetPay(double pay)
        {
            this.Pay = pay;
        }
    }
}
