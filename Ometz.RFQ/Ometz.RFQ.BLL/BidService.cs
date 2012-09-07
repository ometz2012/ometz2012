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
        public void setNewBid(QuoteBidDTO newBid, int companyId)
        {
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
                    newParticipant = newParticipantSupplier.getQuoteParticipant(companyId, newBid.QuoteID);
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
                   


                }
                transaction.Complete();
                

            }  
         } 

       }
    }


