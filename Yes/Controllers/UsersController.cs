using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCatalog.Models;
using Yes.Controllers;
namespace Yes.Controllers
{
    class UsersController
    {
        public bool IsUserValid(string email, string password)
        {
            using (var context = new BookCatalogContext())
            {
                var userExists = context.User.Any(u => u.Email.Equals(email) && u.Password.Equals(password));
                return userExists;
            }
        }
        //viy izliza i tuka kolko testa sa minali za daden method
        //da
        //super e da izliza
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
        //moje
    }
}
