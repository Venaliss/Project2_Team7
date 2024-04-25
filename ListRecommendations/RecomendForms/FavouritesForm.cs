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
    public partial class FavouritesForm : Form
    {
        public FavouritesForm()
        {
            InitializeComponent();
        }

        private void FavouritesForm_Load(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source = ТуристическийМаршрут.db;Version = 3;");

            connection.Open();

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Избранное", connection);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source = ТуристическийМаршрут.db;Version = 3;");
                connection.Open();

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string primaryKeyValue = row.Cells["Название"].Value.ToString();

                    string query = "DELETE FROM Избранное WHERE Название = @primaryKeyValue";
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    dataGridView1.Rows.Remove(row);
                }

                connection.Close();
            }
        }
    }
}
