using North_Investments.ExtraForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace North_Investments
{
    public partial class ProfileForm : Form
    {
        private int previousLocationX;
        private int previousLocationY;
        private int previousWidth;
        private int previousHeight;
        private decimal userBalance;

        public ProfileForm(int locationX, int locationY, int width, int height, decimal balance)
        {
            InitializeComponent();
            previousLocationX = locationX;
            previousLocationY = locationY;
            previousWidth = width;
            previousHeight = height;
            userBalance = balance;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(previousLocationX, previousLocationY);
            this.Width = previousWidth;
            this.Height = previousHeight;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True");
            string Sql = $"select fio from [dbo].[userD] where login = '{DataSend.text}'";
            SqlCommand scmd = new SqlCommand(Sql, con);
            con.Open();
            SqlDataReader sur = scmd.ExecuteReader();
            while (sur.Read())
            {
                string fio = sur["fio"].ToString();
                label2.Text = fio;
            }
            con.Close();

            userBalance = GetUserBalance();
            balancelabel.Text = $"{userBalance:F2}";

            
            LoadTransactionHistory();
        }

        private decimal GetUserBalance()
        {
            decimal balance = 0;

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT userBal FROM userD WHERE UserId = @UserId", con);
                cmd.Parameters.AddWithValue("@UserId", DataSend.userId);
                balance = (decimal)cmd.ExecuteScalar();
                con.Close();
            }

            return balance;
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
        private void HomePageForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPos.X;
                this.Top += e.Y - lastPos.Y;
            }
        }
        private void HomePageForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = new Point(e.X, e.Y);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm(this.Location.X, this.Location.Y, this.Width, this.Height, DataSend.userId);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            homePageForm.Show();
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this.Location.X, this.Location.Y, this.Width, this.Height, DataSend.userId);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            searchForm.Show();
            this.Close();
        }

        private void portfButton_Click(object sender, EventArgs e)
        {
            PortfoliosForm portfolios = new PortfoliosForm(this.Location.X, this.Location.Y, this.Width, this.Height, DataSend.userId);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            portfolios.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this.Location.X, this.Location.Y, this.Width, this.Height);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            loginForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult MBresult = MessageBox.Show("Вы действительно хотите удалить текущего пользователя?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBresult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();
                        string deleteSql = $"DELETE FROM [dbo].[userD] WHERE login = '{DataSend.text}'";
                        SqlCommand deleteCmd = new SqlCommand(deleteSql, con);
                        deleteCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении пользователя: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                LoginForm loginForm = new LoginForm(this.Location.X, this.Location.Y, this.Width, this.Height);
                previousLocationX = this.Location.X;
                previousLocationY = this.Location.Y;
                previousWidth = this.Width;
                previousHeight = this.Height;
                loginForm.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit editForm = new Edit();
            editForm.Show();
        }

        private void addBalButton_Click(object sender, EventArgs e)
        {
            AddBalForm addBalForm = new AddBalForm();
            addBalForm.Show();
        }

        private void LoadTransactionHistory()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                string query = "SELECT TransactionType, Amount, TransactionDate FROM UserTransactions WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", DataSend.userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string transactionType = reader["TransactionType"].ToString();
                    decimal amount = (decimal)reader["Amount"];
                    DateTime transactionDate = (DateTime)reader["TransactionDate"];

                    Panel transactionPanel = new Panel
                    {
                        Size = new Size(100, 50),
                        BorderStyle = BorderStyle.None,
                        BackColor = Color.FromArgb(22, 22, 22),
                        Margin = new Padding(10)
                    };

                    Label typeLabel = new Label
                    {
                        Text = transactionType,
                        Location = new Point(10, 5),
                        Size = new Size(80, 15),
                        ForeColor = SystemColors.Control
                    };

                    Label amountLabel = new Label
                    {
                        Text = $"{amount:F2}",
                        Location = new Point(10, 20),
                        Size = new Size(80, 15),
                        ForeColor = SystemColors.Control
                    };

                    Label dateLabel = new Label
                    {
                        Text = transactionDate.ToShortDateString(),
                        Location = new Point(10, 35),
                        Size = new Size(80, 15),
                        ForeColor = SystemColors.Control
                    };

                    transactionPanel.Controls.Add(typeLabel);
                    transactionPanel.Controls.Add(amountLabel);
                    transactionPanel.Controls.Add(dateLabel);
                    flowLayoutPanel1.Controls.Add(transactionPanel);
                }

                reader.Close();
                con.Close();
            }
        }
    }
}
