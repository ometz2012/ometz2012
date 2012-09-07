using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ometz.Supplier.UI
{
    public partial class NewBid : Form
    {
        public NewBid()
        {
            InitializeComponent();
        }

        private void NewBid_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
