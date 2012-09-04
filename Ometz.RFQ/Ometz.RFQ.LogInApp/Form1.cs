using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ometz.RFQ.BLL.Model;
using Ometz.RFQ.BLL;
using Ometz.Representative.UI;
using Ometz.Supplier.UI;


namespace Ometz.RFQ.LogInApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            
            string userName=textBoxUserName.Text;
            string password = textBoxPassword.Text;
            UserValidation(userName,password);


        }

        private void UserValidation(string userName,string password)
        {
            try
            {
                if (userName.Length<1)
                    throw new InvalidUserName();

                IBLLServices BllFunction = new BLLServices();
                DTOUserToShow user = new DTOUserToShow(userName);
                if (user == null)
                    throw new InvalidUserName();
               
                if (password.Length<1)
                    throw new InvalidPassword();
  

                bool check = user.PasswordValidation(password, user.Password);

                if (check)
                {
                    MessageBox.Show("login in is valid", "app", MessageBoxButtons.OK);
                    DTOCompanyToShow CompanyLogIn = new DTOCompanyToShow();
                    CompanyLogIn = BllFunction.GetCompanyByID(user.CompanyID);

                    if (CompanyLogIn.CompanyTypeID == 1)
                    {
                        Ometz.Representative.UI.Form1 newForm = new Ometz.Representative.UI.Form1(CompanyLogIn);
                        newForm.Show();
                        newForm.Activate();
                        this.Hide();

                    }

                    if (CompanyLogIn.CompanyID == 2)
                    {
                        Ometz.Supplier.UI.Form1 newForm = new Ometz.Supplier.UI.Form1(CompanyLogIn);
                        newForm.Show();
                        newForm.Activate();
                        this.Hide();

                    }



                }
                else
                {
                    throw new InvalidLogIn();
                }




            }
            catch (InvalidUserName eun)
            { MessageBox.Show("User Name in is invalid", "app", MessageBoxButtons.OK); }
            catch (InvalidPassword ep)
            { MessageBox.Show("Password in is invalid", "app", MessageBoxButtons.OK); }
            catch (InvalidLogIn ili)
            { MessageBox.Show("Login is invalid, please check your password or user name", "app", MessageBoxButtons.OK); }
            catch
            { MessageBox.Show("User Name in is invalid", "app", MessageBoxButtons.OK); }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    internal class InvalidUserName : Exception
    { }
    internal class InvalidPassword : Exception
    { }
    internal class InvalidLogIn : Exception
    { }

}
