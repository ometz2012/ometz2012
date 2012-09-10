using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ometz.RFQ.BLL;

namespace Ometz.Supplier.UI
{
    public partial class NewBidFrm : Form
    {
        int companyId;
        int quoteId;
        public NewBidFrm()
        {
            InitializeComponent();
        }
        public NewBidFrm(int compId)
        {
            InitializeComponent();
            companyId = compId;
        }

        private void NewBid_Load(object sender, EventArgs e)
        {
            txtQuoteId.Enabled = false;
            txtStartDate.Enabled = false;
            txtEndDate.Enabled = false;
            txtAmount.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadData(int quoteId, DateTime startDate, DateTime endDate)
        {
            this.quoteId = quoteId;
            txtQuoteId.Text = Convert.ToString(quoteId);
            txtStartDate.Text = Convert.ToString(startDate);
            txtEndDate.Text = Convert.ToString(endDate);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = false;
            QuoteBidDTO objectToSend = new QuoteBidDTO();
            objectToSend.QuoteID = quoteId;
            result = Utility.InputAmountValidation(txtAmount.Text);
            if (result)
            {
                objectToSend.Amount = Convert.ToDecimal(txtAmount.Text);
            }
            else
            {
                lblAmount.ForeColor = Color.Red;
                txtAmount.Text = "";
                txtAmount.Focus();
                MessageBox.Show("You should enter a positive numerical amount");
                return;
            }
            result = Utility.InsertNewDataValidation(txtNotes.Text);
            if (result)
            {
                objectToSend.Notes = txtNotes.Text;
            }
            else
            {
                lblNotes.ForeColor = Color.Red;
                txtNotes.Focus();
                MessageBox.Show("You should enter some information");
                return;
            }
         
            BidService bidToCreate = new BidService();
            result = bidToCreate.setNewBid(objectToSend, companyId);
            if (result)
            {
                MessageBox.Show("The New Bid Has Just Been Successfully Created");
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
              ClearTextFields();
        }
        private void ClearTextFields()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && control.Enabled)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        
        }
    }
}
