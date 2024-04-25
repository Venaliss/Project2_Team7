using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class CompilationsForm : Form
    {
        public CompilationsForm()
        {
            InitializeComponent();
        }

        private void CompilationsForm_Load(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source = ТуристическийМаршрут.db;Version = 3;");

            connection.Open();

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Подборка", connection);
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

                    string query = "DELETE FROM Подборка WHERE Название = @primaryKeyValue";
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
