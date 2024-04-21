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

namespace WindowsFormsApp6
{
    public partial class SpecificationsForm : Form
    {
        SQLiteConnection conn = new SQLiteConnection("Data source = ТуристическийМаршрут.db");
        public SpecificationsForm()
        {
            InitializeComponent();
            load_Data_Money();
            load_Data_Time();
            
        }
        private void load_Data_Money()
        {
            string query_Cheel = "SELECT Бюджет FROM Маршрут";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query_Cheel, conn);
            conn.Open();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Бюджет");
            comboBox4.DisplayMember = "Бюджет";
            comboBox4.ValueMember = "Бюджет";
            comboBox4.DataSource = dataSet.Tables["Бюджет"];
            conn.Close();
            if (comboBox4.Items.Count > 1)
            {
                comboBox4.SelectedIndex = -1;
            }
        }
        private void load_Data_Time()
        {
            string query_Cheel = "SELECT Продолжительность FROM Маршрут";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query_Cheel, conn);
            conn.Open();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Продолжительность");
            comboBox2.DisplayMember = "Продолжительность";
            comboBox2.ValueMember = "Продолжительность";
            comboBox2.DataSource = dataSet.Tables["Продолжительность"];
            conn.Close();
            if (comboBox2.Items.Count > 1)
            {
                comboBox2.SelectedIndex = -1;
            }
        }
        private void load_Reccomendation(string str)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Название, Описание, Продолжительность, Бюджет, Сезонность FROM Маршрут WHERE Продолжительность LIKE '"+ str +"'", conn);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();
            DataTable dataTable = new DataTable();
            dataAdapter.SelectCommand = cmd;
            dataTable.Clear();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_Reccomendation(comboBox2.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_Reccomendation(comboBox4.Text);
        }
    }
}
