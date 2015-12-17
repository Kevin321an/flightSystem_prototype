using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// The user account class
    /// </summary>   
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
        /// <summary>
        ///  View
        /// </summary>
        /// <returns></returns>
        public Account ViewAccount()
        {
            return this;
        }
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="account"></param>
        public void DeleteAccount(Account account)
        {
            
        }
        /// <summary>
        /// update
        /// </summary>
        /// <param name="account"></param>
        public void UpdateAccount(Account account)
        {
           
        }
    }
}
