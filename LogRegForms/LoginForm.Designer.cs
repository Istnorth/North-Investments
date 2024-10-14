namespace North_Investments
{
    partial class LoginForm
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
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button portfButton;
        private System.Windows.Forms.LinkLabel linkLabel1;

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.portfButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.authLabel = new System.Windows.Forms.Label();
            this.closeAppLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.portfButton);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.authLabel);
            this.panel1.Location = new System.Drawing.Point(200, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(159, 350);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 16);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "No account?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // portfButton
            // 
            this.portfButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.portfButton.FlatAppearance.BorderSize = 2;
            this.portfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portfButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portfButton.ForeColor = System.Drawing.SystemColors.Control;
            this.portfButton.Location = new System.Drawing.Point(150, 310);
            this.portfButton.Name = "portfButton";
            this.portfButton.Size = new System.Drawing.Size(100, 35);
            this.portfButton.TabIndex = 8;
            this.portfButton.Text = "Log In";
            this.portfButton.Click += new System.EventHandler(this.portfButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(133, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(133, 142);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(210, 25);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(133, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 25);
            this.textBox1.TabIndex = 5;
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passLabel.Location = new System.Drawing.Point(16, 134);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(111, 36);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Location = new System.Drawing.Point(31, 78);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(96, 36);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login";
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
            this.authLabel.Text = "Authorization";
            this.authLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(728, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeAppLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label closeAppLabel;
        private System.Windows.Forms.Button button1;
    }
}