using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ListRecommendations
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlCon = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;Version = 3;");
            sqlCon.Open();
            SQLiteCommand sqlCom = new SQLiteCommand("INSERT INTO Пользователь VALUES('" + txtBoxLogin.Text + "','" + txtBoxPassword1.Text + "')", sqlCon);
            sqlCom.ExecuteNonQuery();
            MessageBox.Show("Вы успешно зарегистрированы");
            sqlCon.Close();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Пользователь", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }
}
