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
    public partial class AddParticipantToQuote : Form
    {
        int quoteID;
        List<ParticipantToAdd> ListOfParticipantsToAdd = new List<ParticipantToAdd>();
        int rowIndex;
        
        public AddParticipantToQuote(int quoteId)
        {
            InitializeComponent();
            this.quoteID = quoteId;
            labelRfqId.Text = quoteID.ToString();
            LoadData();
            LoadData1();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ParticipantToAdd ParticipantRow = new ParticipantToAdd();
            int value;
            bool result = int.TryParse(dataGridViewMainAllCompanies.SelectedRows[rowIndex].Cells[1].Value.ToString(), out value);
            if (result)
            {
                ParticipantRow.CompanyId = value;
                buttonAdd.Enabled = true;

            }

            ParticipantRow.CompanyName = dataGridViewMainAllCompanies.SelectedRows[rowIndex].Cells[2].Value.ToString();
            ListOfParticipantsToAdd.Add(ParticipantRow);
            LoadData1();

        }






        private void LoadData()
        {
            ICompany CompanyService = new CompanyService();
            dataGridViewMainAllCompanies.DataSource = CompanyService.GetCompaniesWithCategories();
        }

        private void LoadData1()

        {
            dataGridViewCompaniesToAdd.DataSource = ListOfParticipantsToAdd;  

        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           this.rowIndex=e.RowIndex;
           
            
        }




    }

    class ParticipantToAdd
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
