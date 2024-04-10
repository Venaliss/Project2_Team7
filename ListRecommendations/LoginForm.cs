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
                var query = "SELECT * FROM Пользователь WHERE Логин = @txtBoxLogin AND Пароль = @txtBoxPassword";
                SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;Version = 3;");
                sqlConnection.Open();
                SQLiteCommand sqlCommand = new SQLiteCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@txtBoxLogin", txtBoxLogin.Text);
                sqlCommand.Parameters.AddWithValue("@txtBoxPassword", txtBoxPassword.Text);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if(dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Вы успешно авторизованы", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Recommendations rec = new Recommendations();
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
    }
}
