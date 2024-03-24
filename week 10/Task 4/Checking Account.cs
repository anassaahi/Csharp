using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    internal class Checking_Account:Account
    {
       private float Tax;
        public float GetTax()
        {
              return Tax;
         }
        public void SetTax(float tax)
        {
            this.Tax = tax;
        }
        public Checking_Account(string accountNumber, float balance, float tax):base(accountNumber, balance)
        {
            this.Tax = tax;
        }
        public void DeductTax()
        {
            float tax = GetBalance() * Tax;
            Withdraw(tax);
        }

    }
}
