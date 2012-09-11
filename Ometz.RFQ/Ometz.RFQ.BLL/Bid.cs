using System;
using System.Collections.Generic;
//using System.Collections.IEnumerable;
using System.Linq;
using System.Text;
using Ometz.RFQ.DAL;
using Ometz.RFQ.BLL.Model;
using System.Transactions;
using System.Data;

namespace Ometz.RFQ.BLL
{
    //public class DTOShowQuoteBid : DTOQuoteBid
    //{
    //    public List<DTOShowQuoteBid> ShowParticipantBids(int quoteParticipantID)
    //    {
    //        List<QuoteBid> bids = new List<QuoteBid>();
    //        List<DTOShowQuoteBid> bidsToReturn = new List<DTOShowQuoteBid>();
    //        using (var context = new RFQEntities())
    //        {
    //            bids = (from bid in context.QuoteBids
    //                    where bid.QuoteParticipantID == quoteParticipantID
    //                    select bid).ToList();
    //            if (bids.Count > 0)
    //            {
    //                foreach (var item in bids)
    //                {
    //                    DTOShowQuoteBid bidRow = new DTOShowQuoteBid();
    //                    bidRow.QuoteBidID = item.QuoteBidID;
    //                    bidRow.QuoteID = item.QuoteID;
    //                    bidRow.QuoteParticipantID = item.QuoteParticipantID;
    //                    bidRow.Amount = item.Amount;
    //                    bidRow.Notes = item.Notes;
    //                    bidsToReturn.Add(bidRow);
    //                }
    //            }
    //        }

    //        return bidsToReturn;
    //    }
    //  }

    public class QuoteBidDTO : QuoteBidBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int CompanyID { get; set; }


        public IList<QuoteBidDTO> ShowParticipantBids(int quoteParticipantID)
        {
            
            IList<QuoteBid> bids = new List<QuoteBid>();
            IList<QuoteBidDTO> bidsToReturn = new List<QuoteBidDTO>();
            using (var context = new RFQEntities())
            {
                bids = (from bid in context.QuoteBids.Include("Quote").Include("Quote.Company").Include("Quote.Company.CompanyType")
                        where bid.QuoteParticipantID == quoteParticipantID
                        select bid).ToList();
                if (bids.Count > 0)
                {
                    foreach (var item in bids)
                    {
                        QuoteBidDTO bidRow = new QuoteBidDTO();
                        bidRow.QuoteBidID = item.QuoteBidID;
                        bidRow.QuoteID = item.QuoteID;
                        bidRow.QuoteParticipantID = item.QuoteParticipantID;
                        bidRow.Amount = item.Amount;
                        bidRow.Notes = item.Notes;
                        bidRow.Name = item.Quote.Company.Name;
                        bidRow.Type = item.Quote.Company.CompanyType.Type;                       
                        bidsToReturn.Add(bidRow);
                    }
                }
            }

            return bidsToReturn;
        }
    

     public IList<QuoteBidDTO> GetMyBids(int CompanyID)
        {
            
            IList<QuoteBid> bids = new List<QuoteBid>();
            IList<QuoteBidDTO> bidsToReturn = new List<QuoteBidDTO>();
            using (var context = new RFQEntities())
            {
                bids = (from bid in context.QuoteBids.Include("Quote").Include("Quote.Company").Include("Quote.Company.CompanyType")
                        where bid.QuoteParticipant.CompanyID == CompanyID && bid.Quote.Status==1
                        select bid).ToList();
                if (bids.Count > 0)
                {
                    foreach (var item in bids)
                    {
                        QuoteBidDTO bidRow = new QuoteBidDTO();
                        bidRow.QuoteBidID = item.QuoteBidID;
                        bidRow.QuoteID = item.QuoteID;
                        bidRow.QuoteParticipantID = item.QuoteParticipantID;
                        bidRow.CompanyID = item.Quote.Company.CompanyID;
                        bidRow.Amount = item.Amount;
                        bidRow.Notes = item.Notes;
                        bidRow.Name = item.Quote.Company.Name;
                        bidRow.Type = item.Quote.Company.CompanyType.Type;                       
                        bidsToReturn.Add(bidRow);
                    }
                }
            }

            return bidsToReturn;
        }
    }
}
