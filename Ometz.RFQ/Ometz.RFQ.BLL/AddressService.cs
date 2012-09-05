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
    public class AddressService:IAddress
    {
        //Method that creates new Address for specific Company
        public bool CreateNewAddress(AddressDTO AddressNew)
        {
            bool check = false;
            using (TransactionScope transaction = new TransactionScope())
            {

                try
                {
                    Address AddressIn = new Address();
                    //Data transfer to the the AddressIn
                    AddressIn.Address1 = AddressNew.Address1;
                    AddressIn.Address2 = AddressNew.Address2;
                    AddressIn.City = AddressNew.City;
                    AddressIn.State = AddressNew.State;
                    AddressIn.PostalCode = AddressNew.PostalCode;
                    AddressIn.Country = AddressNew.Country;
                    AddressIn.Phone = AddressNew.Phone;
                    AddressIn.Fax = AddressNew.Fax;
                    AddressIn.Email = AddressNew.Email;

                    using (var context = new RFQEntities())
                    {
                        //Finding references for the Foreign Keys
                        Company existingCompany = context.Companies.Single(p => p.CompanyID == AddressNew.CompanyID);

                        //Adding refernces
                        AddressIn.Company = existingCompany;


                        if (AddressIn.EntityState == EntityState.Detached)
                        {
                            context.Addresses.AddObject(AddressIn);
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


        //Method that gets all the Addresses by CompanyID
        public List<AddressDTO> GetAddressesByCompanyID(int companyID)
        {
            List<AddressDTO> AddressesListOut = new List<AddressDTO>();
            List<Address> AddressListDB = new List<Address>();

            using (var context = new RFQEntities())
            {
                AddressListDB = (from adr in context.Addresses.Include("Company")
                                 where adr.Company.CompanyID == companyID
                                 select adr).ToList();
            }

            if (AddressListDB.Count > 0)
            {
                foreach (var adr in AddressListDB)
                {
                    AddressDTO AddressRow = new AddressDTO();
                    AddressRow.AddressID = adr.AddressID;
                    AddressRow.CompanyID = companyID;
                    AddressRow.Address1 = adr.Address1;
                    AddressRow.Address2 = adr.Address2;
                    AddressRow.City = adr.City;
                    AddressRow.State = adr.State;
                    AddressRow.PostalCode = adr.PostalCode;
                    AddressRow.Country = adr.Country;
                    AddressRow.Phone = adr.Phone;
                    AddressRow.Fax = adr.Fax;
                    AddressRow.Email = adr.Email;

                    AddressesListOut.Add(AddressRow);

                }
            }

            return AddressesListOut;
        }







    }
}
