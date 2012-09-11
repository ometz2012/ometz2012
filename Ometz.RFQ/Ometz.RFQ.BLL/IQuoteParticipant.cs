using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ometz.RFQ.BLL.Model;

namespace Ometz.RFQ.BLL
{
    public interface IQuoteParticipant
    {
         void SetNewParticipant(int companyId, int quoteId);

         QuoteParticipantBase GetQuoteParticipant(int companyId, int quoteId);

       // Method returns all the participants by a particular quote
         List<ParticipantByQuoteDTO> GetQuoteParticipantsList(int quoteId);
    }
}
