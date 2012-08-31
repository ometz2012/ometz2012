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

    public class DTOCompanyToShow : DTOCompany
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
    }// END ----DTO USER TO SHOW BASED ON ABSTRACT CLASS DTO USER


    //  DTO ADDRESS TO SHOW
    public class DTOAddressToShow : DTOAddress
    {

    }

    //----DTO--Quote--------------
    public class DTOQuoteToShow : DTOQuote
    {

    }

    //------Quote--Detail ---   
    public class DTOQuoteDetailToCreate : DTOQuoteDetail
    {

    }

    public class DTOQuoteDetailToShow : DTOQuoteDetail
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }

    //DTO Participant

    public class DTOParticipantToShow : DTOQuoteParticipant
    {

    }






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

        //Method that checks if the user name exists in the DataBase
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

        //Method that creates new Company
        public static bool CreateNewCompany(DTOCompanyToShow CompanyNew)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {
                    Company CompanyIn = new Company();
                    //Data transfer to the new company
                    CompanyIn.Name = CompanyNew.Name;


                    using (var context = new RFQEntities())
                    {
                        //Finding references for the Foreign Keys
                        Category existingCategory = context.Categories.Single(p => p.CategoryID == CompanyNew.CategoryID);
                        CompanyType existingCompanyType = context.CompanyTypes.Single(p => p.CompanyTypeID == CompanyNew.CompanyTypeID);
                        //Adding refernces
                        CompanyIn.Category = existingCategory;
                        CompanyIn.CompanyType = existingCompanyType;

                        if (CompanyIn.EntityState == EntityState.Detached)
                        {
                            context.Companies.AddObject(CompanyIn);
                        }

                        context.SaveChanges();

                    }

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }

        }//End of Create New Company Method

        //Method that creates new Address for specific Company
        public static bool CreateNewAddress(DTOAddressToShow AddressNew)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {
                    Address AddressIn = new Address();
                    //Data transfer to the the AddressIn
                    AddressIn.Address1 = AddressNew.Address1;
                    AddressIn.Address2 = AddressNew.Address2;
                    AddressIn.City = AddressNew.City;
                    AddressIn.State = AddressNew.State;
                    AddressIn.PostalCode = AddressNew.PostalCode;
                    AddressIn.Country = AddressNew.Country;
                    AddressIn.Phone = AddressNew.Phone;
                    AddressIn.Fax = AddressNew.Fax;
                    AddressIn.Email = AddressNew.Email;

                    using (var context = new RFQEntities())
                    {
                        //Finding references for the Foreign Keys
                        Company existingCompany = context.Companies.Single(p => p.CompanyID == AddressNew.CompanyID);

                        //Adding refernces
                        AddressIn.Company = existingCompany;


                        if (AddressIn.EntityState == EntityState.Detached)
                        {
                            context.Addresses.AddObject(AddressIn);
                        }

                        context.SaveChanges();

                    }

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }

            return check;
        }


        //Method that gets all the Addresses by CompanyID
        public static List<DTOAddressToShow> GetAddressesByCompanyID(int companyID)
        {
            List<DTOAddressToShow> AddressesListOut = new List<DTOAddressToShow>();
            List<Address> AddressListDB = new List<Address>();

            using (var context = new RFQEntities())
            {
                AddressListDB = (from adr in context.Addresses.Include("Company")
                                 where adr.Company.CompanyID == companyID
                                 select adr).ToList();
            }

            if (AddressListDB.Count > 0)
            {
                foreach (var adr in AddressListDB)
                {
                    DTOAddressToShow AddressRow = new DTOAddressToShow();
                    AddressRow.AddressID = adr.AddressID;
                    AddressRow.CompanyID = companyID;
                    AddressRow.Address1 = adr.Address1;
                    AddressRow.Address2 = adr.Address2;
                    AddressRow.City = adr.City;
                    AddressRow.State = adr.State;
                    AddressRow.PostalCode = adr.PostalCode;
                    AddressRow.Country = adr.Country;
                    AddressRow.Phone = adr.Phone;
                    AddressRow.Fax = adr.Fax;
                    AddressRow.Email = adr.Email;

                    AddressesListOut.Add(AddressRow);

                }
            }

            return AddressesListOut;
        }


        //Method that creates new Quotation 
        public static bool CreateNewQuoation(DTOQuoteToShow QuoteNew)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {
                    Quote QuoteIn = new Quote();
                    //Data transfer to the the AddressIn
                    QuoteIn.StartDate = QuoteNew.StartDate;
                    QuoteIn.EndDate = QuoteNew.EndDate;

                    using (var context = new RFQEntities())
                    {
                        //Finding references for the Foreign Keys
                        Company existingCompany = context.Companies.Single(q => q.CompanyID == QuoteNew.CompanyID);

                        //Adding refernces
                        QuoteIn.Company = existingCompany;


                        if (QuoteIn.EntityState == EntityState.Detached)
                        {
                            context.Quotes.AddObject(QuoteIn);
                        }

                        context.SaveChanges();

                    }

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }

        }//End of the method that creates new quotation


        //Method that adds new details row to the QuoteDetail
        public static bool CreateNewQuoteDetail(DTOQuoteDetailToCreate QuoteDetailNew)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {
                    QuoteDetail QuoteDetailIn = new QuoteDetail();
                    //Data transfer to the object that will be added to the DB
                    QuoteDetailIn.Text = QuoteDetailNew.Text;
                    QuoteDetailIn.Value = QuoteDetailNew.Value;

                    using (var context = new RFQEntities())
                    {
                        //Finding references for the Foreign Keys
                        Quote existingQuote = context.Quotes.Single(qd => qd.QuoteID == QuoteDetailNew.QuoteID);

                        //Adding refernces
                        QuoteDetailIn.Quote = existingQuote;


                        if (QuoteDetailIn.EntityState == EntityState.Detached)
                        {
                            context.QuoteDetails.AddObject(QuoteDetailIn);
                        }

                        context.SaveChanges();

                    }

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }

        }

        //Method that gets all the quotes by companyID 
        //Arranges them from the new to the old by QuoteID
        //And presents them with their details
        //Quotes with no details will show "No Details" and Value "0"
        public static List<DTOQuoteDetailToShow> GetQuoteDetail(int CompanyID)
        {
            List<DTOQuoteDetailToShow> ListofQuoteDetails = new List<DTOQuoteDetailToShow>();
            using (var context = new RFQEntities())
            {
                var results = (from quote in context.Quotes
                               join quoteDet in context.QuoteDetails
                               on quote.QuoteID equals quoteDet.Quote.QuoteID into qq
                               orderby quote.QuoteID descending
                               from quoteDet in qq.DefaultIfEmpty()
                               select new
                               {
                                   QuoteID = quote.QuoteID,
                                   StartDate = quote.StartDate,
                                   EndDate = quote.EndDate,
                                   QuoteDetails = quoteDet.Text == null ? "(No Details)" : quoteDet.Text,
                                   Value = quoteDet.Value == null ? 0m : quoteDet.Value
                               }).ToList();
                foreach (var item in results)
                {
                    DTOQuoteDetailToShow row = new DTOQuoteDetailToShow();
                    row.QuoteID = item.QuoteID;
                    row.StartDate = item.StartDate;
                    row.EndDate = item.EndDate;
                    row.Text = item.QuoteDetails;
                    row.Value = item.Value;
                    ListofQuoteDetails.Add(row);

                }
            }



            return ListofQuoteDetails;
        }


        //Method that adds list of suppliers (Participants) to the quotaion Suppliers=Companies
        // Method takes list of integers with companyIDs and the quotation ID
        public static bool AddSuppliersToQuotation(List<DTOParticipantToShow> particpantsList)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {

                    using (var context = new RFQEntities())
                    {


                        foreach (var item in particpantsList)
                        {
                            QuoteParticipant QuoteParticipantIn = new QuoteParticipant();

                            //Finding references for the Foreign Keys - QUOTE
                            Quote existingQuote = context.Quotes.Single(q => q.QuoteID == item.QuoteID);

                            //retriving references for the Foreign Key- Company
                            Company existingCompany = context.Companies.Single(comp => comp.CompanyID == item.CompanyID);


                            List<QuoteParticipant> existParticipant = (from p in context.QuoteParticipants
                                                                       where p.Quote.QuoteID == item.QuoteID &&
                                                                       p.Company.CompanyID == item.CompanyID
                                                                       select p).ToList();
                            if (existParticipant.Count > 0)
                            {

                            }
                            else
                            {
                                //Adding refernces
                                QuoteParticipantIn.Company = existingCompany;
                                QuoteParticipantIn.Quote = existingQuote;


                                if (QuoteParticipantIn.EntityState == EntityState.Detached)
                                {
                                    context.QuoteParticipants.AddObject(QuoteParticipantIn);
                                }

                                context.SaveChanges();

                            }



                        }//end foreach

                    }//end try

                }
                catch (DataExistis de)
                {

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }
        }


        //Method that removes suppliers (Participants) from quotation
        //Method takes list of integers with ParticipantId
        public static bool RemoveSuppliersFromQuotation(List<DTOParticipantToShow> participantIDList)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {

                    using (var context = new RFQEntities())
                    {

                        foreach (var item in participantIDList)
                        {


                            QuoteParticipant QuoteParticipantOut = (from part in context.QuoteParticipants
                                                                    where part.QuoteParticipantID == item.QuoteParticipantID
                                                                    select part).First();


                            if (QuoteParticipantOut != null)
                            {
                                context.DeleteObject(QuoteParticipantOut);
                                context.SaveChanges();

                            }


                        }//foreach

                    }//using

                }//try

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }//transaction

        }//method








    }//end of BLL Services Class



    //Exceptions
    #region Exceptions
    public class DataExistis : Exception
    {

    }



    #endregion





    public class DTOShowQuoteInfo : DTOQuote
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

