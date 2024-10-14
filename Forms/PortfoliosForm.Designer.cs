namespace North_Investments
{
    partial class PortfoliosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfoliosForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeAppLabel = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.portfButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yourPortfLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.closeAppLabel);
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.portfButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 450);
            this.panel1.TabIndex = 0;
            // 
            // closeAppLabel
            // 
            this.closeAppLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeAppLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.closeAppLabel.Location = new System.Drawing.Point(8, 414);
            this.closeAppLabel.Name = "closeAppLabel";
            this.closeAppLabel.Size = new System.Drawing.Size(96, 36);
            this.closeAppLabel.TabIndex = 10;
            this.closeAppLabel.Text = "Close App";
            this.closeAppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeAppLabel.Click += new System.EventHandler(this.closeAppLabel_Click);
            this.closeAppLabel.MouseEnter += new System.EventHandler(this.closeAppLabel_MouseEnter);
            this.closeAppLabel.MouseLeave += new System.EventHandler(this.closeAppLabel_MouseLeave);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileButton.ForeColor = System.Drawing.SystemColors.Control;
            this.profileButton.Location = new System.Drawing.Point(50, 379);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(99, 32);
            this.profileButton.TabIndex = 8;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(12, 379);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // portfButton
            // 
            this.portfButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.portfButton.FlatAppearance.BorderSize = 0;
            this.portfButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.portfButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.portfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portfButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portfButton.ForeColor = System.Drawing.SystemColors.Control;
            this.portfButton.Location = new System.Drawing.Point(50, 115);
            this.portfButton.Name = "portfButton";
            this.portfButton.Size = new System.Drawing.Size(99, 32);
            this.portfButton.TabIndex = 6;
            this.portfButton.Text = "Portfolios";
            this.portfButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(50, 77);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(99, 32);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.homeButton.Location = new System.Drawing.Point(50, 39);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(99, 32);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(12, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(12, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "NorthVest";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yourPortfLabel
            // 
            this.yourPortfLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourPortfLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.yourPortfLabel.Location = new System.Drawing.Point(159, 1);
            this.yourPortfLabel.Name = "yourPortfLabel";
            this.yourPortfLabel.Size = new System.Drawing.Size(137, 36);
            this.yourPortfLabel.TabIndex = 13;
            this.yourPortfLabel.Text = "Your Portfolios";
            this.yourPortfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(163, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 147);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // PortfoliosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.yourPortfLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PortfoliosForm";
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.Portfolios_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePageForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePageForm_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button portfButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label closeAppLabel;
        private System.Windows.Forms.Label yourPortfLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}