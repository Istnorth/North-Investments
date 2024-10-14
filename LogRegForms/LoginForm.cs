using North_Investments.ExtraForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace North_Investments
{
    public partial class LoginForm : Form
    {
        private int previousLocationX;
        private int previousLocationY;
        private int previousWidth;
        private int previousHeight;

        public LoginForm(int locationX, int locationY, int width, int height)
        {
            InitializeComponent();
            previousLocationX = locationX;
            previousLocationY = locationY;
            previousWidth = width;
            previousHeight = height;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(previousLocationX, previousLocationY);
            this.Width = previousWidth;
            this.Height = previousHeight;
        }

        private void closeAppLabel_Click(object sender, EventArgs e)
        {
            Program.CloseAllForms();
        }

        private void closeAppLabel_MouseEnter(object sender, EventArgs e)
        {
            closeAppLabel.ForeColor = Color.Red;
        }

        private void closeAppLabel_MouseLeave(object sender, EventArgs e)
        {
            closeAppLabel.ForeColor = Color.White;
        }

        Point lastPos;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPos.X;
                this.Top += e.Y - lastPos.Y;
            }
        }
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = new Point(e.X, e.Y);
        }

        private void portfButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT userId, fio, userBal FROM [dbo].[userD] WHERE login = @Login AND pass = @Pass", con);
                command.Parameters.Add("@Login", SqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox2.Text;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string fio = reader.GetString(1);
                        decimal userBalance = reader.GetDecimal(2);

                        DataSend.text = textBox1.Text;
                        DataSend.userId = userId;
                        DataSend.userBalance = userBalance;

                        ProfileForm profileForm = new ProfileForm(this.Location.X, this.Location.Y, this.Width, this.Height, userBalance);
                        profileForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm regForm = new RegForm(this.Location.X, this.Location.Y, this.Width, this.Height);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            regForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\"D:\\NorthVest.chm\"");
        }
    }
}
