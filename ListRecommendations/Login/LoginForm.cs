using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListRecommendations.Properties;
using System.Data.SQLite;
using WindowsFormsApp6;

namespace ListRecommendations
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text.Trim() == "" && txtBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Вы оставили пустое поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hashPass = HashPassword.GetMD5Hash(txtBoxPassword.Text);
                var query = "SELECT * FROM Пользователь WHERE Логин = @txtBoxLogin AND Пароль = @txtBoxPassword";

                SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;Version = 3;");
                sqlConnection.Open();

                SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@txtBoxLogin", txtBoxLogin.Text);
                sqlCommand.Parameters.AddWithValue("@txtBoxPassword", hashPass);

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Вы успешно авторизованы", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    RecomendationForm rec = new RecomendationForm();
                    rec.Show();
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введеных данных. Если вы не были авторизованы, рекомендуем зарегистрироваться.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
