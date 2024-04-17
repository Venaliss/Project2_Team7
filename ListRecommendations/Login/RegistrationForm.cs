﻿using System;
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

namespace ListRecommendations
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {       
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=ТуристическийМаршрут.db;");
            SQLiteCommand sqlCom = new SQLiteCommand("INSERT INTO Пользователь (Логин, Пароль) VALUES (@txtBoxLogin, @txtBoxPassword1)", sqlCon);

            sqlCon.Open();

            var query = @"SELECT * FROM Пользователь WHERE Логин ='" + txtBoxLogin.Text + "'";
            var count = 0;
            sqlCom.CommandText = query;

            SQLiteDataReader reader = sqlCom.ExecuteReader();
            while (reader.Read())
            {
                count++;
            }
            reader.Close();

            if (txtBoxPassword1.Text.Equals(txtBoxPassword2.Text) & count == 0 & (!(txtBoxLogin.Text.Trim() == "" | txtBoxPassword1.Text.Trim() == "")))
            {
                string hashPass = HashPassword.GetMD5Hash(txtBoxPassword1.Text);
                SQLiteCommand sqlComm = new SQLiteCommand("INSERT INTO Пользователь (Логин, Пароль) VALUES (@txtBoxLogin, @hashPass)", sqlCon);

                sqlComm.Parameters.AddWithValue("@txtBoxLogin", txtBoxLogin.Text);
                sqlComm.Parameters.AddWithValue("@hashPass", hashPass);
                MessageBox.Show("Вы успешно зарегистрированы");
                this.Close();

                LoginForm lg = new LoginForm();
                lg.Show();

                sqlComm.ExecuteNonQuery();
            }

            else if ((txtBoxPassword1.Text.Equals(txtBoxPassword2.Text)) == false)
            {
                txtBoxPassword2.Clear();
                MessageBox.Show("Пароли не совпадают, повторите попытку","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtBoxLogin.Text.Trim() == ""  | txtBoxPassword1.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные полностью", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Логин уже занят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtBoxPassword1.UseSystemPasswordChar = false;
                txtBoxPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword1.UseSystemPasswordChar = true;
                txtBoxPassword2.UseSystemPasswordChar = true;
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            txtBoxPassword1.UseSystemPasswordChar = true;
            txtBoxPassword2.UseSystemPasswordChar = true;
        }
    }
}