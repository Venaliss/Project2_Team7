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
using ListRecommendations.Properties;
using ListRecommendations;

namespace WindowsFormsApp6
{
    public partial class MarksForm : Form
    {
        public MarksForm()
        {
            InitializeComponent();
        }

        DataTable dataTable = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") 
            {
                MessageBox.Show("Поставь оценку от 1 до 5");
            }
            else
            {
                SQLiteConnection sqlCon = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;");
                SQLiteCommand sqlCom = new SQLiteCommand("INSERT INTO Избранное (Название, Описание, Оценка) VALUES (@name, @info, @mark)", sqlCon);

                sqlCon.Open();

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Маршрут", sqlCon);
                dataAdapter.Fill(dataTable);
                var name = dataTable.Rows[Index.index][1].ToString();
                var infor = dataTable.Rows[Index.index][5].ToString();
                var mark = comboBox1.Text;
                sqlCom.Parameters.AddWithValue("@name", name);
                sqlCom.Parameters.AddWithValue("@info", infor);
                sqlCom.Parameters.AddWithValue("@mark", mark);

                this.Close();
                sqlCom.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено в избранное", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
