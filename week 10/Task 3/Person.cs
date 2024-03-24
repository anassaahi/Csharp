using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_3
{
    internal class Person
    {
        private string name;
        private string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    public string GetName()
        {
            return name;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string ToString()
        {
            String format = $"Person[name="+name+"address="+address+"]";
            return format;
        }
    }
}
