namespace Ometz.Representative.UI
{
    partial class Terminate_RFQ
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
            this.TerminateYesBtn = new System.Windows.Forms.Button();
            this.TerminateNoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to terminate RFQ?";
            // 
            // TerminateYesBtn
            // 
            this.TerminateYesBtn.Location = new System.Drawing.Point(46, 61);
            this.TerminateYesBtn.Name = "TerminateYesBtn";
            this.TerminateYesBtn.Size = new System.Drawing.Size(66, 23);
            this.TerminateYesBtn.TabIndex = 1;
            this.TerminateYesBtn.Text = "Yes";
            this.TerminateYesBtn.UseVisualStyleBackColor = true;
            this.TerminateYesBtn.Click += new System.EventHandler(this.TerminateYesBtn_Click_1);
            // 
            // TerminateNoBtn
            // 
            this.TerminateNoBtn.Location = new System.Drawing.Point(198, 61);
            this.TerminateNoBtn.Name = "TerminateNoBtn";
            this.TerminateNoBtn.Size = new System.Drawing.Size(62, 23);
            this.TerminateNoBtn.TabIndex = 2;
            this.TerminateNoBtn.Text = "No";
            this.TerminateNoBtn.UseVisualStyleBackColor = true;
            this.TerminateNoBtn.Click += new System.EventHandler(this.TerminateNoBtn_Click_1);
            // 
            // Terminate_RFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 103);
            this.Controls.Add(this.TerminateNoBtn);
            this.Controls.Add(this.TerminateYesBtn);
            this.Controls.Add(this.label1);
            this.Name = "Terminate_RFQ";
            this.Text = "Terminate_RFQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TerminateYesBtn;
        private System.Windows.Forms.Button TerminateNoBtn;
    }
}