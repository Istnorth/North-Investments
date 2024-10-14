namespace North_Investments.ExtraForms
{
    partial class AssetAmountForm
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.inpAmountLabel = new System.Windows.Forms.Label();
            this.doneButton3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(75, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 18);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inpAmountLabel
            // 
            this.inpAmountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpAmountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.inpAmountLabel.Location = new System.Drawing.Point(58, 21);
            this.inpAmountLabel.Name = "inpAmountLabel";
            this.inpAmountLabel.Size = new System.Drawing.Size(152, 36);
            this.inpAmountLabel.TabIndex = 15;
            this.inpAmountLabel.Text = "Choose Amount";
            this.inpAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doneButton3
            // 
            this.doneButton3.FlatAppearance.BorderSize = 0;
            this.doneButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.doneButton3.Location = new System.Drawing.Point(55, 130);
            this.doneButton3.Name = "doneButton3";
            this.doneButton3.Size = new System.Drawing.Size(162, 32);
            this.doneButton3.TabIndex = 19;
            this.doneButton3.Text = "Done";
            this.doneButton3.UseVisualStyleBackColor = true;
            // 
            // AssetAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(270, 190);
            this.Controls.Add(this.doneButton3);
            this.Controls.Add(this.inpAmountLabel);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssetAmountForm";
            this.Text = "AssetAmountForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label inpAmountLabel;
        private System.Windows.Forms.Button doneButton3;
    }
}