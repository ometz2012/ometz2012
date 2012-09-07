using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ometz.RFQ.Authentication;
using Ometz.Representative.UI;
using Ometz.Supplier.UI;


namespace Ometz.RFQ.LogInApp
{
    public partial class Form1 : Form
    {
        int identificationCount = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try 
            {
                identificationCount++;
                if (identificationCount > 3)
                    throw new LoginFailed();

                string userName = textBoxUserName.Text;
                string password = textBoxPassword.Text;
                UserValidation(userName, password);
 
            }
            catch(LoginFailed lf)
            {
                MessageBox.Show("Login Failed", "app", MessageBoxButtons.OK);
                this.Close();

            }
          

        }

      


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void UserValidation(string userName, string password)
        {
            try
            {
                if (userName.Length < 1)
                    throw new InvalidUserName();

                if (password.Length < 1)
                    throw new InvalidPassword();

                IUserService UserFunctions = new UserService();

                bool userNameExisits = UserFunctions.CheckUserNameExists(userName);

                if (!userNameExisits)
                    throw new InvalidUserName();

                UserDTO UserLoggedIn = UserFunctions.GetUser(userName);

                bool passwordMatch = UserFunctions.PasswordValidation(password, UserLoggedIn.Password);

                if (!passwordMatch)
                { throw new InvalidLogIn(); }
                else
                {
                    identificationCount = 0;
                    ActivateApplication(UserLoggedIn);
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



       private void ActivateApplication(UserDTO UserLoggedIn)
        {
            int companyTypeID = UserLoggedIn.CompanyTypeID;

            if (companyTypeID == 1)
            {
                Ometz.Representative.UI.MainMenu newForm = new Ometz.Representative.UI.MainMenu(UserLoggedIn.CompanyID);
                newForm.ShowDialog();
                newForm.Activate();
                this.Hide();

                if (newForm.DialogResult == DialogResult.Cancel)
                {
                    this.Close();

                }

            }

            if (companyTypeID == 2)
            {
                Ometz.Supplier.UI.frmSupplierMain newForm = new Ometz.Supplier.UI.frmSupplierMain(UserLoggedIn.CompanyID);
                newForm.ShowDialog();
                newForm.Activate();
                this.Hide();

                if (newForm.DialogResult == DialogResult.Cancel)
                {
                    this.Close();

                }

            }

        }

       private void Form1_Load(object sender, EventArgs e)
       {

       }

    }

    internal class InvalidUserName : Exception
    { }
    internal class InvalidPassword : Exception
    { }
    internal class InvalidLogIn : Exception
    { }
    internal class LoginFailed : Exception
    { }

}
