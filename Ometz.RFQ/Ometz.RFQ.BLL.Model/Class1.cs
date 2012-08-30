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
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public int CompanyTypeID { get; set; }
        public int CategoryID { get; set; }

        public abstract string GetCompanyType();
        public abstract string GetCompanyCategory();
  
    }

    public abstract class DTOQoute
    {
        public int QuoteID
        { get; set; }

        public int CompanyID
        { get; set; }

        public DateTime StartDate
        { get; set; }

        public DateTime EndDate
        { get; set; }

        public abstract string GetCompany(int CompanyID);
    }

    public abstract class DTOQuoteBid
    {
        public int QuoteBidID
        { get; set; }

        public int QuoteID
        { get; set; }

        public int QuoteParticipantID
        { get; set; }

        public decimal Amount
        { get; set; }

        public string Notes
        { get; set; }

        public abstract string GetQuote(int QuoteID);

        public abstract string GetQuoteParticipant(int QuoteParticipantID);
    }

    public abstract class DTOQuoteDetail
    {
        public int QuoteDetailID
        { get; set; }

        public int QuoteID
        { get; set; }

        public string Text
        { get; set; }

        public decimal Value
        { get; set; }

        public abstract string GetQuote(int QuoteID);
    }

    public abstract class DTOQuoteParticipant
    {
        public int QuoteParticipantID
        { get; set; }

        public int CompanyID
        { get; set; }

        public int QuoteID
        { get; set; }

        public abstract string GetCompany(int CompanyID);

        public abstract string GetQuote(int QuoteID);
    }

    public abstract class DTOQuoteWinner
    {
        public int QuoteWinnerID
        { get; set; }

        public int CompanyID
        { get; set; }

        public int QuoteID
        { get; set; }

        public abstract string GetCompany(int CompanyID);

        public abstract string GetQuote(int QuoteID);
    }
    
}
