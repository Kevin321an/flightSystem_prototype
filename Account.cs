using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class Account
    {
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private int lastName;

        public int LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Account()
        {
            
        }

        public Account ViewAccount()
        {
            return this;
        }

        public void DeleteAccount(Account account)
        {
            
        }

        public void UpdateAccount(Account account)
        {
           
        }
    }
}
