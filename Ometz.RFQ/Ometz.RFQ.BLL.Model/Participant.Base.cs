﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL.Model
{
    public abstract class QuoteParticipantBase
    {
        public int QuoteParticipantID { get; set; }
        public int CompanyID { get; set; }
        public int QuoteID { get; set; }

        //public abstract string GetCompany(int CompanyID);

        //public abstract string GetQuote(int QuoteID);
    }
}
