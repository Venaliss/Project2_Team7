using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using WindowsFormsApp6;
using NLog;
using ListRecommendations.Manager;
using ListRecommendations.Models;
using System.Linq;

namespace ListRecommendations
{
    public partial class LoginForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        UsersManager usManager = new UsersManager();
        ApplicationDBContext db = new ApplicationDBContext();
        Users users = new Users();
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text.Trim() == "" && txtBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Вы оставили пустое поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn("Пользователь ввел пустое поле");
            }
            else
            {
                
                string hashPass = HashPassword.GetMD5Hash(txtBoxPassword.Text);
                var rec = db.Users.Where(a => a.login == txtBoxLogin.Text && a.password == hashPass).FirstOrDefault();

                if (rec != null)
                {
                    MessageBox.Show("Вы успешно авторизованы", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    RecomendationForm recForm = new RecomendationForm();
                    recForm.Show();
                    logger.Debug("Пользователь успешно авторизовался");
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введеных данных. Если вы не были авторизованы, рекомендуем зарегистрироваться.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Пользователь ввел данные некорректно");
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
