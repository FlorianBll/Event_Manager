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
        #region get/set

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sector { get; set; }
        public string Email { get; set; }
        public string EncryptedPassword { get; set; }

        #endregion

        #region constructor
        public User()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Sector = string.Empty;
            Email = string.Empty;
            EncryptedPassword = string.Empty;
        }

        public User(string firstName, string lastName, string sector, string email, string encryptedPassword)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sector = sector;
            this.Email = email;
            this.EncryptedPassword = encryptedPassword;
        }

        #endregion

        /// <summary>
        /// Display the user information in the console. Using for test case.
        /// </summary>
        public void UserDisplay()
        {
            Console.WriteLine($"User firstname : {this.FirstName}; Lastname : {this.LastName}; Sector : {this.Sector}; Email : {this.Email}");
        }
    }
}
