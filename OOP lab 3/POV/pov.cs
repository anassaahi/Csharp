using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Transaction
    {
        public int TransactionId;
        public string ProductName;
        public decimal Amount;
        public string DateTime;

        public Transaction(int transactionId, string productName, decimal amount, string dateTime)
        {
            TransactionId = transactionId;
            ProductName = productName;
            Amount = amount;
            DateTime = dateTime;
        }
        public Transaction(Transaction originalTransaction)
        {
            TransactionId = originalTransaction.TransactionId;
            ProductName = originalTransaction.ProductName;
            Amount = originalTransaction.Amount;
            DateTime = originalTransaction.DateTime;
        }
        public void DisplayTransactionDetails()
        {
            Console.WriteLine($"Transaction ID: {TransactionId}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Amount: {Amount:C}");
            Console.WriteLine($"Date and Time: {DateTime}");
            Console.WriteLine();
        }
    }

}
