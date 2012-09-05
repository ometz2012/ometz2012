using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ometz.RFQ.DAL;
using System.Transactions;
using System.Data;



namespace Ometz.RFQ.Authentication
{
    public class UserService : IUserService
    {
        //Method that checks if the user name exists in the DataBase
        public bool CheckUserNameExists(string userName)
        {
            bool check = false;

            using (var context = new RFQEntities())
            {
                var UserSearched = (from usr in context.Users
                            where usr.UserName == userName
                            select usr);

                if (UserSearched != null)
                    check = true;
                else
                    return check;
            }

             return check;
        }



        //Method that gets user information
        public UserDTO GetUser(string userName)
        {
            string userN = "";
            userN = userName;
            UserDTO UserLogedIn = new UserDTO();
            //User user = new User();
            User UserDb=new User();

            using (var context = new RFQEntities())
            {
                 var result = (from usr in context.Users.Include("Company")
                              where usr.UserName == userN
                              select usr).First();
                if (result!=null)
                 UserDb = (User)result;
            }

            if (UserDb != null)
            {
                UserLogedIn.UserID = UserDb.UserID;
                UserLogedIn.UserName = UserDb.UserName;
                UserLogedIn.Password = UserDb.Password;
                UserLogedIn.CompanyID = UserDb.Company.CompanyID;
                UserLogedIn.CompanyTypeID = UserDb.Company.CompanyTypeID;
            }

            return UserLogedIn;

        }



        //Method that verifies if the password is correct
        public bool PasswordValidation(string passwordEntered, string passwordDB)
        {
            bool check = false;

            if (passwordEntered == passwordDB)
            {
                check = true;
            }

            return check;
        }

    
       



    }
}
