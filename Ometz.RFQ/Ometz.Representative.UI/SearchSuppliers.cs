﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ometz.RFQ.BLL;
using Ometz.RFQ.BLL.Model;



namespace Ometz.Representative.UI
{
    public partial class SearchSuppliers : Form
    {
        public SearchSuppliers()
        {
            InitializeComponent();
            
        }

        private void buttonLoadSuppliers_Click(object sender, EventArgs e)
        {
            SupplierLoadData();
        }


        private void SearchSuppliers_Load(object sender, EventArgs e)
        {
            //SupplierLoadData();
        }


        private void SupplierLoadData()
        {
            ICompany CompnyFunction = new CompanyService();

            List<CompanyDTO> ListOfCompanies = CompnyFunction.GetCompanies();

            gridSuppliers.DataSource = ListOfCompanies;
            
        
        }

        private void btnSupplierSearch_Click(object sender, EventArgs e)
        {


            //IBLLServices BllFunction = new BLLServices();

            //List<DTOCompanyNameToShow> ListOfCompanies = BllFunction.GetCompanies();

            //gridSuppliers.DataSource = ListOfCompanies;

        }

       
     

    }
}
