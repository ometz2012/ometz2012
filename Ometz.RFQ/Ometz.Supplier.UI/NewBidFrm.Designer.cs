namespace Ometz.Supplier.UI
{
    partial class NewBid
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQuoteId = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpQuoteInfo = new System.Windows.Forms.GroupBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtQuoteId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBidInfo = new System.Windows.Forms.GroupBox();
            this.grpQuoteInfo.SuspendLayout();
            this.grpBidInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(590, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(498, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblQuoteId
            // 
            this.lblQuoteId.AutoSize = true;
            this.lblQuoteId.Location = new System.Drawing.Point(15, 32);
            this.lblQuoteId.Name = "lblQuoteId";
            this.lblQuoteId.Size = new System.Drawing.Size(47, 13);
            this.lblQuoteId.TabIndex = 2;
            this.lblQuoteId.Text = "QuoteID";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(14, 71);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(52, 13);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "StartDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EndDate";
            // 
            // grpQuoteInfo
            // 
            this.grpQuoteInfo.Controls.Add(this.txtEndDate);
            this.grpQuoteInfo.Controls.Add(this.txtStartDate);
            this.grpQuoteInfo.Controls.Add(this.txtQuoteId);
            this.grpQuoteInfo.Controls.Add(this.lblQuoteId);
            this.grpQuoteInfo.Controls.Add(this.label3);
            this.grpQuoteInfo.Controls.Add(this.lblStartDate);
            this.grpQuoteInfo.Location = new System.Drawing.Point(34, 40);
            this.grpQuoteInfo.Name = "grpQuoteInfo";
            this.grpQuoteInfo.Size = new System.Drawing.Size(231, 165);
            this.grpQuoteInfo.TabIndex = 5;
            this.grpQuoteInfo.TabStop = false;
            this.grpQuoteInfo.Text = "Quote Info";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(68, 118);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndDate.TabIndex = 7;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(68, 70);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartDate.TabIndex = 6;
            // 
            // txtQuoteId
            // 
            this.txtQuoteId.Location = new System.Drawing.Point(68, 28);
            this.txtQuoteId.Name = "txtQuoteId";
            this.txtQuoteId.Size = new System.Drawing.Size(133, 20);
            this.txtQuoteId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 102);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 44);
            this.textBox5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notes :";
            // 
            // grpBidInfo
            // 
            this.grpBidInfo.Controls.Add(this.label4);
            this.grpBidInfo.Controls.Add(this.label5);
            this.grpBidInfo.Controls.Add(this.textBox1);
            this.grpBidInfo.Controls.Add(this.textBox5);
            this.grpBidInfo.Location = new System.Drawing.Point(330, 40);
            this.grpBidInfo.Name = "grpBidInfo";
            this.grpBidInfo.Size = new System.Drawing.Size(310, 165);
            this.grpBidInfo.TabIndex = 10;
            this.grpBidInfo.TabStop = false;
            this.grpBidInfo.Text = "Bid Info";
            // 
            // NewBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 294);
            this.Controls.Add(this.grpBidInfo);
            this.Controls.Add(this.grpQuoteInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "NewBid";
            this.Text = "NewBid";
            this.Load += new System.EventHandler(this.NewBid_Load);
            this.grpQuoteInfo.ResumeLayout(false);
            this.grpQuoteInfo.PerformLayout();
            this.grpBidInfo.ResumeLayout(false);
            this.grpBidInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblQuoteId;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpQuoteInfo;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtQuoteId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpBidInfo;
    }
}