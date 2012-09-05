using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ometz.RFQ.DAL;
using Ometz.RFQ.BLL.Model;
using System.Transactions;
using System.Data;

namespace Ometz.RFQ.BLL
{
    public class BLLServices : IBLLServices
    {

        //Method that checks if the user name exists in the DataBase
        public bool CheckUserNameExists(string userName)
        {
            bool check = false;

            List<User> userList = new List<User>();
            using (var context = new RFQEntities())
            {
                userList = (from usr in context.Users.Include("Company")
                            where usr.UserName == userName
                            select usr).ToList();
            }

            if (userList.Count > 0)
                check = true;

            return check;
        }

    }

  }

