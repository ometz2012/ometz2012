using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ometz.RFQ.BLL;

namespace Ometz.Representative.UI
{
    public partial class ParticipantRFQ : Form
    {
        int _quoteId;
        

        public ParticipantRFQ()
        {
            InitializeComponent();
            LoadData();
            

        }
       
        public ParticipantRFQ(int quoteId)
        {
            InitializeComponent();
            _quoteId = quoteId;
            LoadData();
           

        }

        private void AddParticipBtn_Click(object sender, EventArgs e)
        {

            AddParticipantToQuote addparticip = new AddParticipantToQuote(_quoteId);
            addparticip.ShowDialog(this);
        }

        
        
        private void RemovePartBtn_Click(object sender, EventArgs e)
        {

        }

        private void ParticipantRFQ_Load(object sender, EventArgs e)
        {
           
        }
     
        public void LoadData()
        {         
            ParticipantByQuoteDTO allParticipantsInQuote = new ParticipantByQuoteDTO();
            label1.Text = allParticipantsInQuote.Text;

            QuoteParticipantService quoteParticipantsService = new QuoteParticipantService();
            dgvParticipantsInQuote.DataSource = quoteParticipantsService.GetQuoteParticipantsList(_quoteId);
            
            
        }
        
        
    }
}
