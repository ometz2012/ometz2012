using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ometz.RFQ.BLL.Model;

namespace Ometz.RFQ.BLL
{
    // This DTO is designated to send all the necessary data of a particular quote participants
    public class ParticipantByQuoteDTO:QuoteParticipantBase
    {
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string CompanyName { get; set; }
        public string CategoryType { get; set; }
        public string Text { get; set; }

    }
}
