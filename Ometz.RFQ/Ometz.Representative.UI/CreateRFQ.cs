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
        MainMenu instanceMainForm;
        public CreateRFQ(int companyId, MainMenu mainMenuForm)
           
        {
            InitializeComponent();
            companyIDIn = companyId;
            instanceMainForm = mainMenuForm;
            this.textBoxStartDate.KeyPress += new KeyPressEventHandler(ApplicationServices.Number_KeyPress);
            this.textBoxEndDate.KeyPress += new KeyPressEventHandler(ApplicationServices.Number_KeyPress);
            this.textBoxQuantity.KeyPress += new KeyPressEventHandler(ApplicationServices.Number_KeyPress);
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
            try
            {
                ApplicationServices appService = new ApplicationServices();
                bool emptyText = appService.EmptyTextValidation(this);
                appService.EmptyTextMark(this);

                if (!emptyText)
                    throw new EmptyText();

                DateTime StartDate = new DateTime();
                DateTime EndDate = new DateTime();
                string sStartDate = textBoxStartDate.Text;
                string sEndDate = textBoxEndDate.Text;
                bool startDateValid = DateTime.TryParse(sStartDate, out StartDate);
                bool endDateValid = DateTime.TryParse(sEndDate, out EndDate);

                if (!startDateValid)
                {
                    textBoxStartDate.BackColor = Color.Red;
                    throw new InvalidDateFormat();

                }

                if (!endDateValid)
                {
                    textBoxEndDate.BackColor = Color.Red;
                    throw new InvalidDateFormat();
                }

                if (StartDate > EndDate)
                {
                    throw new DateChronolgy();
                }


                QuoteDTO QuoteIn = new QuoteDTO();
                QuoteIn.CompanyID = companyIDIn;
                QuoteIn.StartDate = StartDate;
                QuoteIn.EndDate = EndDate;

                IQuote QuoteFunctions = new QuoteService();
                QuoteAdded QuoteValidation = QuoteFunctions.CreateNewQuoation(QuoteIn);
                if (QuoteValidation.Added == true)
                {
                    QuoteDetailToCreateDTO DetailToCreate = new QuoteDetailToCreateDTO();
                    DetailToCreate.QuoteID = QuoteValidation.LastId;
                    DetailToCreate.Text = textBoxDescription.Text;
                    string sValue = textBoxQuantity.Text;
                    decimal dValue;
                    bool isParsed = decimal.TryParse(sValue, out dValue);

                    if (!isParsed)
                    { throw new QuantityWrong(); }

                    DetailToCreate.Value = dValue;

                    bool check = QuoteFunctions.CreateNewQuoteDetail(DetailToCreate);

                    if (check)
                    {
                        MessageBox.Show("Quote was created. ", "app", MessageBoxButtons.OK);
                       
                        this.Close();
                       //MainMenu mm = new MainMenu(companyIDIn);
                        instanceMainForm.LoadData();
                    }
                    else
                    {
                        throw new QuoteFailed();
                    }

                }
                else
                {
                    throw new QuoteFailed();
                }

            }
            catch (EmptyText et)
            {
                MessageBox.Show("Empty Text, all fields must be filled out.", "app", MessageBoxButtons.OK);
            }
            catch (InvalidDateFormat idf)
            {
                MessageBox.Show("Date format is invalid. Date format is: 'yyyy/mm/dd' ", "app", MessageBoxButtons.OK);

            }
            catch (QuoteFailed qf)
            {
                MessageBox.Show("Quote creation failed. Please check your data. ", "app", MessageBoxButtons.OK);

            }
            catch (DateChronolgy dc)
            {
                MessageBox.Show("Dates are not choronological. ", "app", MessageBoxButtons.OK);
 
            }
            catch(QuantityWrong qw)
            {
                MessageBox.Show("Quanity should be decimal. ", "app", MessageBoxButtons.OK);
 
            }

        }

        private void CreateRFQ_Load(object sender, EventArgs e)
        {

        }


    }

    internal class InvalidDateFormat : Exception
    { }
    internal class EmptyText : Exception
    { }
    internal class QuoteFailed : Exception
    { }
    internal class DateChronolgy : Exception
    { }
    internal class QuantityWrong : Exception
    { }
}
