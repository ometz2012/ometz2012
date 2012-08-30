namespace Ometz.Supplier.UI
{
    partial class Form1
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
            this.btnShowBids = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBidsInfo
            // 
            this.dgvBidsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBidsInfo.Location = new System.Drawing.Point(12, 25);
            this.dgvBidsInfo.Name = "dgvBidsInfo";
            this.dgvBidsInfo.Size = new System.Drawing.Size(240, 150);
            this.dgvBidsInfo.TabIndex = 0;
            // 
            // btnShowBids
            // 
            this.btnShowBids.Location = new System.Drawing.Point(181, 207);
            this.btnShowBids.Name = "btnShowBids";
            this.btnShowBids.Size = new System.Drawing.Size(75, 23);
            this.btnShowBids.TabIndex = 1;
            this.btnShowBids.Text = "ShowBids";
            this.btnShowBids.UseVisualStyleBackColor = true;
            this.btnShowBids.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 263);
            this.Controls.Add(this.btnShowBids);
            this.Controls.Add(this.dgvBidsInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBidsInfo;
        private System.Windows.Forms.Button btnShowBids;
    }
}

