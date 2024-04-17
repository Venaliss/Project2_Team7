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
        private SQLiteConnection connection;
        public SpecificationsForm()
        {
            InitializeComponent();
            connection = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;Version=3;");
            LoadData();
        }
        private void LoadData()
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Маршрут", connection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox3.Items.Add(reader["Сезонность"].ToString());
            }

            connection.Close();
        }
    }
}
