using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCatalog.Models;
using Yes.Controllers;
namespace Yes.Controllers
{
    /// <summary>
    /// Controller responsible for handling user-related actions.
    /// </summary>
    class UsersController
    {
        /// <summary>
        /// Checks if the provided user credentials (email and password) are valid.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>True if the user exists and the password matches; otherwise, false.</returns>
        public bool IsUserValid(string email, string password)
        {
            using (var context = new BookCatalogContext())
            {
                var userExists = context.User.Any(u => u.Email.Equals(email) && u.Password.Equals(password));
                return userExists;
            }
        }

        /// <summary>
        /// Retrieves the username associated with the given email address.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <returns>The username associated with the email address; an empty string if no user found.</returns>
        public string GetUserNameByEmail(string email)
        {
            try
            {
                using (var context = new BookCatalogContext())
                {
                    var user = context.User.FirstOrDefault(u => u.Email == email);
                    if (user == null)
                    {
                        return "";
                    }
                    else
                    {

                        return user.UserName;
                    }
                    
                }
            }
            catch (ArgumentException ex)
            {
                return ex.Message;
            }

        }
    }
}
