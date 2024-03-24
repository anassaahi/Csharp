using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    internal class Account
    {
        private string AccountNumber;
        private float Balance;
        public Account(string accountNumber, float balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public string GetAccountNumber()
        {
            return AccountNumber;
        }
        public void SetAccountNumber(string accountNumber)
        {
            AccountNumber = accountNumber;
        }
        public float GetBalance()
        {
            return Balance;
        }
        public void SetBalance(float balance)
        {
            Balance = balance;
        }
        public void Deposit(float amount)
        {
            Balance += amount;
        }
        public void Withdraw(float amount)
        {
            Balance -= amount;
        }
    }
}
