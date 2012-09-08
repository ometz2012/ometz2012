using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL
{
   public interface IQuote
    {
        //Method that creates new Quotation 
        QuoteAdded CreateNewQuoation(QuoteDTO QuoteNew);

        //Method that adds new details row to the QuoteDetail
        bool CreateNewQuoteDetail(QuoteDetailToCreateDTO QuoteDetailNew);

        //Method that gets all the quotes by companyID 
        //Arranges them from the new to the old by QuoteID
        //And presents them with their details
        //Quotes with no details will show "No Details" and Value "0"
        List<QuoteDetailDTO> GetQuoteDetail(int CompanyID);
       
        //Method that adds list of suppliers (Participants) to the quotaion Suppliers=Companies
        // Method takes List<DTOParticipantToShow>
        bool AddSuppliersToQuotation(List<ParticipantDTO> particpantsList);

        //Method that removes suppliers (Participants) from quotation
        //Method takes List<DTOParticipantToShow>
        bool RemoveSuppliersFromQuotation(List<ParticipantDTO> participantIDList);

       
        //Method that terminate RFQ before the Due Date 
         bool TerminationRFQ(int quoteIDTerminate);

        //Method that shows all the active quotes    
         List<QuoteDTO> GetAllActiveQuotes(int companyId);
    }
}
