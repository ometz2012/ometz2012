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
            ParticipantRFQ participRFQ = new ParticipantRFQ();
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
            quoteIDSelected = Convert.ToInt32((dataGridQuote.Rows[rowNumber].Cells[0]));
        
        }


        public class QuoteIDNotChosenExc : Exception
        { }

       
        
        public void LoadData()
        {
            //dataGridQuote.Rows.Clear();
            QuoteDTO quotesToShow = new QuoteDTO();
            this.dataGridQuote.DataSource = quotesToShow.DTO_BidToShow();
           
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           // LoadData();
        }

        
        
       

        

   }
}
