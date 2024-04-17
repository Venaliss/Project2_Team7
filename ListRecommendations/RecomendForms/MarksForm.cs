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
    public partial class MarksForm : Form
    {
        public MarksForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlCon = new SQLiteConnection("Data Source=ТуристическийМаршрут.db;");
            SQLiteCommand sqlCom = new SQLiteCommand("INSERT INTO Избранное (Название, Описание, Оценка) VALUES (@name, @info, @mark)", sqlCon);

            sqlCon.Open();

            Recommendations info = new Recommendations();
            sqlCom.Parameters.AddWithValue("@name", info.label1.Text);
            sqlCom.Parameters.AddWithValue("@info", info.textBox1.Text);
            sqlCom.Parameters.AddWithValue("@mark", comboBox1.SelectedValue);
            FavouritesForm f = new FavouritesForm();
            f.Show();
            this.Close();
        }
    }
}
