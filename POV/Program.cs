using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction originalTransaction = new Transaction(1, "ItemA", 50.99m, "2024-02-04 14:30:00");
            Transaction duplicatedTransaction = new Transaction(originalTransaction);
            Console.WriteLine("Original Transaction Details:");
            originalTransaction.DisplayTransactionDetails();
            Console.WriteLine("Duplicated Transaction Details:");
            duplicatedTransaction.DisplayTransactionDetails();
            Console.ReadKey();
        }
    }
}
