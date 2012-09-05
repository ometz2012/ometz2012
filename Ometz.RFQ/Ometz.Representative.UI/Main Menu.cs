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
        public MainMenu(int companyID)
        {
            InitializeComponent();
        }

        private void CreateRFQBtn_Click(object sender, EventArgs e)
        {
            CreateRFQ createRFQ = new CreateRFQ();
            createRFQ.ShowDialog(this);
        }

   }
}
