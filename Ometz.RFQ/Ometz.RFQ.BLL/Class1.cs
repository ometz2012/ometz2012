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
    }
}
