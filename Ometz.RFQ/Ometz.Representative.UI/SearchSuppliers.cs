using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ometz.RFQ.DAL;

namespace Ometz.Representative.UI
{
    public partial class SearchSuppliers : Form
    {
        public SearchSuppliers()
        {
            InitializeComponent();
            
        }

        private void SearchSuppliers_Load(object sender, EventArgs e)
        {
            SupplierLoadData();
        }

        private void LoadData()
        {
            List<Company> listOfCompanies = null;
            using (var context = new RFQEntities())
            { 

            listOfCompanies = (from e in context.Companies
                              select e).ToList();

            }
            gridSuppliers.DataSource = listOfCompanies;
        }

        private void SupplierLoadData()
        {
            using (var context = new RFQEntities())
            {

                gridSuppliers.DataSource = context.GetCompanies();
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
