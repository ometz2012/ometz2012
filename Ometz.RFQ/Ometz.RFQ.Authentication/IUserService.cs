using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.Authentication
{
    public interface IUserService
    {
        //Method that checks if the user name exists in the DataBase
        bool CheckUserNameExists(string userName);

        //Method that gets user information
        UserDTO GetUser(string userName);


        //Method that verifies if the password is correct
        bool PasswordValidation(string userNamein, string userNameDB);

        ////Method that starts next application - Buyer or Supplier
        //void ActivateApplication(UserDTO user);


    }
}
