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
    public class Class1
    {



    }

    public class CompanyDTO : CompanyBase
    {
        //public override string GetCompanyCategory()
        //{
        //    int categoryID = this.CategoryID;
        //    Category category;
        //    using (var context = new RFQEntities())
        //    {
        //        category = (from cat in context.Categories
        //                    where cat.CategoryID == categoryID
        //                    select cat).First();

        //    }

        //    string categoryName = category.Type.ToString();
        //    return categoryName;


        //}

    }

    public class CompanyNameDTO : CompanyBase
    {
        

    }

    // DTO USER TO SHOW BASED ON ABSTRACT CLASS DTO USER
    public class UserDTO : UserBase
    {
        private string userN;

        public UserDTO(string userName)
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
    }// END ----DTO USER TO SHOW BASED ON ABSTRACT CLASS DTO USER


    //  DTO ADDRESS TO SHOW
    public class AddressDTO : AddressBase
    {

    }

    //----DTO--Quote--------------
   /* public class DTOQuoteToShow : DTOQuote
    {

    }*/

    //------Quote--Detail ---   
    public class QuoteDetailToCreateDTO : QuoteDetailBase
    {

    }

    public class QuoteDetailDTO : QuoteDetailBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }

    //DTO Participant

    public class ParticipantDTO : QuoteParticipantBase
    {

    }




    



   



    //Exceptions
    #region Exceptions
    public class DataExistis : Exception
    {

    }



    #endregion





    public class QuoteInfoDTO : QuoteBase
    {
        // public override DTOQuote;


        /* using (var context = new RFQEntities())
         {
             var quotes = (from quote in context.Quotes
                               select quote).ToList();
                

         DTOQuote quotesToReturn;
       //  quotesToReturn.QuoteID = quotes[0].QuoteID;
         }
    /*  using (var context = new EntityFrameworkEntities())
         {
             var result = (from c in context.Customers
                           select c).ToList();
             dgvCustomer.DataSource = result;*/



    }
}

