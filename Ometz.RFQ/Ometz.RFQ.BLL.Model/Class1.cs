using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL.Model
{
    public class Class1
    {
    }

    public abstract class DTOCompany
    {
        public int CompanyID
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }
    
    }

    public abstract class DTOQoute
    {
        public int QuoteID
        { get; set; }

        public DateTime StartDate
        { get; set; }

        public DateTime EndDate
        { get; set; }
    }

    public abstract class DTOQuoteBid
    {
        public int QuoteBidID
        { get; set; }

        public decimal Amount
        { get; set; }

        public string Notes
        { get; set; }

    }

    public abstract class DTOQuoteDetail
    {
        public int QuoteDetailID
        { get; set; }

        public string Text
        { get; set; }

        public decimal Value
        { get; set; }
    }

    public abstract class DTOQuoteParticipant
    {
        public int QuoteParticipantID
        { get; set; }
    }

    public abstract class DTOQuoteWinner
    {
        public int QuoteWinnerID
        { get; set; }
    }
}
