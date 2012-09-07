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
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.tableCreateRFQ = new System.Windows.Forms.TableLayoutPanel();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
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
            this.QuantityLbl.Location = new System.Drawing.Point(216, 6);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(51, 26);
            this.QuantityLbl.TabIndex = 1;
            this.QuantityLbl.Text = "Quantity\r\n[Decimal]";
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(290, 6);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(85, 26);
            this.StartDateLbl.TabIndex = 2;
            this.StartDateLbl.Text = "   Start Date\r\n(YYYY/MM/DD)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "   End Date\r\n(YYYY/MM/DD)";
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(383, 42);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(92, 20);
            this.textBoxEndDate.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDescription.Location = new System.Drawing.Point(4, 42);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(190, 20);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(201, 42);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(81, 20);
            this.textBoxQuantity.TabIndex = 6;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxStartDate.Location = new System.Drawing.Point(289, 42);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(87, 20);
            this.textBoxStartDate.TabIndex = 7;
            // 
            // tableCreateRFQ
            // 
            this.tableCreateRFQ.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableCreateRFQ.ColumnCount = 4;
            this.tableCreateRFQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.10299F));
            this.tableCreateRFQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.89701F));
            this.tableCreateRFQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableCreateRFQ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableCreateRFQ.Controls.Add(this.textBoxDescription, 0, 1);
            this.tableCreateRFQ.Controls.Add(this.label4, 3, 0);
            this.tableCreateRFQ.Controls.Add(this.StartDateLbl, 2, 0);
            this.tableCreateRFQ.Controls.Add(this.textBoxStartDate, 2, 1);
            this.tableCreateRFQ.Controls.Add(this.textBoxQuantity, 1, 1);
            this.tableCreateRFQ.Controls.Add(this.QuantityLbl, 1, 0);
            this.tableCreateRFQ.Controls.Add(this.DescriptionLbl, 0, 0);
            this.tableCreateRFQ.Controls.Add(this.textBoxEndDate, 3, 1);
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
            this.DescriptionLbl.Location = new System.Drawing.Point(69, 13);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLbl.TabIndex = 8;
            this.DescriptionLbl.Text = "Description";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(434, 117);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(353, 117);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(272, 117);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // CreateRFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 152);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCancel);
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
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TableLayoutPanel tableCreateRFQ;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCreate;
    }
}