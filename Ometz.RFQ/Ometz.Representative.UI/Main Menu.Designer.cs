namespace Ometz.Representative.UI
{
    partial class MainMenu
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
            this.CompanyNameLbl = new System.Windows.Forms.Label();
            this.QuotesLbl = new System.Windows.Forms.Label();
            this.SuppliersLbl = new System.Windows.Forms.Label();
            this.dataGridQuote = new System.Windows.Forms.DataGridView();
            this.CreateRFQBtn = new System.Windows.Forms.Button();
            this.ParticipantBtn = new System.Windows.Forms.Button();
            this.TerminateRFQBtn = new System.Windows.Forms.Button();
            this.RFQWinnersBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SearchSupplBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchQuoteBtn = new System.Windows.Forms.Button();
            this.AddQuotDetailBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuote)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyNameLbl
            // 
            this.CompanyNameLbl.AutoSize = true;
            this.CompanyNameLbl.Location = new System.Drawing.Point(38, 19);
            this.CompanyNameLbl.Name = "CompanyNameLbl";
            this.CompanyNameLbl.Size = new System.Drawing.Size(35, 13);
            this.CompanyNameLbl.TabIndex = 0;
            this.CompanyNameLbl.Text = "label1";
            // 
            // QuotesLbl
            // 
            this.QuotesLbl.AutoSize = true;
            this.QuotesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuotesLbl.Location = new System.Drawing.Point(181, 43);
            this.QuotesLbl.Name = "QuotesLbl";
            this.QuotesLbl.Size = new System.Drawing.Size(81, 25);
            this.QuotesLbl.TabIndex = 1;
            this.QuotesLbl.Text = "Quotes";
            // 
            // SuppliersLbl
            // 
            this.SuppliersLbl.AutoSize = true;
            this.SuppliersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersLbl.Location = new System.Drawing.Point(781, 43);
            this.SuppliersLbl.Name = "SuppliersLbl";
            this.SuppliersLbl.Size = new System.Drawing.Size(102, 25);
            this.SuppliersLbl.TabIndex = 2;
            this.SuppliersLbl.Text = "Suppliers";
            // 
            // dataGridQuote
            // 
            this.dataGridQuote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuote.Location = new System.Drawing.Point(3, 80);
            this.dataGridQuote.Name = "dataGridQuote";
            this.dataGridQuote.Size = new System.Drawing.Size(586, 324);
            this.dataGridQuote.TabIndex = 3;
            this.dataGridQuote.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClick);
            // 
            // CreateRFQBtn
            // 
            this.CreateRFQBtn.Location = new System.Drawing.Point(609, 92);
            this.CreateRFQBtn.Name = "CreateRFQBtn";
            this.CreateRFQBtn.Size = new System.Drawing.Size(92, 23);
            this.CreateRFQBtn.TabIndex = 4;
            this.CreateRFQBtn.Text = "Create RFQ\r\n";
            this.CreateRFQBtn.UseVisualStyleBackColor = true;
            this.CreateRFQBtn.Click += new System.EventHandler(this.CreateRFQBtn_Click);
            // 
            // ParticipantBtn
            // 
            this.ParticipantBtn.Location = new System.Drawing.Point(609, 172);
            this.ParticipantBtn.Name = "ParticipantBtn";
            this.ParticipantBtn.Size = new System.Drawing.Size(100, 23);
            this.ParticipantBtn.TabIndex = 5;
            this.ParticipantBtn.Text = "Participants";
            this.ParticipantBtn.UseVisualStyleBackColor = true;
            this.ParticipantBtn.Click += new System.EventHandler(this.ParticipantBtn_Click);
            // 
            // TerminateRFQBtn
            // 
            this.TerminateRFQBtn.Location = new System.Drawing.Point(610, 214);
            this.TerminateRFQBtn.Name = "TerminateRFQBtn";
            this.TerminateRFQBtn.Size = new System.Drawing.Size(100, 23);
            this.TerminateRFQBtn.TabIndex = 6;
            this.TerminateRFQBtn.Text = "Terminate RFQ";
            this.TerminateRFQBtn.UseVisualStyleBackColor = true;
            this.TerminateRFQBtn.Click += new System.EventHandler(this.TerminateRFQBtn_Click);
            // 
            // RFQWinnersBtn
            // 
            this.RFQWinnersBtn.Location = new System.Drawing.Point(609, 256);
            this.RFQWinnersBtn.Name = "RFQWinnersBtn";
            this.RFQWinnersBtn.Size = new System.Drawing.Size(100, 23);
            this.RFQWinnersBtn.TabIndex = 7;
            this.RFQWinnersBtn.Text = "RFQ\'s Winners";
            this.RFQWinnersBtn.UseVisualStyleBackColor = true;
            this.RFQWinnersBtn.Click += new System.EventHandler(this.RFQWinnersBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(610, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(630, 324);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(57, 26);
            this.SearchLbl.TabIndex = 9;
            this.SearchLbl.Text = "( by  # ID )\r\n\r\n";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(744, 80);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(193, 324);
            this.treeView1.TabIndex = 10;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(943, 92);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(88, 23);
            this.CreateBtn.TabIndex = 11;
            this.CreateBtn.Text = "Create ";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(943, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 20);
            this.textBox2.TabIndex = 12;
            // 
            // SearchSupplBtn
            // 
            this.SearchSupplBtn.Location = new System.Drawing.Point(952, 205);
            this.SearchSupplBtn.Name = "SearchSupplBtn";
            this.SearchSupplBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchSupplBtn.TabIndex = 13;
            this.SearchSupplBtn.Text = "Search";
            this.SearchSupplBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(949, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "(by # ID or Name)";
            // 
            // SearchQuoteBtn
            // 
            this.SearchQuoteBtn.Location = new System.Drawing.Point(623, 353);
            this.SearchQuoteBtn.Name = "SearchQuoteBtn";
            this.SearchQuoteBtn.Size = new System.Drawing.Size(78, 23);
            this.SearchQuoteBtn.TabIndex = 15;
            this.SearchQuoteBtn.Text = "Search";
            this.SearchQuoteBtn.UseVisualStyleBackColor = true;
            this.SearchQuoteBtn.Click += new System.EventHandler(this.SearchQuoteBtn_Click);
            // 
            // AddQuotDetailBtn
            // 
            this.AddQuotDetailBtn.Location = new System.Drawing.Point(609, 130);
            this.AddQuotDetailBtn.Name = "AddQuotDetailBtn";
            this.AddQuotDetailBtn.Size = new System.Drawing.Size(100, 23);
            this.AddQuotDetailBtn.TabIndex = 16;
            this.AddQuotDetailBtn.Text = "Add Quote Detail";
            this.AddQuotDetailBtn.UseVisualStyleBackColor = true;
            this.AddQuotDetailBtn.Click += new System.EventHandler(this.AddQuotDetailBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 416);
            this.Controls.Add(this.AddQuotDetailBtn);
            this.Controls.Add(this.SearchQuoteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchSupplBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RFQWinnersBtn);
            this.Controls.Add(this.TerminateRFQBtn);
            this.Controls.Add(this.ParticipantBtn);
            this.Controls.Add(this.CreateRFQBtn);
            this.Controls.Add(this.dataGridQuote);
            this.Controls.Add(this.SuppliersLbl);
            this.Controls.Add(this.QuotesLbl);
            this.Controls.Add(this.CompanyNameLbl);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLbl;
        private System.Windows.Forms.Label QuotesLbl;
        private System.Windows.Forms.Label SuppliersLbl;
        private System.Windows.Forms.DataGridView dataGridQuote;
        private System.Windows.Forms.Button CreateRFQBtn;
        private System.Windows.Forms.Button ParticipantBtn;
        private System.Windows.Forms.Button TerminateRFQBtn;
        private System.Windows.Forms.Button RFQWinnersBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SearchSupplBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchQuoteBtn;
        private System.Windows.Forms.Button AddQuotDetailBtn;
    }
}

