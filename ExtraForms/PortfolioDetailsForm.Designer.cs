namespace North_Investments
{
    partial class PortfolioDetailsForm
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
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.doneButton3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.makeReportButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.daysLabel = new System.Windows.Forms.Label();
            this.sellButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalValueLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalValueLabel.Location = new System.Drawing.Point(12, 5);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(376, 50);
            this.totalValueLabel.TabIndex = 15;
            this.totalValueLabel.Text = "Total Value";
            this.totalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doneButton3
            // 
            this.doneButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.doneButton3.FlatAppearance.BorderSize = 0;
            this.doneButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.doneButton3.Location = new System.Drawing.Point(155, 235);
            this.doneButton3.Name = "doneButton3";
            this.doneButton3.Size = new System.Drawing.Size(83, 32);
            this.doneButton3.TabIndex = 19;
            this.doneButton3.Text = "Done";
            this.doneButton3.UseVisualStyleBackColor = false;
            this.doneButton3.Click += new System.EventHandler(this.doneButton3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(376, 170);
            this.flowLayoutPanel1.TabIndex = 20;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // makeReportButton
            // 
            this.makeReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.makeReportButton.FlatAppearance.BorderSize = 0;
            this.makeReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeReportButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeReportButton.ForeColor = System.Drawing.SystemColors.Control;
            this.makeReportButton.Location = new System.Drawing.Point(125, 270);
            this.makeReportButton.Name = "makeReportButton";
            this.makeReportButton.Size = new System.Drawing.Size(144, 32);
            this.makeReportButton.TabIndex = 21;
            this.makeReportButton.Text = "Make Report";
            this.makeReportButton.UseVisualStyleBackColor = false;
            this.makeReportButton.Click += new System.EventHandler(this.makeReportButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 308);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 22);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // daysLabel
            // 
            this.daysLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.daysLabel.Location = new System.Drawing.Point(211, 305);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(71, 25);
            this.daysLabel.TabIndex = 23;
            this.daysLabel.Text = "days";
            this.daysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sellButton1
            // 
            this.sellButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sellButton1.FlatAppearance.BorderSize = 0;
            this.sellButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.sellButton1.Location = new System.Drawing.Point(125, 371);
            this.sellButton1.Name = "sellButton1";
            this.sellButton1.Size = new System.Drawing.Size(144, 32);
            this.sellButton1.TabIndex = 24;
            this.sellButton1.Text = "Sell Portfolio";
            this.sellButton1.UseVisualStyleBackColor = false;
            this.sellButton1.Click += new System.EventHandler(this.sellButton1_Click);
            // 
            // PortfolioDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(400, 415);
            this.Controls.Add(this.sellButton1);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.makeReportButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.doneButton3);
            this.Controls.Add(this.totalValueLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PortfolioDetailsForm";
            this.Text = "SetPortfolioName";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Button doneButton3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button makeReportButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Button sellButton1;
    }
}