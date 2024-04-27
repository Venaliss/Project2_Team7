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
            string query_Budget = @"
    SELECT
        CASE
            WHEN Бюджет <= 100000 THEN '0 - 100 000'
            WHEN Бюджет <= 200000 THEN '100 000 - 200 000'
            WHEN Бюджет <= 300000 THEN '200 000 - 300 000'
            ELSE '300 000+'
        END AS 'Интервал бюджета',
        MIN(Бюджет) AS 'MinBudget',
        MAX(Бюджет) AS 'MaxBudget'
    FROM Маршрут
    GROUP BY
        CASE
            WHEN Бюджет <= 100000 THEN '0 - 100 000'
            WHEN Бюджет <= 200000 THEN '100 000 - 200 000'
            WHEN Бюджет <= 300000 THEN '200 000 - 300 000'
            ELSE '300 000+'
        END";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query_Budget, conn);
            conn.Open();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Бюджет");

            comboBox4.DisplayMember = "Интервал бюджета";
            comboBox4.ValueMember = "MinBudget";
            comboBox4.DataSource = dataSet.Tables["Бюджет"];
            

            comboBox4.SelectedIndexChanged += new EventHandler(comboBox4_SelectedIndexChanged);

            conn.Close();
        }

        private void load_Data_Time()
        {
            string query_Duration = @"
    SELECT
        CASE
            WHEN Продолжительность <= 3 THEN '0 - 3 дней'
            WHEN Продолжительность <= 7 THEN '3 - 7 дней'
            WHEN Продолжительность <= 14 THEN '7 - 14 дней'
            ELSE '14 дней+'
        END AS 'Интервал продолжительности',
        MIN(Продолжительность) AS 'MinDuration',
        MAX(Продолжительность) AS 'MaxDuration'
    FROM Маршрут
    GROUP BY
        CASE
            WHEN Продолжительность <= 3 THEN '0 - 3 дней'
            WHEN Продолжительность <= 7 THEN '3 - 7 дней'
            WHEN Продолжительность <= 14 THEN '7 - 14 дней'
            ELSE '14 дней+'
        END";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query_Duration, conn);
            conn.Open();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Продолжительность");

            comboBox2.DisplayMember = "Интервал продолжительности";
            comboBox2.ValueMember = "MinDuration";
            comboBox2.DataSource = dataSet.Tables["Продолжительность"];
          

            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);

            conn.Close();
        }

        private void load_Reccomendation(string duration, string budget)
        {
            string query = @"
        SELECT Название, Описание, Продолжительность, Бюджет, Сезонность
        FROM Маршрут
        WHERE
            Продолжительность BETWEEN @minDuration AND @maxDuration AND
            Бюджет BETWEEN @minBudget AND @maxBudget";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@minDuration", GetDurationValue(duration, true));
            cmd.Parameters.AddWithValue("@maxDuration", GetDurationValue(duration, false));
            cmd.Parameters.AddWithValue("@minBudget", GetBudgetValue(budget, true));
            cmd.Parameters.AddWithValue("@maxBudget", GetBudgetValue(budget, false));

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string duration = comboBox2.Text;
            string budget = comboBox4.Text;
            load_Reccomendation(duration, budget);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string duration = comboBox2.Text;
            string budget = comboBox4.Text;
            load_Reccomendation(duration, budget);
        }
        private int GetDurationValue(string interval, bool isMin)
        {
            switch (interval)
            {
                case "0 - 3 дней":
                    return isMin ? 1 : 3;
                case "3 - 7 дней":
                    return isMin ? 4 : 7;
                case "7 - 14 дней":
                    return isMin ? 8 : 14;
                default:
                    return isMin ? 15 : int.MaxValue;
            }
        }

        private int GetBudgetValue(string interval, bool isMin)
        {
            switch (interval)
            {
                case "0 - 100 000":
                    return isMin ? 0 : 100000;
                case "100 000 - 200 000":
                    return isMin ? 100001 : 200000;
                case "200 000 - 300 000":
                    return isMin ? 200001 : 300000;
                default:
                    return isMin ? 300001 : int.MaxValue;
            }
        }
    }
}
