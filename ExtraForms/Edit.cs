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

namespace North_Investments.ExtraForms
{
    public partial class Edit : Form
    {

        public Edit()
        {
            InitializeComponent();
        }

        private void portfButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S1LVDJS\SQLEXPRESS;Initial Catalog=NorthVest;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    var updates = new List<string>();
                    var parameters = new List<SqlParameter>();

                    if (!string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        updates.Add("login = @Log");
                        parameters.Add(new SqlParameter("@Log", SqlDbType.VarChar) { Value = textBox1.Text });
                    }

                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        updates.Add("pass = @Pass");
                        parameters.Add(new SqlParameter("@Pass", SqlDbType.VarChar) { Value = textBox2.Text });
                    }
                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        updates.Add("fio = @Fio");
                        parameters.Add(new SqlParameter("@Fio", SqlDbType.VarChar) { Value = textBox3.Text });
                    }
                    if (updates.Any())
                    {
                        string updateSql = $"UPDATE [dbo].[userD] SET {string.Join(", ", updates)} WHERE login = @CurrentLogin";
                        parameters.Add(new SqlParameter("@CurrentLogin", SqlDbType.VarChar) { Value = DataSend.text });

                        using (SqlCommand cmd = new SqlCommand(updateSql, con))
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Данные пользователя обновлены!");
                    }
                    else
                    {
                        MessageBox.Show("Нет данных для обновления");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при изменении данных пользователя: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPos;
        private void Edit_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPos.X;
                this.Top += e.Y - lastPos.Y;
            }
        }

        private void Edit_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = new Point(e.X, e.Y);
        }
    }
}
