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
    public class BidService:QuoteBidBase
    {
        public bool setNewBid(QuoteBidDTO newBid, int companyId)
        {
           //bool result = false;
           QuoteParticipantService newParticipantSupplier = new QuoteParticipantService();
            newParticipantSupplier.CompanyID = companyId;
            newParticipantSupplier.QuoteID = newBid.QuoteID;
            newParticipantSupplier.SetNewParticipant(companyId, newBid.QuoteID);
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {
                    
                    QuoteParticipant newQuoteParticipant = new QuoteParticipant();
                    QuoteParticipantBase newParticipant;
                    newParticipant = newParticipantSupplier.GetQuoteParticipant(companyId, newBid.QuoteID);
                    newQuoteParticipant.QuoteParticipantID = newParticipant.QuoteParticipantID;
                    QuoteBid newBidToCreate = new QuoteBid()
                    {
                    QuoteParticipantID = newQuoteParticipant.QuoteParticipantID,
                    QuoteID = newBid.QuoteID,
                    Amount = newBid.Amount,
                    Notes = newBid.Notes

                };
                  using (var context = new RFQEntities())
                    {
                       

                        if (newBidToCreate.EntityState == EntityState.Detached)
                        {
                            context.QuoteBids.AddObject(newBidToCreate);
                        }

                        context.SaveChanges();

                    }

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    return false;
                   


                }
                transaction.Complete();
                return true;
                

            }  
         } 

       
      //Method takes active bids by CompanyId for supplier
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
        }}
    
    }


