using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challange3
{
    internal class Program
    {
        static List<Muser> users = new List<Muser>();
        static string filePath = "users.txt";
        static void Main(string[] args)
        {
            LoadUsersFromFile();

            int choice;
            while (true)
            {
                {
                    Console.WriteLine("User Authentication System Menu:");
                    Console.WriteLine("1. Sign Up");
                    Console.WriteLine("2. Sign In");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");
                    while (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.Write("Enter your choice: ");
                    }

                    switch (choice)
                    {
                        case 1:
                            SignUp();
                            break;
                        case 2:
                            SignIn();
                            break;
                        case 0:
                            Console.WriteLine("Exiting the program.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }

                } while (choice != 0) ;
            }

        }
        static void LoadUsersFromFile()
        {
            {
                try
                {
                    using (StreamReader file = new StreamReader(filePath))
                    {
                        while (!file.EndOfStream)
                        {
                            string record = file.ReadLine();
                            string username = GetField(record, 1);
                            string password = GetField(record, 2);
                            string role = GetField(record, 3);

                            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(role))
                            {
                                Muser user = new Muser(username, password, role);
                                users.Add(user);
                            }
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Unable to open {filePath} file. {ex.Message}");
                }
            }
            }

        static void SaveRecordsToFile(List<Muser> users, string filePath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    foreach (var user in users)
                    {
                        file.Write(user.Username);
                        file.Write('~');
                        file.Write(user.Password);
                        file.Write('~');
                        file.Write(user.Role);
                        file.WriteLine(); 
                    }
                }

                Console.WriteLine($"User records saved to {filePath} successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Unable to save user records to {filePath}. {ex.Message}");
            }
        }
    


    static void SignUp()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter role: ");
            string role = Console.ReadLine();

            Muser newUser = new Muser(username, password, role);
            users.Add(newUser);

            SaveRecordsToFile(users, filePath);

            Console.WriteLine("User signed up successfully!\n");
        }

        static void SignIn()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Muser user = null;
            foreach (var u in users)
            {
                if (u != null && u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.ValidatePassword(password))
                {
                    user = u;
                    break;
                }
            }
            if (user != null)
            {
                Console.WriteLine("Sign in successful!");
                user.DisplayUserInfo();
            }
            else
            {
                Console.WriteLine("Invalid username or password. Sign in failed.");
            }
        }
        static string GetField(string record, int fieldNumber)
        {
            string[] fields = record.Split('~');
            if (fieldNumber > 0 && fieldNumber <= fields.Length)
            {
                return fields[fieldNumber - 1];
            }
            return string.Empty;
        }
    }
}
