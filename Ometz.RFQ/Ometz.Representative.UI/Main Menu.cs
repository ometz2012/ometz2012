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
    public partial class MainMenu : Form
    {

        int companyID;        
        int quoteIDSelected;
         

        public MainMenu(int companyID)
        {
            InitializeComponent();
            this.companyID = companyID;
            
            LoadData();
        }


       
        
        private void CreateRFQBtn_Click(object sender, EventArgs e)
        {
            CreateRFQ createRFQ = new CreateRFQ(this.companyID, this);
            createRFQ.Show(this);
        }


     
        private void ParticipantBtn_Click(object sender, EventArgs e)
        {
            ParticipantRFQ participRFQ = new ParticipantRFQ(quoteIDSelected);
            participRFQ.ShowDialog(this);
        }
        
               
        
        
        private void TerminateRFQBtn_Click(object sender, EventArgs e)
        {

        }

        
        
        private void RFQWinnersBtn_Click(object sender, EventArgs e)
        {

        }

        
        
        private void AddQuotDetailBtn_Click(object sender, EventArgs e)
        {
            int quoteID = this.quoteIDSelected;

            try
            {
                if (quoteID != 0)
                { }
                else
                    throw new QuoteIDNotChosenExc();

                     /*AddQuoteDetail newMDIChild = new TimeSheet(socialInsurranceNumber);*/



            }
            catch (QuoteIDNotChosenExc q)
            {
                MessageBox.Show("Quote was not chosen. In order to choose the quote, please press on row header.", "Application", MessageBoxButtons.OK);

            }
            finally { }




        }

        
        
        private void SearchQuoteBtn_Click(object sender, EventArgs e)
        {

        }

       
        
        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        
            int rowNumber = e.RowIndex;
            int value;          
            bool result = int.TryParse(dataGridQuote.SelectedRows[0].Cells[2].Value.ToString(), out value);
            if (result)
            {
                quoteIDSelected = value;
                ParticipantBtn.Enabled = true;

            }

        
        }


        public class QuoteIDNotChosenExc : Exception
        { }

       
        
        public void LoadData()
        {
            ParticipantBtn.Enabled = false;
            QuoteDTO quotesToShow = new QuoteDTO();           
            this.dataGridQuote.DataSource = quotesToShow.GetBid();
            dataGridQuote.Columns["CompanyID"].Visible = false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            dataGridQuote.ClearSelection();
            ParticipantBtn.Enabled = false;
        }

        private void dataGridQuote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        
       

        

   }
}
