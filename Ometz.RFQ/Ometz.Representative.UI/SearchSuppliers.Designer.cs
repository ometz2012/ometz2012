namespace Ometz.Representative.UI
{
    partial class SearchSuppliers
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
            this.gridSuppliers = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLoadSuppliers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Just For Testing";
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSuppliers.Location = new System.Drawing.Point(52, 53);
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.Size = new System.Drawing.Size(465, 48);
            this.gridSuppliers.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonLoadSuppliers
            // 
            this.buttonLoadSuppliers.Location = new System.Drawing.Point(216, 118);
            this.buttonLoadSuppliers.Name = "buttonLoadSuppliers";
            this.buttonLoadSuppliers.Size = new System.Drawing.Size(123, 23);
            this.buttonLoadSuppliers.TabIndex = 3;
            this.buttonLoadSuppliers.Text = "Load Suppliers";
            this.buttonLoadSuppliers.UseVisualStyleBackColor = true;
            this.buttonLoadSuppliers.Click += new System.EventHandler(this.buttonLoadSuppliers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please Enter Customer\'s Name Or ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SearchSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoadSuppliers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridSuppliers);
            this.Controls.Add(this.label1);
            this.Name = "SearchSuppliers";
            this.Text = "SearchSuppliers";
            this.Load += new System.EventHandler(this.SearchSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridSuppliers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonLoadSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}