﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL.Model
{
    public abstract class CompanyBase
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public int CompanyTypeID { get; set; }
        public int CategoryID { get; set; }

        //public abstract string GetCompanyType();
        //public abstract string GetCompanyCategory();

    }


}
