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

    public class QuoteDTO : QuoteBase
    {
        public string Text { get; set; }
        public decimal Value { get; set; }
        
        public List<QuoteDTO> GetBid()
        {
            List<Quote> allQuotes = new List<Quote>();
            List<QuoteDTO> listQuotesOut = new List<QuoteDTO>();
            using (var context = new RFQEntities())
            {

                allQuotes = (from c in context.Quotes.Include("QuoteDetails")

                             select c).ToList();
            }
            if (allQuotes.Count > 0)
            {
                foreach (var quote in allQuotes)
                {
                    QuoteDTO quoteRow = new QuoteDTO();
                    quoteRow.QuoteID = quote.QuoteID;
                    quoteRow.CompanyID = quote.CompanyID;
                    quoteRow.StartDate = quote.StartDate;
                    quoteRow.EndDate = quote.EndDate;
                    quoteRow.Status = quote.Status;
                    foreach (var item in quote.QuoteDetails)
                    {
                        quoteRow.Text = item.Text;
                        quoteRow.Value = item.Value;
                    }
                    listQuotesOut.Add(quoteRow);
                }

                return listQuotesOut;
            }
            else return null;


        }
        // Show the quotes of a particular participant
        public List<QuoteDTO> DTO_BidToShow(int companyID)
        {
            //List<Quote> allQuotes = new List<Quote>();
            List<QuoteDTO> listQuotesOut = new List<QuoteDTO>();
            using (var context = new RFQEntities())
            {

                var allQuotes = (from quote in context.Quotes.Include("QuoteDetails")
                                 from participant in context.QuoteParticipants
                                 where participant.CompanyID == companyID &&
                                  quote.CompanyID == participant.CompanyID
                                 select
                                 new
                                 {
                                     QuoteID = quote.QuoteID,
                                     StartDate = quote.StartDate,
                                     EndDate = quote.EndDate,
                                     CompanyID = quote.CompanyID,
                                     Status = quote.Status
                                 }
                              ).ToList();

                //  if (allQuotes.Count > 0)
                //{
                foreach (var quote in allQuotes)
                {
                    QuoteDTO quoteRow = new QuoteDTO();
                    quoteRow.QuoteID = quote.QuoteID;
                    // quoteRow.CompanyID = quote.CompanyID;
                    quoteRow.StartDate = quote.StartDate;
                    quoteRow.EndDate = quote.EndDate;
                    quoteRow.Status = quote.Status;
                    /*foreach (var item in quote.QuoteDetails)
                    {
                        quoteRow.Text = item.Text;
                        quoteRow.Value = item.Value;
                    }*/
                    listQuotesOut.Add(quoteRow);
                    //}

                    return listQuotesOut;
                    //   }
                    //  else return null;


                }
            }
            return listQuotesOut;
        }
    }

    public class QuoteToTerminateDTO : QuoteBase
    {
        public int quoteid { get; set; }
    }

}


