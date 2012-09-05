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
    public class QuoteService:IQuote
    {
        //Method that creates new Quotation 
        public bool CreateNewQuoation(QuoteDTO QuoteNew)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {
                    Quote QuoteIn = new Quote();
                    //Data transfer to the the AddressIn
                    QuoteIn.StartDate = QuoteNew.StartDate;
                    QuoteIn.EndDate = QuoteNew.EndDate;

                    using (var context = new RFQEntities())
                    {
                        //Finding references for the Foreign Keys
                        Company existingCompany = context.Companies.Single(q => q.CompanyID == QuoteNew.CompanyID);

                        //Adding refernces
                        QuoteIn.Company = existingCompany;


                        if (QuoteIn.EntityState == EntityState.Detached)
                        {
                            context.Quotes.AddObject(QuoteIn);
                        }

                        context.SaveChanges();

                    }

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }

        }//End of the method that creates new quotation


        //Method that adds new details row to the QuoteDetail
        public bool CreateNewQuoteDetail(QuoteDetailToCreateDTO QuoteDetailNew)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {
                    QuoteDetail QuoteDetailIn = new QuoteDetail();
                    //Data transfer to the object that will be added to the DB
                    QuoteDetailIn.Text = QuoteDetailNew.Text;
                    QuoteDetailIn.Value = QuoteDetailNew.Value;

                    using (var context = new RFQEntities())
                    {
                        //Finding references for the Foreign Keys
                        Quote existingQuote = context.Quotes.Single(qd => qd.QuoteID == QuoteDetailNew.QuoteID);

                        //Adding refernces
                        QuoteDetailIn.Quote = existingQuote;


                        if (QuoteDetailIn.EntityState == EntityState.Detached)
                        {
                            context.QuoteDetails.AddObject(QuoteDetailIn);
                        }

                        context.SaveChanges();

                    }

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }

        }

        //Method that gets all the quotes by companyID 
        //Arranges them from the new to the old by QuoteID
        //And presents them with their details
        //Quotes with no details will show "No Details" and Value "0"
        public List<QuoteDetailDTO> GetQuoteDetail(int CompanyID)
        {
            List<QuoteDetailDTO> ListofQuoteDetails = new List<QuoteDetailDTO>();
            using (var context = new RFQEntities())
            {
                var results = (from quote in context.Quotes
                               join quoteDet in context.QuoteDetails
                               on quote.QuoteID equals quoteDet.Quote.QuoteID into qq
                               orderby quote.QuoteID descending
                               from quoteDet in qq.DefaultIfEmpty()
                               select new
                               {
                                   QuoteID = quote.QuoteID,
                                   StartDate = quote.StartDate,
                                   EndDate = quote.EndDate,
                                   QuoteDetails = quoteDet.Text == null ? "(No Details)" : quoteDet.Text,
                                   Value = quoteDet.Value == null ? 0m : quoteDet.Value
                               }).ToList();
                foreach (var item in results)
                {
                    QuoteDetailDTO row = new QuoteDetailDTO();
                    row.QuoteID = item.QuoteID;
                    row.StartDate = item.StartDate;
                    row.EndDate = item.EndDate;
                    row.Text = item.QuoteDetails;
                    row.Value = item.Value;
                    ListofQuoteDetails.Add(row);

                }
            }



            return ListofQuoteDetails;
        }


        //Method that adds list of suppliers (Participants) to the quotaion Suppliers=Companies
        // Method takes list of integers with companyIDs and the quotation ID
        public bool AddSuppliersToQuotation(List<ParticipantDTO> particpantsList)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {

                    using (var context = new RFQEntities())
                    {


                        foreach (var item in particpantsList)
                        {
                            QuoteParticipant QuoteParticipantIn = new QuoteParticipant();

                            //Finding references for the Foreign Keys - QUOTE
                            Quote existingQuote = context.Quotes.Single(q => q.QuoteID == item.QuoteID);

                            //retriving references for the Foreign Key- Company
                            Company existingCompany = context.Companies.Single(comp => comp.CompanyID == item.CompanyID);


                            List<QuoteParticipant> existParticipant = (from p in context.QuoteParticipants
                                                                       where p.Quote.QuoteID == item.QuoteID &&
                                                                       p.Company.CompanyID == item.CompanyID
                                                                       select p).ToList();
                            if (existParticipant.Count > 0)
                            {

                            }
                            else
                            {
                                //Adding refernces
                                QuoteParticipantIn.Company = existingCompany;
                                QuoteParticipantIn.Quote = existingQuote;


                                if (QuoteParticipantIn.EntityState == EntityState.Detached)
                                {
                                    context.QuoteParticipants.AddObject(QuoteParticipantIn);
                                }

                                context.SaveChanges();

                            }



                        }//end foreach

                    }//end try

                }
                catch (DataExistis de)
                {

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }
        }


        //Method that removes suppliers (Participants) from quotation
        //Method takes list of integers with ParticipantId
        public bool RemoveSuppliersFromQuotation(List<ParticipantDTO> participantIDList)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {

                    using (var context = new RFQEntities())
                    {

                        foreach (var item in participantIDList)
                        {


                            QuoteParticipant QuoteParticipantOut = (from part in context.QuoteParticipants
                                                                    where part.QuoteParticipantID == item.QuoteParticipantID
                                                                    select part).First();


                            if (QuoteParticipantOut != null)
                            {
                                context.DeleteObject(QuoteParticipantOut);
                                context.SaveChanges();

                            }


                        }//foreach

                    }//using

                }//try

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }//transaction

        }//method


        //Method that terminate RFQ before the Due Date

        public bool TerminationRFQ(int quoteIDTerminate)
        {

            bool check = false;


            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {
                    QuoteToTerminateDTO QuoteTerminate = new QuoteToTerminateDTO();

                    using (var context = new RFQEntities())
                    {

                        var quote = (from q in context.Quotes
                                     where q.QuoteID == quoteIDTerminate
                                     select q);


                        if (quote != null)
                        {
                            foreach (Quote q in quote)
                            {
                                q.Status = false;

                            }
                        }
                    }

                }

                catch (Exception e)
                {
                    transaction.Dispose();
                    check = false;
                    return check;


                }
                transaction.Complete();
                check = true;
                return check;


            }

        }






    }
}
