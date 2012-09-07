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
            dgvBidsInfo.DataSource = quotesToShow.DTO_BidToShow();
            dgvBidsInfo.Columns["CompanyID"].Visible = false;
            //dgvBidsInfo.Columns["Text"].Visible = false;
            dgvBidsInfo.Columns["Status"].Visible = false;

        }

        private void btnShowMyBids_Click(object sender, EventArgs e)
        {
            QuoteBidDTO bidsToShow = new QuoteBidDTO();
            dgvBidsInfo.DataSource = bidsToShow.ShowParticipantBids(3); // 2 is a participant ID
        }

        private void btnCreateNewBid_Click(object sender, EventArgs e)
        {
            //QuoteBidDTO objectToSend = new QuoteBidDTO();
            //objectToSend.QuoteID = 3;
            //objectToSend.Amount = 50;
            //objectToSend.Notes = "I'm in";
            //BidService bidToCreate = new BidService();
            //bidToCreate.setNewBid(objectToSend,compId);

        }

        private void frmSupplierMain_Load(object sender, EventArgs e)
        {

        }                                
    }
}
