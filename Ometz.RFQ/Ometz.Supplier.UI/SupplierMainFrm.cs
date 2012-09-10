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
    public partial class frmSupplierMain : Form
    {
        public int compId;
        public int quoteId;
        DateTime startDate;
        DateTime endDate;
        public frmSupplierMain(int companyID)
        {

            InitializeComponent();
            compId = companyID;

        }

       
        private void dgvBidsInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowQuotes_Click(object sender, EventArgs e)
        {

            QuoteDTO quotesToShow = new QuoteDTO();
            dgvBidsInfo.DataSource = quotesToShow.GetBid();
            dgvBidsInfo.Columns["CompanyID"].Visible = false;
            dgvBidsInfo.Columns["QuoteID"].Visible = false;
            dgvBidsInfo.Columns["Status"].Visible = false;

        }

        private void btnShowMyBids_Click(object sender, EventArgs e)
        {
            QuoteBidDTO bidsToShow = new QuoteBidDTO();
            dgvBidsInfo.DataSource = bidsToShow.ShowParticipantBids(3); // 2 is a participant ID
        }

        private void btnCreateNewBid_Click(object sender, EventArgs e)
        {
            NewBidFrm _newBidForm = new NewBidFrm(compId);
            _newBidForm.LoadData(quoteId, startDate, endDate);
            _newBidForm.Show();

            //QuoteBidDTO objectToSend = new QuoteBidDTO();
            //objectToSend.QuoteID = 3;
            //objectToSend.Amount = 50;
            //objectToSend.Notes = "I'm in";
            //BidService bidToCreate = new BidService();
            //bidToCreate.setNewBid(objectToSend,compId);

        }

        private void frmSupplierMain_Load(object sender, EventArgs e)
        {
            dgvBidsInfo.ClearSelection();
            btnCreateNewBid.Enabled = false;
        }

        private void btnActiveBids_Click(object sender, EventArgs e)
        {
           // QuoteService qs = new QuoteService();
            IQuote quote = new QuoteService();
            dgvBidsInfo.DataSource = quote.GetQuoteDetail(compId);
            dgvBidsInfo.Columns["QuoteDetailId"].Visible = false;           
            //dgvBidsInfo.Columns["QuoteId"].Width = 50;
            dgvBidsInfo.Columns["QuoteId"].Visible = false;
            dgvBidsInfo.Columns["Text"].DisplayIndex = 1;
            dgvBidsInfo.Columns["Text"].Width = 250;
            dgvBidsInfo.Columns["Value"].DisplayIndex = 2;
            dgvBidsInfo.Columns["StartDate"].DisplayIndex = 3;
            dgvBidsInfo.Columns["EndDate"].DisplayIndex = 4;          
            
        }

        private void dgvBidsInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvBidsInfo.Columns.Count == 6)
            {
           // MessageBox.Show(" Hi, I'm in");
            int value;
            DateTime _startDate;
            DateTime _endDate;
                    bool result = int.TryParse(dgvBidsInfo.SelectedRows[0].Cells["QuoteId"].Value.ToString(), out value);
                    if (result)
                    {
                        quoteId = value;
                    }
                    else
                    {
                        return;
                    }
                    result = DateTime.TryParse(dgvBidsInfo.SelectedRows[0].Cells["StartDate"].Value.ToString(), out _startDate);
                    if (result)
                    {
                        startDate = _startDate;
                    }
                    else
                    {
                        return;
                    }
                    result = DateTime.TryParse(dgvBidsInfo.SelectedRows[0].Cells["EndDate"].Value.ToString(), out _endDate);
                    if (result)
                    {
                        endDate = _endDate;
                        btnCreateNewBid.Enabled = true;
                    }
                    else
                    {
                        return;
                    }
        }   
      }                 
    }
}
