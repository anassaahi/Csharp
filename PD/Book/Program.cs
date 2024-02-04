using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();

            do
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All the Books information");
                Console.WriteLine("3. Get the Author details of a specific book");
                Console.WriteLine("4. Sell Copies of a Specific Book");
                Console.WriteLine("5. Restock a Specific Book");
                Console.WriteLine("6. See the count of the Books present in your bookList");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Publication Year: ");
                        int publicationYear = int.Parse(Console.ReadLine());
                        Console.Write("Enter Price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter Quantity in Stock: ");
                        int quantityInStock = int.Parse(Console.ReadLine());

                        Book newBook = new Book(title, author, publicationYear, price, quantityInStock);
                        bookList.Add(newBook);
                        Console.WriteLine("Book added successfully!");
                        break;

                    case 2:
                        
                        foreach (var book in bookList)
                        {
                            Console.WriteLine(book.BookDetails());
                        }
                        break;

                    case 3:
                        
                        Console.Write("Enter Title of the book: ");
                        string searchTitle = Console.ReadLine();
                        Book foundBook = bookList.Find(book => book.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));

                        if (foundBook != null)
                        {
                            Console.WriteLine(foundBook.GetAuthor());
                        }
                        else
                        {
                            Console.WriteLine($"Book with title '{searchTitle}' not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Title of the book: ");
                        string sellTitle = Console.ReadLine();
                        Book sellBook = bookList.Find(book => book.Title.Equals(sellTitle, StringComparison.OrdinalIgnoreCase));

                        if (sellBook != null)
                        {
                            Console.Write("Enter the number of copies to sell: ");
                            int numberOfCopiesToSell = int.Parse(Console.ReadLine());
                            sellBook.SellCopies(numberOfCopiesToSell);
                        }
                        else
                        {
                            Console.WriteLine($"Book with title '{sellTitle}' not found.");
                        }
                        break;

                    case 5:

                        Console.Write("Enter Title of the book: ");
                        string restockTitle = Console.ReadLine();
                        Book restockBook = bookList.Find(book => book.Title.Equals(restockTitle, StringComparison.OrdinalIgnoreCase));

                        if (restockBook != null)
                        {
                            Console.Write("Enter the number of copies to restock: ");
                            int numberOfCopiesToRestock = int.Parse(Console.ReadLine());
                            restockBook.Restock(numberOfCopiesToRestock);
                        }
                        else
                        {
                            Console.WriteLine($"Book with title '{restockTitle}' not found.");
                        }
                        break;

                    case 6:

                        Console.WriteLine($"Total Books in the list: {bookList.Count}");
                        break;

                    case 7:

                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

            } while (true);
        }
    }
    }

