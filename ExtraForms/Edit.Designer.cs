namespace North_Investments.ExtraForms
{
    partial class Edit
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button portfButton;

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.portfButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.authLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.portfButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.authLabel);
            this.panel1.Location = new System.Drawing.Point(100, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 365);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(162, 145);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(210, 25);
            this.textBox2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(150, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(162, 222);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 25);
            this.textBox3.TabIndex = 12;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Location = new System.Drawing.Point(29, 211);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 36);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Full name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // portfButton
            // 
            this.portfButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.portfButton.FlatAppearance.BorderSize = 2;
            this.portfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portfButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portfButton.ForeColor = System.Drawing.SystemColors.Control;
            this.portfButton.Location = new System.Drawing.Point(150, 272);
            this.portfButton.Name = "portfButton";
            this.portfButton.Size = new System.Drawing.Size(100, 35);
            this.portfButton.TabIndex = 8;
            this.portfButton.Text = "Edit";
            this.portfButton.Click += new System.EventHandler(this.portfButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(162, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 25);
            this.textBox1.TabIndex = 5;
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passLabel.Location = new System.Drawing.Point(-22, 137);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(178, 36);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "New Password";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Location = new System.Drawing.Point(29, 78);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(127, 36);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "New Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // authLabel
            // 
            this.authLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.authLabel.Location = new System.Drawing.Point(100, 10);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(190, 36);
            this.authLabel.TabIndex = 2;
            this.authLabel.Text = "Edit Profile";
            this.authLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Edit_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Edit_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label passLabel;
    }
}