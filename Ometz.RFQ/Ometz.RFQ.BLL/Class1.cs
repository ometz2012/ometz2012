using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ometz.RFQ.DAL;
using Ometz.RFQ.BLL.Model;

namespace Ometz.RFQ.BLL
{
    public class Class1
    {


        
    }

    public class DTOCompanyToShow : DTOCompany
    {
        public override string GetCompanyCategory()
        {
            int categoryID = this.CategoryID;
            Category category;
            using (var context = new RFQEntities())
            {
                category = (from cat in context.Categories
                            where cat.CategoryID == categoryID
                            select cat).First();

            }

            string categoryName = category.Type.ToString();
            return categoryName;


        }

        public override string GetCompanyType()
        {
            int typeID = this.CompanyTypeID;
            throw new NotImplementedException();
        }
    }

    // DTO USER TO SHOW BASED ON ABSTRACT CLASS DTO USER
    public class DTOUserToShow : DTOUser
    {
        private string userN;

        public DTOUserToShow(string userName)
        {
            this.userN = userName;
            User user = new User();
            using (var context = new RFQEntities())
            {
                user = (User)(from usr in context.Users.Include("Company")
                              where usr.UserName == userN
                              select usr).First();
            }

            if (user != null)
            {
                this.UserID = user.UserID;
                this.UserName = user.UserName;
                this.Password = user.Password;
                this.CompanyID = user.Company.CompanyID;
            }


        }


        public override bool PasswordValidation(string passwordEntered, string passwordDB)
        {
            bool check = false;

            if (passwordEntered == passwordDB)
            {
                check = true;
            }

            return check;
        }
    }

    // END ----DTO USER TO SHOW BASED ON ABSTRACT CLASS DTO USER




    public class BLLServices
    {

        //Get Company By ID Method
        public static DTOCompanyToShow GetCompanyByID(int CompanyID)
        {
            Company CompanySpecific = new Company();
            string path = "Category";
            string path1 = "CompanyType";

            using (var context = new RFQEntities())
            {
                CompanySpecific = (from comp in context.Companies.Include(path).Include(path1)
                                   where comp.CompanyID == CompanyID
                                   select comp).First();


            }

            DTOCompanyToShow CompanyToReturn = new DTOCompanyToShow();
            CompanyToReturn.CompanyID = CompanySpecific.CompanyID;
            CompanyToReturn.Name = CompanySpecific.Name;
            CompanyToReturn.CategoryID = CompanySpecific.Category.CategoryID;
            CompanyToReturn.CompanyTypeID = CompanySpecific.CompanyType.CompanyTypeID;



            return CompanyToReturn;
        }

        //Method that check if the user name exists in the DataBase
        public static bool CheckUserNameExists(string userName)
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
