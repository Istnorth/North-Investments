using North_Investments.ExtraForms;
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

namespace North_Investments
{
    public partial class SearchForm : Form
    {
        private int previousLocationX;
        private int previousLocationY;
        private int previousWidth;
        private int previousHeight;
        private int userId;
        private Dictionary<int, int> selectedAssets;

        public SearchForm(int locationX, int locationY, int width, int height, int userId)
        {
            InitializeComponent();
            previousLocationX = locationX;
            previousLocationY = locationY;
            previousWidth = width;
            previousHeight = height;
            this.userId = userId;
            selectedAssets = new Dictionary<int, int>();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(previousLocationX, previousLocationY);
            this.Width = previousWidth;
            this.Height = previousHeight;
            LoadAssets();
        }

        private void LoadAssets()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                LoadAssetsFromDatabase(con, "SELECT AssetId, Name, Price FROM Assets WHERE Type = 'Security'", flowLayoutPanel1);
                LoadAssetsFromDatabase(con, "SELECT AssetId, Name, Price FROM Assets WHERE Type = 'Stock'", flowLayoutPanel2);
                LoadAssetsFromDatabase(con, "SELECT AssetId, Name, Price FROM Assets WHERE Type = 'Cryptocurrency'", flowLayoutPanel3);
                con.Close();
            }
        }

        private decimal GetUserBalance()
        {
            decimal balance = 0;

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT userBal FROM userD WHERE UserId = @UserId", con);
                cmd.Parameters.AddWithValue("@UserId", userId);

                balance = (decimal)cmd.ExecuteScalar();

                con.Close();
            }

            return balance;
        }

        private void UpdateUserBalance(decimal newBalance)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE userD SET userBal = @userBal WHERE UserId = @UserId", con);
                cmd.Parameters.AddWithValue("@userBal", newBalance);
                cmd.Parameters.AddWithValue("@UserId", userId);

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        private void LoadAssetsFromDatabase(SqlConnection con, string query, FlowLayoutPanel panel)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int assetId = (int)reader["AssetId"];
                string assetName = reader["Name"].ToString();
                decimal price = (decimal)reader["Price"];
                AddAssetToPanel(assetId, assetName, price, panel);
            }
            reader.Close();
        }

        private void AddAssetToPanel(int assetId, string assetName, decimal price, FlowLayoutPanel panel)
        {
            Panel assetPanel = new Panel
            {
                Size = new Size(80, 80),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(22, 22, 22),
                Margin = new Padding(10),
                Tag = assetId
            };

            Label nameLabel = new Label
            {
                Text = $"{assetName}\n${price}",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                ForeColor = SystemColors.Control
            };

            assetPanel.Controls.Add(nameLabel);
            assetPanel.Click += (s, e) => ToggleAssetSelection(assetPanel, assetId);
            nameLabel.Click += (s, e) => ToggleAssetSelection(assetPanel, assetId);

            panel.Controls.Add(assetPanel);
        }

        private int ShowAssetAmountFormCentered()
        {
            using (AssetAmountForm amountForm = new AssetAmountForm())
            {
                amountForm.StartPosition = FormStartPosition.CenterParent;

                if (amountForm.ShowDialog() == DialogResult.OK)
                {
                    return (int)amountForm.Amount;
                }
                else
                {
                    return 0;
                }
            }
        }

        private void ToggleAssetSelection(Panel assetPanel, int assetId)
        {
            if (selectedAssets.ContainsKey(assetId))
            {
                selectedAssets.Remove(assetId);
                assetPanel.BackColor = Color.FromArgb(22, 22, 22);
            }
            else
            {
                int amount = ShowAssetAmountFormCentered();
                if (amount > 0)
                {
                    selectedAssets.Add(assetId, amount);
                    assetPanel.BackColor = Color.Gray;
                }
            }
        }

        private string GetPortfolioName()
        {
            using (SetPortfolioName portfolioNameForm = new SetPortfolioName())
            {
                portfolioNameForm.StartPosition = FormStartPosition.CenterParent;
                if (portfolioNameForm.ShowDialog() == DialogResult.OK)
                {
                    return portfolioNameForm.PortfolioName;
                }
                else
                {
                    return null;
                }
            }
        }

        private void CreatePortfButton3_Click(object sender, EventArgs e)
        {
            if (selectedAssets.Count == 0)
            {
                MessageBox.Show("Please select at least one asset for the portfolio.");
                return;
            }

            string portfolioName = GetPortfolioName();
            if (string.IsNullOrEmpty(portfolioName))
            {
                MessageBox.Show("Please provide a valid name for the portfolio.");
                return;
            }

            decimal totalCost = 0;
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        foreach (var asset in selectedAssets)
                        {
                            SqlCommand priceCmd = new SqlCommand("SELECT Price FROM Assets WHERE AssetId = @AssetId", con, transaction);
                            priceCmd.Parameters.AddWithValue("@AssetId", asset.Key);
                            decimal price = (decimal)priceCmd.ExecuteScalar();
                            totalCost += price * asset.Value;
                        }

                        decimal currentBalance = GetUserBalance();
                        if (currentBalance < totalCost)
                        {
                            MessageBox.Show("Insufficient balance to purchase selected assets.");
                            transaction.Rollback();
                            return;
                        }

                        SqlCommand cmd = new SqlCommand("INSERT INTO Portfolios (UserId, PortfolioName) OUTPUT INSERTED.PortfolioId VALUES (@UserId, @PortfolioName)", con, transaction);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@PortfolioName", portfolioName);
                        int portfolioId = (int)cmd.ExecuteScalar();

                        foreach (var asset in selectedAssets)
                        {
                            SqlCommand insertCmd = new SqlCommand("INSERT INTO PortfolioDetails (PortfolioId, AssetId, Quantity) VALUES (@PortfolioId, @AssetId, @Quantity)", con, transaction);
                            insertCmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
                            insertCmd.Parameters.AddWithValue("@AssetId", asset.Key);
                            insertCmd.Parameters.AddWithValue("@Quantity", asset.Value);
                            insertCmd.ExecuteNonQuery();
                        }

                        decimal newBalance = currentBalance - totalCost;
                        UpdateUserBalance(newBalance);

                        string insertTransactionSql = "INSERT INTO UserTransactions (UserId, TransactionType, Amount, TransactionDate) VALUES (@UserId, @TransactionType, @Amount, @TransactionDate)";
                        SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionSql, con, transaction);
                        insertTransactionCmd.Parameters.AddWithValue("@UserId", userId);
                        insertTransactionCmd.Parameters.AddWithValue("@TransactionType", "Трата");
                        insertTransactionCmd.Parameters.AddWithValue("@Amount", totalCost);
                        insertTransactionCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                        insertTransactionCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Portfolio created successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ошибка при создании портфеля: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void profileButton_Click(object sender, EventArgs e)
        {
            decimal currentBalance = GetUserBalance();
            ProfileForm profileForm = new ProfileForm(this.Location.X, this.Location.Y, this.Width, this.Height, currentBalance);
            previousLocationX = this.Location.X;
            previousLocationY = this.Location.Y;
            previousWidth = this.Width;
            previousHeight = this.Height;
            profileForm.Show();
            this.Hide();
        }

        private void PerformSearch(string name, string minPrice, string maxPrice)
        {
            string query = "SELECT AssetId, Name, Price, Type FROM Assets WHERE 1=1";

            if (!string.IsNullOrEmpty(name))
            {
                query += " AND Name LIKE @Name";
            }

            if (decimal.TryParse(minPrice, out decimal min))
            {
                query += " AND Price >= @MinPrice";
            }

            if (decimal.TryParse(maxPrice, out decimal max))
            {
                query += " AND Price <= @MaxPrice";
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                if (!string.IsNullOrEmpty(name))
                {
                    cmd.Parameters.AddWithValue("@Name", "%" + name + "%");
                }

                if (decimal.TryParse(minPrice, out min))
                {
                    cmd.Parameters.AddWithValue("@MinPrice", min);
                }

                if (decimal.TryParse(maxPrice, out max))
                {
                    cmd.Parameters.AddWithValue("@MaxPrice", max);
                }

                SqlDataReader reader = cmd.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel2.Controls.Clear();
                flowLayoutPanel3.Controls.Clear();

                while (reader.Read())
                {
                    int assetId = (int)reader["AssetId"];
                    string assetName = reader["Name"].ToString();
                    decimal price = (decimal)reader["Price"];
                    string assetType = reader["Type"].ToString();

                    switch (assetType)
                    {
                        case "Security":
                            AddAssetToPanel(assetId, assetName, price, flowLayoutPanel1);
                            break;
                        case "Stock":
                            AddAssetToPanel(assetId, assetName, price, flowLayoutPanel2);
                            break;
                        case "Cryptocurrency":
                            AddAssetToPanel(assetId, assetName, price, flowLayoutPanel3);
                            break;
                    }
                }

                reader.Close();
                con.Close();
            }
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string minPrice = minPriceTextBox.Text;
            string maxPrice = maxPriceTextBox.Text;
            PerformSearch(name, minPrice, maxPrice);
        }
    }
}