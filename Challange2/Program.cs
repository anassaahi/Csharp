using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange2
{
    internal class Program
    {
        static List<Class1> products = new List<Class1>();

        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Products Management System Menu:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Show Products");
                Console.WriteLine("3. Total Store Worth");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            ShowProducts();
                            break;
                        case 3:
                            CalculateTotalStoreWorth();
                            break;
                        case 0:
                            Console.WriteLine("Exiting the program.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                Console.WriteLine();
            }
        }
        static void AddProduct()
        {
            Console.Write("Enter product ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter product price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter product category: ");
            string category = Console.ReadLine();

            Console.Write("Enter product brand name: ");
            string brandName = Console.ReadLine();

            Console.Write("Enter product country: ");
            string country = Console.ReadLine();
            Class1 newProduct = new Class1(id, name, price, category, brandName, country);

            products.Add(newProduct);

            Console.WriteLine("Product added successfully!\n");
        }

        static void ShowProducts()
        {
            Console.WriteLine("List of Products:");
            foreach (var product in products)
            {
                product.DisplayProductInfo();
            }
        }

        static void CalculateTotalStoreWorth()
        {
            decimal totalStoreWorth = 0;
            foreach (var product in products)
            {
                totalStoreWorth += product.Price;
            }

            Console.WriteLine($"Total Store Worth: {totalStoreWorth}\n");
        }
    }
}

