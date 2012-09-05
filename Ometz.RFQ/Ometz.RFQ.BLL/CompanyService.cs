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
    public class CompanyService:ICompany
    {
        //Get Company By ID Method
        public CompanyDTO GetCompanyByID(int CompanyID)
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

            CompanyDTO CompanyToReturn = new CompanyDTO();
            CompanyToReturn.CompanyID = CompanySpecific.CompanyID;
            CompanyToReturn.Name = CompanySpecific.Name;
            CompanyToReturn.CategoryID = CompanySpecific.Category.CategoryID;
            CompanyToReturn.CompanyTypeID = CompanySpecific.CompanyType.CompanyTypeID;



            return CompanyToReturn;
        }

      
        //Method that creates new Company
        public bool CreateNewCompany(CompanyDTO CompanyNew)
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



        //Dory --- Method that gets all Companies to grid
        public List<CompanyDTO> GetCompanies()
        {
            List<CompanyDTO> CompanyList = new List<CompanyDTO>();
            string path = "Category";
            string path1 = "CompanyType";




            using (var context = new RFQEntities())
            {
                var results = (from comp in context.Companies.Include(path).Include(path1)
                               select new
                               {
                                   CompanyID = comp.CompanyID,
                                   CompanyName = comp.Name,
                                   CategoryID = comp.Category.CategoryID,
                                   CompanyCategory = comp.Category.Type,
                                   CompanyTypeID = comp.CompanyType.CompanyTypeID,
                                   CompanyType = comp.CompanyType.Type
                               }
                                  ).ToList();

                if (results.Count > 0)
                {
                    foreach (var item in results)
                    {
                        CompanyDTO CompanyRow = new CompanyDTO();
                        CompanyRow.CompanyID = item.CompanyID;
                        CompanyRow.Name = item.CompanyName;
                        CompanyRow.CompanyTypeID = item.CompanyTypeID;
                        CompanyRow.CategoryID = item.CategoryID;
                        CompanyList.Add(CompanyRow);

                    }

                }
            }


            return CompanyList;
        }



        //Dory -- Get Company By Name Method
        //public DTOCompanyNameToShow GetCompanyByName(string Name)
        //{
        //    Company CompanySpecific = new Company();
        //    string path = "Category";
        //    string path1 = "CompanyType";

        //    using (var context = new RFQEntities())
        //    {

        //        CompanySpecific = (from comp in context.Companies
        //                           where comp.Name.Contains(txtSupplierSearch.Text)
        //                           orderby e.CustomerID
        //                           select comp).First();

        //        //CompanySpecific = (from e in context.Name
        //        //                   where e.FirstName.Contains(txtSupplierSearch.Text) //|| e.LastName.Contains(text)
        //        //                   orderby e.CustomerID
        //        //                   select e).Skip(toSkip).Take(toTake).ToList();


        //    }

        //    DTOCompanyNameToShow CompanyToReturn = new DTOCompanyNameToShow();

        //    CompanyToReturn.Name = CompanySpecific.Name;
        //    CompanyToReturn.CategoryID = CompanySpecific.Category.CategoryID;
        //    CompanyToReturn.CompanyTypeID = CompanySpecific.CompanyType.CompanyTypeID;



        //    return CompanyToReturn;
        //}


       







    }
}
