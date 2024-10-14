using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace North_Investments
{
    public partial class RegForm : Form
    {
        private int previousLocationX;
        private int previousLocationY;
        private int previousWidth;
        private int previousHeight;

        public RegForm(int locationX, int locationY, int width, int height)
        {
            InitializeComponent();
            previousLocationX = locationX;
            previousLocationY = locationY;
            previousWidth = width;
            previousHeight = height;
        }

        private void portfButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[userD] (login, pass, fio) VALUES (@Log, @Pass, @Fio)", con);
            command.Parameters.Add("@Log", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@Fio", SqlDbType.VarChar).Value = textBox3.Text;
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Новый пользователь добавлен!");
            RegForm frm = new RegForm(this.Location.X, this.Location.Y, this.Width, this.Height);
            frm.Show();
            this.Hide();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(previousLocationX, previousLocationY);
            this.Width = previousWidth;
            this.Height = previousHeight;
        }

        Point lastPos;
        private void RegForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPos.X;
                this.Top += e.Y - lastPos.Y;
            }
        }
        private void RegForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = new Point(e.X, e.Y);
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


        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this.Location.X, this.Location.Y, this.Width, this.Height);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            loginForm.Show();
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

    }
}
