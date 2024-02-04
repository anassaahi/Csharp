using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM");
            atm atm = new atm();
            atm.checkbalance();
            atm.deposit(100);
            atm.deposit(100);
            atm.checkbalance();
            atm.withdrawal(400);
            atm.withdrawal(500);
            atm.checkbalance();
            Console.WriteLine("THE history of the transaction is as follows:");     
            atm.transactionhistory();
            Console.ReadKey();
        }
    }
}
