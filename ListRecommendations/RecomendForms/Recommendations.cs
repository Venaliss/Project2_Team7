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
using System.IO;
using ListRecommendations;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp6
{
    public partial class Recommendations : Form
    {
        public Recommendations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarksForm marksForm = new MarksForm();
            marksForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load_Data_Info(Index.index);
        }

        DataTable dataTable = new DataTable();
        
        private void load_Data_Info(int position)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;Version = 3;");
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Маршрут", connection);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
            dataAdapter.Fill(dataTable);
            RecomendationInfo info = new RecomendationInfo();
            info.Show();
            info.textBox1.Text = dataTable.Rows[position][7].ToString();
            info.textBox2.Text = dataTable.Rows[position][8].ToString();
            info.label5.Text = dataTable.Rows[position][9].ToString();
            info.label2.Text = "Длительность: " + dataTable.Rows[position][2].ToString() + " ночей";
            info.label1.Text = "Бюджет: на двоих " + dataTable.Rows[position][3];
            Byte[] image = Encoding.ASCII.GetBytes(dataTable.Rows[position][3].ToString());
            if (image == null)
            {
                info.pictureBox1.Image = null;
            }
            else
            {
                var data = (Byte[])(dataTable.Rows[position][6]);
                var stream = new MemoryStream(data);
                info.pictureBox1.Image = Image.FromStream(stream);
            }
        }

        private void load_Data_Recommendation(int position)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;Version = 3;");
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Маршрут", connection);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
            dataAdapter.Fill(dataTable);
            textBox1.Text = dataTable.Rows[position][5].ToString();
            label1.Text = dataTable.Rows[position][1].ToString();
            Byte[] image = Encoding.ASCII.GetBytes(dataTable.Rows[position][3].ToString());
            if (image == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                var data = (Byte[])(dataTable.Rows[position][6]);
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Index.index++;
            load_Data_Recommendation(Index.index);
        }

        private void Recommendations_Load(object sender, EventArgs e)
        {
            load_Data_Recommendation(Index.index);
        }
    }
}
