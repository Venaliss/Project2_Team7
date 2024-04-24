using System;
using System.Windows.Forms;
using System.Data.SQLite;
using NLog;
using ListRecommendations.Models;
using ListRecommendations.Manager;
using System.Linq;

namespace ListRecommendations
{
    public partial class RegistrationForm : Form
    {
        static private Logger logger = LogManager.GetCurrentClassLogger();
        UsersManager usManager = new UsersManager();
        ApplicationDBContext db = new ApplicationDBContext();
        Users users = new Users();
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
            var rec = db.Users.Where(a => a.login == txtBoxLogin.Text).FirstOrDefault();

            if (txtBoxPassword1.Text.Equals(txtBoxPassword2.Text) & rec == null & (!(txtBoxLogin.Text.Trim() == "" | txtBoxPassword1.Text.Trim() == "")))
            {   
                string hashPass = HashPassword.GetMD5Hash(txtBoxPassword1.Text);              
                users.login = txtBoxLogin.Text;
                users.password = hashPass;

                db.Users.Add(users);

                db.SaveChanges();

                MessageBox.Show("Вы успешно зарегистрированы");
                this.Close();

                LoginForm lg = new LoginForm();
                lg.Show();

                logger.Debug("Пользователь успешно зарегистрировался");

            }

            else if ((txtBoxPassword1.Text.Equals(txtBoxPassword2.Text)) == false)
            {
                txtBoxPassword2.Clear();
                MessageBox.Show("Пароли не совпадают, повторите попытку","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn("При регистрации пароли не совпали");
            }

            else if (txtBoxLogin.Text.Trim() == ""  | txtBoxPassword1.Text.Trim() == "")
            {
                MessageBox.Show("Введите данные полностью", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Логин уже занят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn("Пользователь ввел уже существующий логин");
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
