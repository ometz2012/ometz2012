using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL
{
    public interface IBLLServices
    {
        // Method that gets all Companies
        List<DTOAllCompaniesToShow> GetAddressesByCompanyID(int companyID);
        
     //Get Company By ID Method
         DTOCompanyToShow GetCompanyByID(int CompanyID);

         //Method that checks if the user name exists in the DataBase
         bool CheckUserNameExists(string userName);

        //Method that creates new Company
         bool CreateNewCompany(DTOCompanyToShow CompanyNew);

          //Method that creates new Address for specific Company
        bool CreateNewAddress(DTOAddressToShow AddressNew);

        //Method that gets all the Addresses by CompanyID
       List<DTOAddressToShow> GetAddressesByCompanyID(int companyID);

         //Method that creates new Quotation 
       bool CreateNewQuoation(DTOQuoteToShow QuoteNew);

           //Method that adds new details row to the QuoteDetail
       bool CreateNewQuoteDetail(DTOQuoteDetailToCreate QuoteDetailNew);

          //Method that gets all the quotes by companyID 
        //Arranges them from the new to the old by QuoteID
        //And presents them with their details
        //Quotes with no details will show "No Details" and Value "0"
        List<DTOQuoteDetailToShow> GetQuoteDetail(int CompanyID);

         //Method that adds list of suppliers (Participants) to the quotaion Suppliers=Companies
        // Method takes list of integers with companyIDs and the quotation ID
        bool AddSuppliersToQuotation(List<DTOParticipantToShow> particpantsList);

        //Method that removes suppliers (Participants) from quotation
        //Method takes list of integers with ParticipantId
        bool RemoveSuppliersFromQuotation(List<DTOParticipantToShow> participantIDList);



    }
}
