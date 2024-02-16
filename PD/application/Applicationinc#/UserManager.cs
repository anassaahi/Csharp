using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Applicationinc_
{
    internal class UserManager
    {
        private string[] users;
        private string[] passwords;
        private string[] roles;
        private int userArrSize;
        private int usersCount;
        private int totalUsers;
        private string[] review;
        private int countReview;
        private int[] buyPrice;
        public UserManager(int userArrSize)
        {
            this.userArrSize = userArrSize;
            users = new string[userArrSize];
            passwords = new string[userArrSize];
            roles = new string[userArrSize];
            review = new string[userArrSize];
            buyPrice = new int[userArrSize];
        }

        public bool SignUp(string name, string password, string role)
        {
            for (int i = 0; i < usersCount; i++)
            {
                if (users[i] == name)
                {
                    Console.WriteLine("User already exists. Please choose a different username.");
                    return false;
                }
            }

            if (usersCount < userArrSize)
            {
                users[usersCount] = name;
                passwords[usersCount] = password;
                roles[usersCount] = role;
                usersCount++;
                totalUsers++;
                return true;
            }
            else
            {
                Console.WriteLine("User limit reached. Cannot sign up.");
                return false;
            }
        }

        public string SignIn(string name, string password, ref int userNumber)
        {
            for (int i = 0; i < usersCount; i++)
            {
                if (users[i] == name && passwords[i] == password)
                {
                    userNumber = i;
                    return roles[i];
                }
            }
            return "undefined";
        }
        public static void SaveRecordsToFile(UserManager userManager)
        {
            try
            {
                using (StreamWriter file = new StreamWriter("signup.txt"))
                {
                    for (int i = 0; i < userManager.usersCount; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(userManager.users[i]))
                        {
                            file.Write(userManager.users[i]);
                            file.Write('~');
                            file.Write(userManager.passwords[i]);
                            file.Write('~');
                            file.Write(userManager.roles[i]);
                            if (i != userManager.usersCount - 1)
                            {
                                file.Write('\n');
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"\t\t\t\t\tUnable to save records to signup.txt file. {ex.Message}");
            }
        }

        public static void LoadRecords(UserManager userManager)
        {
            userManager.usersCount = 0;
            string record = "";

            try
            {
                using (StreamReader file = new StreamReader("signup.txt"))
                {
                    while ((record = file.ReadLine()) != null)
                    {
                        userManager.users[userManager.usersCount] = GetField(record, 1);
                        userManager.passwords[userManager.usersCount] = GetField(record, 2);
                        userManager.roles[userManager.usersCount] = GetField(record, 3);
                        userManager.usersCount++;
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"\t\t\t\t\tUnable to open signup.txt file. {ex.Message}");
            }
        }

        private static string GetField(string record, int fieldNumber)
        {
            string[] fields = record.Split('~');
            if (fieldNumber > 0 && fieldNumber <= fields.Length)
            {
                return fields[fieldNumber - 1];
            }
            return string.Empty;
        }
        public void AddProducts(string[] products, int[] quantities, ref int addedProducts, int[] price, string[] review, ref int countReview)
        {
            string product;
            string size;
            int priceValue;
            int quantityValue;

            Console.Write("\t\t\t\t\tEnter the product you want to add: ");
            product = Console.ReadLine();
            products[addedProducts] = product;

            Console.Write("\t\t\t\t\tEnter the quantity of the product: ");
            string quantityInput = Console.ReadLine();
            while (!int.TryParse(quantityInput, out quantityValue))
            {
                Console.WriteLine("\t\t\t\t\tInvalid input!!");
                Console.Write("\t\t\t\t\tEnter the quantity of the product: ");
                quantityInput = Console.ReadLine();
            }
            quantities[addedProducts] = quantityValue;

            Console.Write("\t\t\t\t\tEnter the price of single item: ");
            string priceInput = Console.ReadLine();
            while (!int.TryParse(priceInput, out priceValue))
            {
                Console.WriteLine("\t\t\t\t\tInvalid input!!");
                Console.Write("\t\t\t\t\tEnter the price of the product: ");
                priceInput = Console.ReadLine();
            }
            price[addedProducts] = priceValue;

            Console.WriteLine("\t\t\t\t\tYou have successfully added the product.");
            addedProducts++;
        }
        public void RemoveProducts(string[] products, int[] quantities, ref int addedProducts, int[] price, string[] review, ref int countReview)
        {
            string numInput;
            int num;
            string product;

            Console.WriteLine("Products are: ");
            for (int i = 0; i < addedProducts; i++)
            {
                Console.WriteLine($"{i + 1}: {products[i],-10}");
            }

            Console.WriteLine("Enter the number to delete or press 0 to go back: ");
            numInput = Console.ReadLine();
            while (!int.TryParse(numInput, out num) || num < 0 || num > addedProducts)
            {
                Console.WriteLine("Invalid input!!");
                Console.WriteLine("Enter the number to delete or press 0 to go back: ");
                numInput = Console.ReadLine();
            }

            if (num != 0)
            {
                product = products[num - 1];
                for (int i = num - 1; i < addedProducts - 1; i++)
                {
                    products[i] = products[i + 1];
                    price[i] = price[i + 1];
                    quantities[i] = quantities[i + 1];
                }
                products[addedProducts - 1] = "";
                price[addedProducts - 1] = 0;
                quantities[addedProducts - 1] = 0;

                addedProducts--;
                Console.WriteLine("{0} removed", product);
            }
        }
        public void alluser(int totalusers, string[] users, string[] roles, ref int usersCount, string[] review, ref int countreview)
        {
            Console.WriteLine("Total number of users in your store: {0}", totalusers);
            Console.Write("{0,-20}{1,-20}\n", "Name", "Role");
            for (int i = 0; i < usersCount; i++)
            {
                Console.Write("{0,-20}{1,-20}\n", users[i], roles[i]);
            }
        }
        public void veiwproducts(int[] price, ref int usernumber, string[] products, int[] quantities, ref int addedproducts, string[] review, ref int countreview)
        {
            if (addedproducts != 0)
            {
                Console.Write("Total number of items entered: {0}", addedproducts);
                Console.Write("{0,-20}{1,-20}{2,-20}\n", "Item", "Price", "Quantity");

                for (int i = 0; i < addedproducts; i++)
                {
                    Console.Write("{0,-20}{1,-20}{2,-20}\n", products[i], price[i], quantities[i]);

                }
            }
            else
            {
                Console.WriteLine("NO products to show!! Admin has not added any product yet");
            }
        }
        public void buyproducts(int[] credit, ref int usernumber, string[] products, int[] quantities, ref int addedproducts, int totalusers, string[] users, string[] roles, ref int usersCount, int[] price, int discount, string[] review, ref int countreview, int[] buyprice, ref int totalbought, int[] boughtquantity, string[] boughtproducts)
        {
            string buy;
            string quan2 = "";
            int quan = 0;
            int dis;
            int leftcredit = 0;
            if (addedproducts != 0)
            {
                if (credit[usernumber] != 0)
                {

                    Console.WriteLine("Following is the list of the added items:");
                    Console.WriteLine("{0,-20}{1,-20}{2,-20}", "Item", "Quantity", "Price");
                    for (int i = 0; i < addedproducts; i++)
                    {
                        Console.WriteLine("{0,-20}{1,-20}{2,-20:C}", products[i], quantities[i], price[i]);
                    }

                    Console.Write("Enter the name of the product you want to buy: ");
                    buy = Console.ReadLine();
                    for (int i = 0; i < addedproducts; i++)
                    {
                        if (products[i] != buy || quantities[i] == 0)
                        {
                            continue;
                        }
                        else if (products[i] == buy && quantities[i] != 0)
                        {
                            Console.Write("Enter the quantity: ");
                            quan2 = Console.ReadLine();
                            while (true)
                            {
                                if (!validateint(quan2))
                                {

                                    Console.WriteLine("Invalid input!!");
                                    Thread.Sleep(1000);
                                    Console.Write("Enter the quantity: ");
                                    quan2 = Console.ReadLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            quan = int.Parse(quan2);
                            dis = discount / 100;
                            buyprice[i] = price[i] * quan - dis;

                            if (buyprice[i] <= credit[usernumber])
                            {
                                leftcredit = credit[usernumber] - buyprice[i];
                                Console.WriteLine("You have successfully bought the product for price: {0}", buyprice[i]);
                                Console.WriteLine("Total credit left: {0}", leftcredit);
                                quantities[i] = quantities[i] - quan;
                                boughtquantity[i] = quan;
                                boughtproducts[i] = buy;
                                credit[usernumber] = leftcredit;
                                totalbought++;
                                break;
                            }
                            else if (buyprice[i] > credit[usernumber])
                            {
                                Console.WriteLine("Sorry, your credit limit exceeded. Please recharge.");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You havent added the credit yet!! Please add your credit first");
                }
            }
            else
            {
                Console.WriteLine("The admin has not added any product yet!! SORRY");
            }
        }
        public void veiwreview(int[] price, ref int usernumber, string[] products, int[] quantities, ref int addedproducts, string[] review, ref int countreview)
        {

            if (countreview != 0)
            {
                Console.WriteLine("Reviews given to the store: {0}", countreview);
                for (int i = 0; i < countreview; i++)
                {
                    Console.WriteLine("Reviews given to the store: {0}", countreview);
                    if (review[i] != "")
                    {
                        Console.WriteLine($"{i + 1}: {review[i]}");
                    }
                    else
                    {
                        Console.WriteLine("There is no review given yet");
                    }
                }
            }
            else
            {
                Console.WriteLine("There is no review given yet");
            }
        }
        public bool validateint(string name)
        {
            bool check = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= '0' && name[i] <= '9')
                {
                    check = true;
                }
                else
                {
                    return false;
                }
            }
            return check;
        }


    }
}