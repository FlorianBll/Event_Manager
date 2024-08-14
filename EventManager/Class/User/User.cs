using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    /// <summary>
    /// Class representing a User instance. 
    /// </summary>
    /// <remarks>
    /// The user is defined by his firstname, lastname, sector (location where his working for), email and password.
    /// </remarks>
    public class User
    {
        #region variables

        private string _firstName;
        private string _lastName;
        private string _sector;
        private string _email;
        private string _password;

        #endregion

        #region get/set

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string sector { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        #endregion

        #region constructor
        public User()
        {
            firstName = "";
            lastName = "";
            sector = "";
            email = "";
            password = "";
        }

        public User(string firstName, string lastName, string sector, string email, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sector = sector;
            this.email = email;
            this.password = password;
        }

        #endregion

        /// <summary>
        /// Display the user information in the console. Using for test case.
        /// </summary>
        public void UserDisplay()
        {
            Console.WriteLine($"User firstname : {this.firstName}; Lastname : {this.lastName}; Sector : {this.sector}; Email : {this.email}; PAssword : {this.password}");
        }
    }
}
