namespace Ometz.Representative.UI
{
    partial class CreateRFQ
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDateTxt = new System.Windows.Forms.TextBox();
            this.DescriptionValueTxt = new System.Windows.Forms.TextBox();
            this.QuantityAmountTxt = new System.Windows.Forms.TextBox();
            this.StartDateTxt = new System.Windows.Forms.TextBox();
            this.tableCreateRFQ = new System.Windows.Forms.TableLayoutPanel();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.tableCreateRFQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(230, 13);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(46, 13);
            this.QuantityLbl.TabIndex = 1;
            this.QuantityLbl.Text = "Quantity";
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(319, 13);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(55, 13);
            this.StartDateLbl.TabIndex = 2;
            this.StartDateLbl.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date";
            // 
            // EndDateTxt
            // 
            this.EndDateTxt.Location = new System.Drawing.Point(397, 42);
            this.EndDateTxt.Name = "EndDateTxt";
            this.EndDateTxt.Size = new System.Drawing.Size(92, 20);
            this.EndDateTxt.TabIndex = 4;
            // 
            // DescriptionValueTxt
            // 
            this.DescriptionValueTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescriptionValueTxt.Location = new System.Drawing.Point(5, 42);
            this.DescriptionValueTxt.Name = "DescriptionValueTxt";
            this.DescriptionValueTxt.Size = new System.Drawing.Size(197, 20);
            this.DescriptionValueTxt.TabIndex = 5;
            // 
            // QuantityAmountTxt
            // 
            this.QuantityAmountTxt.Location = new System.Drawing.Point(210, 42);
            this.QuantityAmountTxt.Name = "QuantityAmountTxt";
            this.QuantityAmountTxt.Size = new System.Drawing.Size(86, 20);
            this.QuantityAmountTxt.TabIndex = 6;
            // 
            // StartDateTxt
            // 
            this.StartDateTxt.BackColor = System.Drawing.SystemColors.Window;
            this.StartDateTxt.Location = new System.Drawing.Point(303, 42);
            this.StartDateTxt.Name = "StartDateTxt";
            this.StartDateTxt.Size = new System.Drawing.Size(87, 20);
            this.StartDateTxt.TabIndex = 7;
            // 
            // tableCreateRFQ
            // 
            this.tableCreateRFQ.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableCreateRFQ.ColumnCount = 4;
            this.tableCreateRFQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.10299F));
            this.tableCreateRFQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.89701F));
            this.tableCreateRFQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableCreateRFQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableCreateRFQ.Controls.Add(this.DescriptionValueTxt, 0, 1);
            this.tableCreateRFQ.Controls.Add(this.label4, 3, 0);
            this.tableCreateRFQ.Controls.Add(this.StartDateLbl, 2, 0);
            this.tableCreateRFQ.Controls.Add(this.StartDateTxt, 2, 1);
            this.tableCreateRFQ.Controls.Add(this.QuantityAmountTxt, 1, 1);
            this.tableCreateRFQ.Controls.Add(this.QuantityLbl, 1, 0);
            this.tableCreateRFQ.Controls.Add(this.DescriptionLbl, 0, 0);
            this.tableCreateRFQ.Controls.Add(this.EndDateTxt, 3, 1);
            this.tableCreateRFQ.Location = new System.Drawing.Point(12, 24);
            this.tableCreateRFQ.Name = "tableCreateRFQ";
            this.tableCreateRFQ.RowCount = 2;
            this.tableCreateRFQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableCreateRFQ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableCreateRFQ.Size = new System.Drawing.Size(495, 79);
            this.tableCreateRFQ.TabIndex = 8;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(73, 13);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLbl.TabIndex = 8;
            this.DescriptionLbl.Text = "Description";
            // 
            // CreateRFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 115);
            this.Controls.Add(this.tableCreateRFQ);
            this.Controls.Add(this.label1);
            this.Name = "CreateRFQ";
            this.Text = "CreateRFQ";
            this.tableCreateRFQ.ResumeLayout(false);
            this.tableCreateRFQ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EndDateTxt;
        private System.Windows.Forms.TextBox DescriptionValueTxt;
        private System.Windows.Forms.TextBox QuantityAmountTxt;
        private System.Windows.Forms.TextBox StartDateTxt;
        private System.Windows.Forms.TableLayoutPanel tableCreateRFQ;
        private System.Windows.Forms.Label DescriptionLbl;
    }
}