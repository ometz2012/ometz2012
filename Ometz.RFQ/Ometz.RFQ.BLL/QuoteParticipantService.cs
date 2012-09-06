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
        public QuoteParticipantBase getQuoteParticipant(int companyId, int quoteId)
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
    }
}
