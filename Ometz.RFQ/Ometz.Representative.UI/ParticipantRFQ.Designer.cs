namespace Ometz.Representative.UI
{
    partial class ParticipantRFQ
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
            this.dgvParticipantsInQuote = new System.Windows.Forms.DataGridView();
            this.AddParticipBtn = new System.Windows.Forms.Button();
            this.RemovePartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantsInQuote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dgvParticipantsInQuote
            // 
            this.dgvParticipantsInQuote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantsInQuote.Location = new System.Drawing.Point(28, 43);
            this.dgvParticipantsInQuote.Name = "dgvParticipantsInQuote";
            this.dgvParticipantsInQuote.Size = new System.Drawing.Size(470, 202);
            this.dgvParticipantsInQuote.TabIndex = 1;
            // 
            // AddParticipBtn
            // 
            this.AddParticipBtn.Location = new System.Drawing.Point(111, 280);
            this.AddParticipBtn.Name = "AddParticipBtn";
            this.AddParticipBtn.Size = new System.Drawing.Size(103, 23);
            this.AddParticipBtn.TabIndex = 2;
            this.AddParticipBtn.Text = "Add Participant";
            this.AddParticipBtn.UseVisualStyleBackColor = true;
            this.AddParticipBtn.Click += new System.EventHandler(this.AddParticipBtn_Click);
            // 
            // RemovePartBtn
            // 
            this.RemovePartBtn.Location = new System.Drawing.Point(329, 280);
            this.RemovePartBtn.Name = "RemovePartBtn";
            this.RemovePartBtn.Size = new System.Drawing.Size(117, 23);
            this.RemovePartBtn.TabIndex = 3;
            this.RemovePartBtn.Text = "Remove Participant";
            this.RemovePartBtn.UseVisualStyleBackColor = true;
            this.RemovePartBtn.Click += new System.EventHandler(this.RemovePartBtn_Click);
            // 
            // ParticipantRFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 334);
            this.Controls.Add(this.RemovePartBtn);
            this.Controls.Add(this.AddParticipBtn);
            this.Controls.Add(this.dgvParticipantsInQuote);
            this.Controls.Add(this.label1);
            this.Name = "ParticipantRFQ";
            this.Text = "Participant";
            this.Load += new System.EventHandler(this.ParticipantRFQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantsInQuote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParticipantsInQuote;
        private System.Windows.Forms.Button AddParticipBtn;
        private System.Windows.Forms.Button RemovePartBtn;
    }
}