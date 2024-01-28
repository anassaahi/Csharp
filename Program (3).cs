using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signupsignin
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string option;
            while (true)
            {
                Console.WriteLine("Enter the option number from below:");
                Console.WriteLine("1.SignUP");
                Console.WriteLine("2.SignIN");
                Console.WriteLine("3.Exit");
                Console.Write("Option>:");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        signupf();
                        break;
                    case "2":
                        signinf();
                        break;
                    case "3":

                        break;

                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }

            }
        }
        static signup signupf() { 
            signup s  = new signup();
            Console.WriteLine("Enter your name: ");
            s.name = Console.ReadLine();
            string username = s.name;
            if (UserExists(username))
            {
                Console.WriteLine("Username already exists. Please choose a different one.");
                return ;
            }
            Console.WriteLine("Enter your password: ");
            s.password = Console.ReadLine();
            Console.WriteLine("Enter your role: ");
            s.role = Console.ReadLine();
            return s;
        
        }
        static signup signinf()
        {
            signup s = new signup();
            Console.WriteLine("Enter your name:");
            s.name = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            s.password = Console.ReadLine();
            return s;

        }
        static bool UserExists(string username)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Username == username)
                {
                    return true;
                }
            }
            return false;

        }
        static int FindUserIndex(string username, string password)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
