using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange3
{
    internal class Muser
    {
       public string Username;
       public string Password;
       public string Role ;
        public Muser(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine();
        }
        public bool ValidatePassword(string enteredPassword)
        {
            return Password == enteredPassword;
        }
    }
}
