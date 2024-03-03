using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange2
{
    internal class Class1
    {
        public int ID;
        public string Name ;
        public decimal Price ;
        public string Category ;
        public string BrandName ;
        public string Country ;

        public Class1(int id, string name, decimal price, string category, string brandName, string country)
        {
            ID = id;
            Name = name;
            Price = price;
            Category = category;
            BrandName = brandName;
            Country = country;
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Brand Name: {BrandName}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine();
        }
    }
}
