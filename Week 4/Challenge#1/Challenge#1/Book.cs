using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class Book
    {
        public string Titles;
        public string[] authours = new string[4];
        public string publiser;
        public string isbn;
        public double price;
        public int stock;
        public int numAuthors;

        public Book(string title, string[] authors, string publisher, string isbn, double price, int stock)
        {
            this.Titles = title;
            this.authours = authors;
            this.publiser = publisher;
            this.isbn = isbn;
            this.price = price;
            this.stock = stock;
            this.numAuthors = authors.Length;
        }
        
        public void showTitle()
        {
            Console.WriteLine("The title of the book is : " + Titles);
        }

        public void setTitle(string title)
        {
            this.Titles = title;
        }

        public bool isTitle(string title)
        {
            if (this.Titles == title)
            {
                return true;
            }
            return false;
        }

        public void updateCopies(int num)
        {
            stock += num;
        }
        

        

        public double getPrice()
        {
            return price;
        }

        public void getAuthors()
        {
            Console.WriteLine("The authors of the book are: ");
            for(int i=0; i<authours.Length; i++)
            {
                Console.WriteLine(authours[i]);
            }
        }

   


    }
}
