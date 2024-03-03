using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AuthorBL> Authors =  new List<AuthorBL>();
            AuthorBL author = new AuthorBL();
            author.SetGender('M');
            author.SetName("anas");
            author.SetEmail("anas@gmail.com");

            Authors.Add(author);

            BookBL book = new BookBL();
            book.SetBookName("aansas kii kitab");
            book.SetAuthor(Authors);
            book.SetQuantity(1);
            book.SetPrice(1000);
            book.DisplayAttributes();
            Console.ReadKey();
        }
    }
}
