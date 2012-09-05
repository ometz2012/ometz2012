using System;
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
    public partial class CreateRFQ : Form
    {
        int companyIDIn;
        public CreateRFQ(int companyId)
        {
            InitializeComponent();
            companyIDIn = companyId;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = null;
            textBoxQuantity.Text = null;
            textBoxEndDate.Text = null;
            textBoxStartDate.Text = null;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            QuoteDTO QuoteIn = new QuoteDTO();
            QuoteIn.CompanyID = companyIDIn;

            
            IQuote QuoteFunctions = new QuoteService();
            QuoteAdded QuoteValidation = QuoteFunctions.CreateNewQuoation(QuoteIn);
            if (QuoteValidation.Added == true)
            {
                QuoteDetailToCreateDTO DetailToCreate = new QuoteDetailToCreateDTO();
                DetailToCreate.QuoteID = QuoteValidation.LastId;
                DetailToCreate.Text = textBoxDescription.Text;
                string sValue = textBoxQuantity.Text;
                decimal dValue;
                bool isParsed = decimal.TryParse(sValue,out dValue);
                DetailToCreate.Value = dValue;

                bool check = QuoteFunctions.CreateNewQuoteDetail(DetailToCreate);
            }

        }

        
        
    }
}
