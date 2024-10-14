namespace North_Investments.ExtraForms
{
    partial class SetPortfolioName
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
            this.inpAmountLabel = new System.Windows.Forms.Label();
            this.doneButton3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inpAmountLabel
            // 
            this.inpAmountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpAmountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.inpAmountLabel.Location = new System.Drawing.Point(55, 21);
            this.inpAmountLabel.Name = "inpAmountLabel";
            this.inpAmountLabel.Size = new System.Drawing.Size(152, 51);
            this.inpAmountLabel.TabIndex = 15;
            this.inpAmountLabel.Text = "Enter Portfolio Name";
            this.inpAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doneButton3
            // 
            this.doneButton3.FlatAppearance.BorderSize = 0;
            this.doneButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.doneButton3.Location = new System.Drawing.Point(90, 128);
            this.doneButton3.Name = "doneButton3";
            this.doneButton3.Size = new System.Drawing.Size(83, 32);
            this.doneButton3.TabIndex = 19;
            this.doneButton3.Text = "Done";
            this.doneButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(60, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetPortfolioName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(270, 190);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.doneButton3);
            this.Controls.Add(this.inpAmountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetPortfolioName";
            this.Text = "SetPortfolioName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inpAmountLabel;
        private System.Windows.Forms.Button doneButton3;
        private System.Windows.Forms.TextBox textBox1;
    }
}