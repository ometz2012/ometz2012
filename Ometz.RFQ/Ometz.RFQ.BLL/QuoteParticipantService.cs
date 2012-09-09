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
    public class QuoteParticipantService : QuoteParticipantBase, IQuoteParticipant
    {
        public void SetNewParticipant(int companyId, int quoteId)
        {
            using (var context = new RFQEntities())
            {
                IDbTransaction dbTrans = null;
                try
                {
                    QuoteParticipant newQuoteParticipant = new QuoteParticipant()
                    {
                        CompanyID = companyId,
                        QuoteID = quoteId
                    };
                    context.Connection.Open();
                    dbTrans = context.Connection.BeginTransaction();
                    context.QuoteParticipants.AddObject(newQuoteParticipant);
                    context.SaveChanges();
                    dbTrans.Commit();
                }
                catch (Exception ex)
                {

                    dbTrans.Rollback();
                 
                }

                finally
                {

                    context.Connection.Close();

                }
            }
        }
        // This method returns the single Supplier Participant in the particular quote
        public QuoteParticipantBase GetQuoteParticipant(int companyId, int quoteId)
        {
            using (var context = new RFQEntities())
            {

                QuoteParticipant quoteParticipant = new QuoteParticipant();

                quoteParticipant = (from participant in context.QuoteParticipants
                                    where participant.QuoteID == quoteId && participant.CompanyID == companyId
                                    select participant).FirstOrDefault();
                QuoteParticipantBase participantToReturn = new ParticipantDTO()
                {
                    QuoteParticipantID = quoteParticipant.QuoteParticipantID,
                    CompanyID = quoteParticipant.CompanyID,
                    QuoteID = quoteParticipant.QuoteID
                };
                return participantToReturn;
            }

        }
        // Method returns all the participants by a particular quote
        public List<ParticipantByQuoteDTO> GetQuoteParticipant(int quoteId)
        {
            List<ParticipantByQuoteDTO> quoteAllParticipants = new List<ParticipantByQuoteDTO>();
            List <QuoteParticipant> quoteParticipant = new List<QuoteParticipant>();
            using (var context = new RFQEntities())
            {
                
                  quoteParticipant = (from participant in context.QuoteParticipants.Include("Quote").
                                        Include("QuoteBids").Include("Company").Include("Company.Category")
                                        where participant.QuoteID == quoteId select participant).ToList();
                  foreach (var participant in quoteParticipant)
                  {
                      ParticipantByQuoteDTO quoteRow = new ParticipantByQuoteDTO();
                    
                    quoteRow.QuoteParticipantID = participant.QuoteParticipantID;
                    quoteRow.CompanyID = participant.CompanyID;
                    quoteRow.CompanyName = participant.Company.Name;
                    quoteRow.CategoryType = participant.Company.Category.Type;
                    quoteRow.QuoteID = quoteId;
                    
                    foreach (var item in participant.QuoteBids)
                    {
                        quoteRow.Notes = item.Notes;
                        quoteRow.Amount = item.Amount;
                    }
                    quoteAllParticipants.Add(quoteRow);

                  
                    }
                  }

                     return quoteAllParticipants;
                  }
                        
            
            }
        }
    



