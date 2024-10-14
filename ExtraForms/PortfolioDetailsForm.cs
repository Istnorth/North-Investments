using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace North_Investments
{
    public partial class PortfolioDetailsForm : Form
    {
        private int portfolioId;
        private int userId;

        public PortfolioDetailsForm(int portfolioId, int userId)
        {
            InitializeComponent();
            this.portfolioId = portfolioId;
            this.userId = userId;
            LoadPortfolioDetails();
        }

        private void PortfolioDetailsForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadPortfolioDetails()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT A.AssetId, A.Name, PD.Quantity, A.Price FROM PortfolioDetails PD INNER JOIN Assets A ON PD.AssetId = A.AssetId WHERE PD.PortfolioId = @PortfolioId", con);
                cmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int assetId = (int)reader["AssetId"];
                    string assetName = reader["Name"].ToString();
                    int quantity = (int)reader["Quantity"];
                    decimal price = (decimal)reader["Price"];
                    AddAssetToFlowLayoutPanel(assetId, assetName, quantity, price);
                }

                reader.Close();
            }

            UpdateTotalValue();
        }

        private void AddAssetToFlowLayoutPanel(int assetId, string assetName, int quantity, decimal price)
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
                Text = $"{assetName}\n{quantity} units @ ${price} each",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                ForeColor = SystemColors.Control
            };

            assetPanel.Controls.Add(nameLabel);
            flowLayoutPanel1.Controls.Add(assetPanel);
        }

        private void UpdateTotalValue()
        {
            decimal totalValue = 0;

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(A.Price * PD.Quantity) AS TotalValue FROM PortfolioDetails PD INNER JOIN Assets A ON PD.AssetId = A.AssetId WHERE PD.PortfolioId = @PortfolioId", con);
                cmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
                totalValue = (decimal)cmd.ExecuteScalar();
            }

            totalValueLabel.Text = $"Total Value: ${totalValue}";
        }

        private void doneButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void makeReportButton_Click(object sender, EventArgs e)
        {
            int days = (int)numericUpDown1.Value;

            if (days <= 0)
            {
                MessageBox.Show("Please select a valid number of days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddDays(-days);

            var reportData = GetPortfolioValueHistory(portfolioId, startDate, endDate);

            if (reportData.Count == 0)
            {
                MessageBox.Show("No data available for the selected period.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string filePath = $"PortfolioReport_{portfolioId}_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
            GenerateExcelReport(filePath, reportData);

            MessageBox.Show($"Report generated: {filePath}", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<PortfolioValueHistory> GetPortfolioValueHistory(int portfolioId, DateTime startDate, DateTime endDate)
        {
            List<PortfolioValueHistory> historyData = new List<PortfolioValueHistory>();

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Value, RecordedDate FROM PortfolioValueHistory WHERE PortfolioId = @PortfolioId AND RecordedDate BETWEEN @StartDate AND @EndDate",
                    con);
                cmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    decimal value = reader.GetDecimal(0);
                    DateTime recordedDate = reader.GetDateTime(1);
                    historyData.Add(new PortfolioValueHistory { Value = value, RecordedDate = recordedDate });
                }
            }

            return historyData;
        }

        private void GenerateExcelReport(string filePath, List<PortfolioValueHistory> reportData)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Report");

                worksheet.Cells[1, 1].Value = "Date";
                worksheet.Cells[1, 2].Value = "Value";

                for (int i = 0; i < reportData.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = reportData[i].RecordedDate;
                    worksheet.Cells[i + 2, 1].Style.Numberformat.Format = "dd/MM/yyyy HH:mm:ss";
                    worksheet.Cells[i + 2, 2].Value = reportData[i].Value;
                }

                FileInfo file = new FileInfo(filePath);
                package.SaveAs(file);
            }
        }

        private class PortfolioValueHistory
        {
            public decimal Value { get; set; }
            public DateTime RecordedDate { get; set; }
        }

        private void sellButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            decimal totalValue = 0;
                            string selectAssetsSql = "SELECT pd.AssetId, pd.Quantity, a.Price FROM PortfolioDetails pd JOIN Assets a ON pd.AssetId = a.AssetId WHERE pd.PortfolioId = @PortfolioId";
                            SqlCommand selectAssetsCmd = new SqlCommand(selectAssetsSql, con, transaction);
                            selectAssetsCmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
                            using (SqlDataReader reader = selectAssetsCmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    decimal price = reader.GetDecimal(2);
                                    int quantity = reader.GetInt32(1);
                                    totalValue += price * quantity;
                                }
                            }

                            string deleteValueHistorySql = "DELETE FROM PortfolioValueHistory WHERE PortfolioId = @PortfolioId";
                            SqlCommand deleteValueHistoryCmd = new SqlCommand(deleteValueHistorySql, con, transaction);
                            deleteValueHistoryCmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
                            deleteValueHistoryCmd.ExecuteNonQuery();

                            string deleteDetailsSql = "DELETE FROM PortfolioDetails WHERE PortfolioId = @PortfolioId";
                            SqlCommand deleteDetailsCmd = new SqlCommand(deleteDetailsSql, con, transaction);
                            deleteDetailsCmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
                            deleteDetailsCmd.ExecuteNonQuery();

                            string deletePortfolioSql = "DELETE FROM Portfolios WHERE PortfolioId = @PortfolioId";
                            SqlCommand deletePortfolioCmd = new SqlCommand(deletePortfolioSql, con, transaction);
                            deletePortfolioCmd.Parameters.AddWithValue("@PortfolioId", portfolioId);
                            deletePortfolioCmd.ExecuteNonQuery();

                            string updateBalanceSql = "UPDATE [dbo].[userD] SET userBal = userBal + @amount WHERE userId = @userId";
                            SqlCommand updateBalanceCmd = new SqlCommand(updateBalanceSql, con, transaction);
                            updateBalanceCmd.Parameters.AddWithValue("@amount", totalValue);
                            updateBalanceCmd.Parameters.AddWithValue("@userId", userId);
                            updateBalanceCmd.ExecuteNonQuery();

                            string insertTransactionSql = "INSERT INTO UserTransactions (UserId, TransactionType, Amount, TransactionDate) VALUES (@UserId, @TransactionType, @Amount, @TransactionDate)";
                            SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionSql, con, transaction);
                            insertTransactionCmd.Parameters.AddWithValue("@UserId", userId);
                            insertTransactionCmd.Parameters.AddWithValue("@TransactionType", "Пополнение");
                            insertTransactionCmd.Parameters.AddWithValue("@Amount", totalValue);
                            insertTransactionCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                            insertTransactionCmd.ExecuteNonQuery();

                            transaction.Commit();

                            MessageBox.Show("Portfolio sold successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error selling portfolio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
