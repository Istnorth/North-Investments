using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace North_Investments
{
    public partial class HomePageForm : Form
    {
        private int previousLocationX;
        private int previousLocationY;
        private int previousWidth;
        private int previousHeight;
        private int userId;

        public HomePageForm(int locationX, int locationY, int width, int height, int userId)
        {
            InitializeComponent();
            previousLocationX = locationX;
            previousLocationY = locationY;
            previousWidth = width;
            previousHeight = height;
            this.userId = userId;
            LoadUserTransactions();
            LoadAssetPriceHistory();

        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(previousLocationX, previousLocationY);
            this.Width = previousWidth;
            this.Height = previousHeight;
        }

        private void LoadUserTransactions()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Amount, TransactionDate FROM UserTransactions WHERE UserId = @UserId ORDER BY TransactionDate", con);
                cmd.Parameters.AddWithValue("@UserId", userId);
                SqlDataReader reader = cmd.ExecuteReader();

                chart1.Series.Clear();
                Series series = new Series("Balance");
                series.ChartType = SeriesChartType.Line;
                chart1.Series.Add(series);

                while (reader.Read())
                {
                    decimal amount = (decimal)reader["Amount"];
                    DateTime transactionDate = (DateTime)reader["TransactionDate"];
                    series.Points.AddXY(transactionDate, amount);
                }

                con.Close();
            }
        }

        private void LoadAssetPriceHistory()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT AssetId FROM Assets WHERE Name = 'Ethereum'", con);
                int ethereumAssetId = (int)cmd.ExecuteScalar();

                SqlCommand cmdHistory = new SqlCommand("SELECT Price, RecordedDate FROM AssetPriceHistory WHERE AssetId = @AssetId ORDER BY RecordedDate", con);
                cmdHistory.Parameters.AddWithValue("@AssetId", ethereumAssetId);
                SqlDataReader reader = cmdHistory.ExecuteReader();

                chart2.Series.Clear();
                Series series = new Series("Ethereum Price");
                series.ChartType = SeriesChartType.Line;
                chart2.Series.Add(series);

                while (reader.Read())
                {
                    decimal price = (decimal)reader["Price"];
                    DateTime recordedDate = (DateTime)reader["RecordedDate"];
                    series.Points.AddXY(recordedDate, price);
                }
                con.Close();
            }
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
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPos.X;
                this.Top += e.Y - lastPos.Y;
            }
        }
        private void HomePageForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = new Point(e.X, e.Y);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this.Location.X, this.Location.Y, this.Width, this.Height, DataSend.userId);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            searchForm.Show();
            this.Hide();
        }

        private void profileButton_Click_1(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(this.Location.X, this.Location.Y, this.Width, this.Height, DataSend.userBalance);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            profileForm.Show();
            this.Hide();
        }

        private void portfButton_Click(object sender, EventArgs e)
        {
            PortfoliosForm portfolios = new PortfoliosForm(this.Location.X, this.Location.Y, this.Width, this.Height, DataSend.userId);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            portfolios.Show();
            this.Hide();
        }
    }
}
