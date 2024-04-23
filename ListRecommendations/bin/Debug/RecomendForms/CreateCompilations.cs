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
using ListRecommendations;

namespace WindowsFormsApp6
{
    public partial class CreateCompilations : Form
    {
        public CreateCompilations()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();

        public int count;
        public string info;
        public int Position()
        {
            SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=ТуристическийМаршрут.db;");
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Избранное WHERE Название ='" + comboBox1.Text + "'", sqlCon);
            sqlCon.Open();
            var query = @"SELECT * FROM Избранное WHERE Название ='" + comboBox1.Text + "'";


            count = 0;
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count++;
            }
            reader.Close();
            return count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection sqlCon = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;");
            
            SQLiteCommand sqlCom = new SQLiteCommand("INSERT INTO Подборка (Название, Описание) VALUES (@name, @info)" , sqlCon);
            sqlCon.Open();

            var name = textBox1.Text;
            

            sqlCom.Parameters.AddWithValue("@name", name);
            sqlCom.Parameters.AddWithValue("@info", info);
            sqlCom.ExecuteNonQuery();

        }

        private void CreateCompilations_Load(object sender, EventArgs e)
        {
            
            SQLiteConnection connect = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;");
            SQLiteCommand cmd = new SQLiteCommand();
            connect.Open();
            cmd.Connection = connect;
            cmd.CommandText = "SELECT * FROM Избранное";
            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Название"]);
            }
            connect.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;Version = 3;");
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Избранное", connection);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
            dataAdapter.Fill(dataTable);
            info = dataTable.Rows[comboBox1.SelectedIndex][1].ToString();
        }
    }
}
