using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving_Account savingAccount = new Saving_Account("123", 1000, 0.1f);
            savingAccount.AddInterest();
            Console.WriteLine("Saving Acount Balance "+savingAccount.GetAccountNumber()+ + savingAccount.GetBalance());
            Checking_Account checkingAccount = new Checking_Account("456", 1000, 0.1f);
            checkingAccount.DeductTax();
            Console.WriteLine("Checking Account Balance "+checkingAccount.GetAccountNumber() + checkingAccount.GetBalance());
            Console.ReadKey();
        }
    }
}
