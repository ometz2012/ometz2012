using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL
{
   public interface ICompany
    {
        // Method that gets all Companies
        List<CompanyDTO> GetCompanies();

        //Get Company By Name Method
        //DTOCompanyNameToShow GetCompanyByName(string Name);

        //Get Company By ID Method
        CompanyDTO GetCompanyByID(int CompanyID);

        //Method that creates new Company
        bool CreateNewCompany(CompanyDTO CompanyNew);

        //This Method returns list of suppliers by their category
        List<CompanyWithCatgoryDTO> GetCompaniesWithCategories();
    }
}
