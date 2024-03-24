using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    internal class Saving_Account:Account
    {
        private float InterestRate;
        public float GetInterestRate()
        {
            return InterestRate;
        }
        public void SetInterestRate(float interestRate)
        {
            InterestRate = interestRate;
        } 
        
        public Saving_Account(string accountNumber, float balance, float interestRate):base(accountNumber, balance)
        {
            InterestRate = interestRate;
            
        }
        public void AddInterest()
        {
            float interest = GetBalance() * InterestRate;
            Deposit(interest);
        }

    }
}
