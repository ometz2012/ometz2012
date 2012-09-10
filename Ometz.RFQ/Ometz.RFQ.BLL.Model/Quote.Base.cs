using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL.Model
{
  

    public abstract class QuoteBase
    {
        public int QuoteID{ get; set; }
        public int CompanyID{ get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate{ get; set; }
        public Int16 Status { get; set; }
        //public abstract string GetCompany(int CompanyID);
        //public virtual DTOQuote ShowBid();
    }

    

    public abstract class QuoteDetailBase
    {
        public int QuoteDetailID{ get; set; }
        public int QuoteID { get; set; }
        public string Text{ get; set; }
        public decimal Value{ get; set; }

        //public abstract string GetQuote(int QuoteID);
    }

   

  

   
}
