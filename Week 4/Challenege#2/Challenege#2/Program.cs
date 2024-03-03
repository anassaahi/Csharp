using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenege_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <members> members = new List <members> ();

            while (true)
            {
                Console.Clear();
                string choice = menu();
                if(choice == "1")
                {
                    members m = getInput();
                    members.Add (m);
                    returnMenu();
                }
                else if(choice == "2")
                {
                    int id = takeID();
                    members found = findMember(id, members);
                    double amount = takeAmount();
                    found.setpasay(amount);
                    returnMenu();

                }
                else if (choice == "3")
                {
                    int id = takeID();
                    members found = findMember(id, members);
                    int number = takeNum();
                    List<string> books = takeBooks(number);
                    found.modifybooks(books);
                    returnMenu();

                }
                else if (choice == "4")
                {
                    int id = takeID();
                    members found = findMember(id, members);
                    found.dispalymoney();
                    returnMenu();
                }
                else if (choice == "5")
                {
                    break;
                }


            }
        }

        static string menu()
        {
            Console.WriteLine("BOOK MANAGEMENT SYSTEM");
            Console.WriteLine("1. ENROLL MEMBER");
            Console.WriteLine("2. SET MONEY IN BANK");
            Console.WriteLine("3. BUY BOOKS");
            Console.WriteLine("4. Display MONEY DETAILS");
            Console.WriteLine("5. EXIT");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        static members getInput()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter ID: ");
            int ID = int.Parse(Console.ReadLine());

            return new members(name, ID);

        }

        static int takeID()
        {
            Console.Write("Enter ID: ");
            int ID = int.Parse(Console.ReadLine());
            return ID;
        }

        static double takeAmount()
        {
            Console.Write("Enter the amount: ");
            double money = double.Parse(Console.ReadLine());
            return money;
        }

        static members findMember(int ID, List <members> members)
        {
            members found = members.Find(member => member.MemberId == ID);
            return found;
        }

        static int takeNum()
        {
            Console.Write("Enter the number of books to Buy: ");
            return int.Parse(Console.ReadLine());
        }

        static List <string> takeBooks(int num)
        {
            List <string> books = new List<string>();
            for(int i=0; i<num; i++)
            {
                Console.WriteLine("Enter the book: ");
                books.Add(Console.ReadLine());
            }

            return books;
        }

        static void returnMenu()
        {
            Console.WriteLine();
            Console.Write("Enter any key...");
            Console.Read();

        }
    }
}
