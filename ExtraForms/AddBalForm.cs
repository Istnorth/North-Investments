using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace North_Investments.ExtraForms
{
    public partial class AddBalForm : Form
    {
        public AddBalForm()
        {
            InitializeComponent();
            button1.Click += new EventHandler(BackButton_Click);
            payButton.Click += new EventHandler(PayButton_Click);
        }

        private void AddBalForm_Load(object sender, EventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal amount) && amount > 0)
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
                                string updateSql = "UPDATE [dbo].[userD] SET userBal = userBal + @amount WHERE login = @login";
                                SqlCommand updateCmd = new SqlCommand(updateSql, con, transaction);
                                updateCmd.Parameters.AddWithValue("@amount", amount);
                                updateCmd.Parameters.AddWithValue("@login", DataSend.text);
                                updateCmd.ExecuteNonQuery();

                                string insertTransactionSql = "INSERT INTO UserTransactions (UserId, TransactionType, Amount, TransactionDate) VALUES (@UserId, @TransactionType, @Amount, @TransactionDate)";
                                SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionSql, con, transaction);
                                insertTransactionCmd.Parameters.AddWithValue("@UserId", DataSend.userId);
                                insertTransactionCmd.Parameters.AddWithValue("@TransactionType", "Пополнение");
                                insertTransactionCmd.Parameters.AddWithValue("@Amount", amount);
                                insertTransactionCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                                insertTransactionCmd.ExecuteNonQuery();

                                transaction.Commit();

                                DataSend.userBalance += amount;
                                MessageBox.Show("Баланс успешно пополнен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            catch (Exception)
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при пополнении баланса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите корректную сумму для пополнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
