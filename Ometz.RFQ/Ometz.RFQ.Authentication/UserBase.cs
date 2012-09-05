using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.Authentication
{
    public abstract class UserBase
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int CompanyID { get; set; }

        //public abstract bool PasswordValidation(string passwordEntered, string passwordDB);

    }
}
