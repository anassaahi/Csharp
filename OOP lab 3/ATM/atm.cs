using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class atm
    {   public List <string> transaction = new List <string> ();

        public float balance = 10000;
        public void deposit(float amount)
        {
            balance += amount;
            transaction.Add($"Amount deposited : {amount}");   
        }
        public void withdrawal(float amount) {
        if(amount < balance)
            {
                balance -= amount;
                transaction.Add($"Amount withdrwal : {amount}");
            }
            else
            {
                Console.WriteLine("Amount exceeded");
            }
        }
        public void checkbalance()
        {
            Console.WriteLine($"The total balance is :{balance}");
        }
        public void transactionhistory()
        {
            for (int i = 0; i < transaction.Count; i++)
            {
                Console.WriteLine(transaction[i]);
            }
        }
    }
}
