using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challenege_2
{
    internal class members
    {
        public string nameOfPerson;
        public int MemberId;
        public List <string> booksBought = new List <string> ();
        public int numbookBought;
        public double moneyInBank;
        public double amountSpent;

        public members(string name, int memberID)
        {
            nameOfPerson = name;
            MemberId = memberID;
            
        }

        public void modifynames(string newName)
        {
            nameOfPerson = newName;
        }

        public void displaynames()
        {
            Console.WriteLine("The name of the member is : " + (nameOfPerson));
        }

        public void UpdateBooksBought(List<string> newBooks)
        {
            booksBought = newBooks;
            numbookBought = newBooks.Count;
        }

        public void modifybooks(List <string> newBooks)
        {
            booksBought.AddRange(newBooks);
            numbookBought += newBooks.Count;
            amountSpent += 10;
            moneyInBank -= amountSpent;
        }

        public void displaybooks()
        {
            for (int i = 0; i < booksBought.Count; i++)
            {
                Console.WriteLine("Name : " + (booksBought[i]));
            }
        }

        public void setpasay(double moneyINBank)
        {
            moneyInBank = moneyINBank;
        }


        public void dispalymoney()
        {
            Console.WriteLine($"Amount spent: {amountSpent}");
            Console.WriteLine($"Money in bank: {moneyInBank}");
        }










    }
}
