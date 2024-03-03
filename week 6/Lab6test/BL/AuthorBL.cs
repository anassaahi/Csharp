using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6test
{
    internal class AuthorBL
    {
        private string Name;
        private string Email;
        private char Gender;
        public AuthorBL()
        {

        }
        public bool SetName(string name) { 
            if (name != " ")
            {
                this.Name = name;
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public string GetName()
        {
            return this.Name;
        }
        public bool SetEmail(string email)
        {
            if (email != " ")
            {
                this.Email = email;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetEmail(string email)
        {
            return this.Email;
        }
        public char GetGender()
        {
            return this.Gender;
        }
        public bool SetGender(char gender)
        {
            if (gender != 'M'||gender != 'F')
            {
                this.Gender = gender;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
