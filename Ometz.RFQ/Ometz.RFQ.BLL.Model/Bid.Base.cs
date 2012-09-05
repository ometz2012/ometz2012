using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL.Model
{
    public abstract class QuoteBidBase
    {
        public int QuoteBidID { get; set; }
        public int QuoteID { get; set; }
        public int QuoteParticipantID { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }

        //  public abstract string GetQuote(int QuoteID);
        // public abstract string GetQuoteParticipant(int QuoteParticipantID);
    }
}
