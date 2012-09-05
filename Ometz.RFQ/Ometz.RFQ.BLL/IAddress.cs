using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL
{
   
   public interface IAddress
    {

        //Method that creates new Address for specific Company
        bool CreateNewAddress(AddressDTO AddressNew);

        //Method that gets all the Addresses by CompanyID
        List<AddressDTO> GetAddressesByCompanyID(int companyID);
    }
}
