using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6test
{
    internal class BookBL
    {
        private String BookName;
        private float Price;
        private float Quantity;
        private List<AuthorBL> AuthorList;  
        public void SetAutor(List<AuthorBL> AuthorList)
        {
            this.AuthorList = AuthorList;
        }
        public bool SetBookName(String name)
        {
            if (name != null)
            {
                this.BookName = name;
                return true;

            }
            else
            {
                return false;
            }
        }
        public string GetName(string name)
        {
            return this.BookName;
        }
        public void SetAuthor(List<AuthorBL> authors)
        {
           
            
                this.AuthorList = authors;
            
            
        }

        public List<AuthorBL> GetAuthor()
        {
            return this.AuthorList;
        }

        public bool SetPrice(float price)
        {
            if (price >= 0)
            {
                this.Price = price;
                return true;
            }
            else
            {
                return false;
            }
        }
        public float GetPrice()
        {
            return this.Price;
        }
        public bool SetQuantity(float quantity)
        {
            if (quantity >= 0)
            {
                this.Quantity = quantity;
                return true;
            }
            else
            {
                return false;
            }
        }
        public float GetQuantity()
        {
            return this.Quantity;
        }
        public void DisplayAttributes()
        {
            Console.WriteLine("Book Name: " + BookName);
            foreach(AuthorBL a in AuthorList) {
                Console.WriteLine("Author: " + a.GetName());

            }
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);


        }
    }
}
