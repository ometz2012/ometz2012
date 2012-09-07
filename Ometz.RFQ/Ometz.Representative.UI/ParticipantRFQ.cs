using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ometz.Representative.UI
{
    public partial class ParticipantRFQ : Form
    {
        public ParticipantRFQ()
        {
            InitializeComponent();
        }

        private void AddParticipBtn_Click(object sender, EventArgs e)
        {
            ParticipantRFQ participRFQ = new ParticipantRFQ();
            participRFQ.ShowDialog(this);
        }

        
        
        private void RemovePartBtn_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
