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
    public partial class Form1 : Form
    {
        public Form1(CompanyDTO CompanyLogIn)
        {
            InitializeComponent();
        }

        private void dgvBidsInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowBids_Click(object sender, EventArgs e)
        {
            QuoteDTO quotesToShow = new QuoteDTO();
            dgvBidsInfo.DataSource = quotesToShow.DTO_BidToShow();
            
        }

        private void btnShowMyBids_Click(object sender, EventArgs e)
        {
            //DTOQuoteToShow quotesToShow = new DTOQuoteToShow();
            // 1 is a companyID
          // dgvBidsInfo.DataSource = quotesToShow.DTO_BidToShow(1);
            QuoteBidDTO bidsToShow = new QuoteBidDTO();
            dgvBidsInfo.DataSource = bidsToShow.ShowParticipantBids(2); // 2 is a participant ID
        }

       
    }
}
