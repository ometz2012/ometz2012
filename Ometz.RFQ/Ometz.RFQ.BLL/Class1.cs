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
    public class Class1
    {


    }

    public class CompanyDTO : CompanyBase
    {
       
    }

    public class CompanyNameDTO : CompanyBase
    {
        

    }

    


    //  DTO ADDRESS TO SHOW
    public class AddressDTO : AddressBase
    {

    }

 

    //------Quote--Detail ---   
    public class QuoteDetailToCreateDTO : QuoteDetailBase
    {

    }

    public class QuoteDetailDTO : QuoteDetailBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }

    public class QuoteAdded
    {
        public bool Added { get; set; }
       public int LastId { get; set; }
    }

    //DTO Participant

    public class ParticipantDTO : QuoteParticipantBase
    {

    }


    public class QuoteInfoDTO : QuoteBase
    {
      

    }

    

    //Exceptions
    #region Exceptions
    public class DataExistis : Exception
    {

    }



    #endregion





 
}

