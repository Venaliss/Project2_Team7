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
            if (textBox1.Text == "" || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Введены не все данные. Попробуйте снова.", "Ошибка");
            }
            else
            {
                string name = textBox1.Text;
                string info = comboBox1.SelectedItem.ToString();

                using (SQLiteConnection sqlCon = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;"))
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(*) FROM Подборка WHERE Название = @name";
                    using (SQLiteCommand checkCommand = new SQLiteCommand(query, sqlCon))
                    {
                        checkCommand.Parameters.AddWithValue("@name", name);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Подборка с таким названием уже существует. Пожалуйста, выберите другое название.", "Ошибка");
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO Подборка (Название, Описание) VALUES (@name, @info)";
                            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, sqlCon))
                            {
                                insertCommand.Parameters.AddWithValue("@name", name);
                                insertCommand.Parameters.AddWithValue("@info", info);
                                insertCommand.ExecuteNonQuery();
                                MessageBox.Show("Вы успешно создали подборку", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
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
