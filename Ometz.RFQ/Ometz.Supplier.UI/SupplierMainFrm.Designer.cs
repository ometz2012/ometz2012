namespace Ometz.Supplier.UI
{
    partial class frmSupplierMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBidsInfo = new System.Windows.Forms.DataGridView();
            this.btnShowQuotes = new System.Windows.Forms.Button();
            this.btnShowMyBids = new System.Windows.Forms.Button();
            this.btnCreateNewBid = new System.Windows.Forms.Button();
            this.btnActiveBids = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBidsInfo
            // 
            this.dgvBidsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBidsInfo.Location = new System.Drawing.Point(12, 25);
            this.dgvBidsInfo.Name = "dgvBidsInfo";
            this.dgvBidsInfo.Size = new System.Drawing.Size(689, 150);
            this.dgvBidsInfo.TabIndex = 0;
            this.dgvBidsInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBidsInfo_RowHeaderMouseClick);
            // 
            // btnShowQuotes
            // 
            this.btnShowQuotes.Location = new System.Drawing.Point(612, 228);
            this.btnShowQuotes.Name = "btnShowQuotes";
            this.btnShowQuotes.Size = new System.Drawing.Size(89, 23);
            this.btnShowQuotes.TabIndex = 1;
            this.btnShowQuotes.Text = "ShowAllQuotes";
            this.btnShowQuotes.UseVisualStyleBackColor = true;
            this.btnShowQuotes.Click += new System.EventHandler(this.btnShowQuotes_Click);
            // 
            // btnShowMyBids
            // 
            this.btnShowMyBids.Location = new System.Drawing.Point(517, 228);
            this.btnShowMyBids.Name = "btnShowMyBids";
            this.btnShowMyBids.Size = new System.Drawing.Size(75, 23);
            this.btnShowMyBids.TabIndex = 2;
            this.btnShowMyBids.Text = "ShowMyBids";
            this.btnShowMyBids.UseVisualStyleBackColor = true;
            this.btnShowMyBids.Click += new System.EventHandler(this.btnShowMyBids_Click);
            // 
            // btnCreateNewBid
            // 
            this.btnCreateNewBid.Location = new System.Drawing.Point(388, 228);
            this.btnCreateNewBid.Name = "btnCreateNewBid";
            this.btnCreateNewBid.Size = new System.Drawing.Size(101, 23);
            this.btnCreateNewBid.TabIndex = 3;
            this.btnCreateNewBid.Text = "CreateNewBid";
            this.btnCreateNewBid.UseVisualStyleBackColor = true;
            this.btnCreateNewBid.Click += new System.EventHandler(this.btnCreateNewBid_Click);
            // 
            // btnActiveBids
            // 
            this.btnActiveBids.Location = new System.Drawing.Point(277, 227);
            this.btnActiveBids.Name = "btnActiveBids";
            this.btnActiveBids.Size = new System.Drawing.Size(90, 23);
            this.btnActiveBids.TabIndex = 4;
            this.btnActiveBids.Text = "ActiveQuotes";
            this.btnActiveBids.UseVisualStyleBackColor = true;
            this.btnActiveBids.Click += new System.EventHandler(this.btnActiveBids_Click);
            // 
            // frmSupplierMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 263);
            this.Controls.Add(this.btnActiveBids);
            this.Controls.Add(this.btnCreateNewBid);
            this.Controls.Add(this.btnShowMyBids);
            this.Controls.Add(this.btnShowQuotes);
            this.Controls.Add(this.dgvBidsInfo);
            this.Name = "frmSupplierMain";
            this.Text = "Supplier";
            this.Activated += new System.EventHandler(this.frmSupplierMain_Load);
            this.Load += new System.EventHandler(this.frmSupplierMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBidsInfo;
        private System.Windows.Forms.Button btnShowQuotes;
        private System.Windows.Forms.Button btnShowMyBids;
        private System.Windows.Forms.Button btnCreateNewBid;
        private System.Windows.Forms.Button btnActiveBids;
    }
}

