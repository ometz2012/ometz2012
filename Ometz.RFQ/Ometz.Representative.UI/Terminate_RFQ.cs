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
    public partial class Terminate_RFQ : Form
    {
        int quoteId;
        MainMenu instanceMainForm;

        public Terminate_RFQ(int quoteIdSelected, MainMenu mainMenuForm)
        {
            InitializeComponent();
            quoteId = quoteIdSelected;
            instanceMainForm = mainMenuForm;
        }
               

private void TerminateYesBtn_Click_1(object sender, EventArgs e)
{
    try
            {

                    IQuote terminQuote = new QuoteService();
                    bool check = terminQuote.TerminationRFQ(quoteId);

                    if (check)
                    {
                        MessageBox.Show("Quote was terminated. ", "Termination RFQ", MessageBoxButtons.OK);
                        instanceMainForm.LoadData();
                        this.Close();
                        

                    }

                    else
                    {
                        throw new TerminationFailed();
                    }

                
            }
            catch (TerminationFailed)
            {
                MessageBox.Show("Quote was not terminated!", "Termination RFQ", MessageBoxButtons.OK);
            }

        }


private void TerminateNoBtn_Click_1(object sender, EventArgs e)
{
    this.Close();
}



internal class TerminationFailed : Exception
{ }

    }
}
