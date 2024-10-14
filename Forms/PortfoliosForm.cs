using North_Investments.ExtraForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace North_Investments
{
    public partial class PortfoliosForm : Form
    {
        private int previousLocationX;
        private int previousLocationY;
        private int previousWidth;
        private int previousHeight;
        private int userId;

        public PortfoliosForm(int locationX, int locationY, int width, int height, int userId)
        {
            InitializeComponent();
            previousLocationX = locationX;
            previousLocationY = locationY;
            previousWidth = width;
            previousHeight = height;
            this.userId = userId;
        }

        private void Portfolios_Load(object sender, EventArgs e)
        {
            this.Location = new Point(previousLocationX, previousLocationY);
            this.Width = previousWidth;
            this.Height = previousHeight;
            LoadPortfolios();
        }

        private void LoadPortfolios()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT PortfolioId, PortfolioName FROM Portfolios WHERE UserId = @UserId", con);
                cmd.Parameters.AddWithValue("@UserId", userId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int portfolioId = (int)reader["PortfolioId"];
                    string portfolioName = reader["PortfolioName"].ToString();
                    AddPortfolioToPanel(portfolioId, portfolioName);
                }

                con.Close();
            }
        }

        private void AddPortfolioToPanel(int portfolioId, string portfolioName)
        {
            Panel portfolioPanel = new Panel
            {
                Size = new Size(250, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(22, 22, 22),
                Margin = new Padding(10)
            };

            Label nameLabel = new Label
            {
                Text = portfolioName,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                ForeColor = Color.White,
                Height = 50
            };

            Button detailsButton = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Text = "Details",
                Dock = DockStyle.Bottom,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(66, 66, 66),
                Height = 30
            };

            detailsButton.Click += (s, e) => OpenPortfolioDetails(portfolioId);

            portfolioPanel.Controls.Add(nameLabel);
            portfolioPanel.Controls.Add(detailsButton);

            flowLayoutPanel1.Controls.Add(portfolioPanel);
        }

        private void OpenPortfolioDetails(int portfolioId)
        {
            PortfolioDetailsForm portfolioDetailsForm = new PortfolioDetailsForm(portfolioId, userId);
            portfolioDetailsForm.Show();
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
            this.Hide();
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

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(this.Location.X, this.Location.Y, this.Width, this.Height, DataSend.userBalance);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            profileForm.Show();
            this.Hide();
        }
    }
}
