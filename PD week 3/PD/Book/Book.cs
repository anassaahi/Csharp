using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        public string Title;
        public string Author ;
        public int PublicationYear ;
        public double Price ;
        public int QuantityInStock;
        public Book(string title, string author, int publicationYear, double price, int quantityInStock)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Price = price;
            QuantityInStock = quantityInStock;
        }
        public string GetTitle()
        {
            return $"Title: {Title}";
        }

        public string GetAuthor()
        {
            return $"Author: {Author}";
        }

        public string GetPublicationYear()
        {
            return $"Publication Year: {PublicationYear}";
        }

        public string GetPrice()
        {
            return $"Price: {Price}";
        }

        public void SellCopies(int numberOfCopies)
        {
            if (numberOfCopies <= QuantityInStock)
            {
                QuantityInStock -= numberOfCopies;
                Console.WriteLine($"{numberOfCopies} copies sold. Remaining in stock: {QuantityInStock}");
            }
            else
            {
                Console.WriteLine($"Error: Not enough copies in stock. Available: {QuantityInStock}");
            }
        }

        public void Restock(int additionalCopies)
        {
            QuantityInStock += additionalCopies;
            Console.WriteLine($"{additionalCopies} copies added to stock. Total in stock: {QuantityInStock}");
        }

        public string BookDetails()
        {
            return $"{GetTitle()}, {GetAuthor()}, {GetPublicationYear()}, {GetPrice()}, In Stock: {QuantityInStock}";
        }
    }
}
