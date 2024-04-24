using ListRecommendations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp6
{
    public partial class RecomendationForm : Form
    {
        private Form activeForm;
        public RecomendationForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void btnRecommendation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Recommendations(), sender);
            label1.Text = "Рекомендации";
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FavouritesForm(), sender);
            label1.Text = "Избранное";
        }

        private void btnSpecifications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SpecificationsForm(), sender);
            label1.Text = "Характеристики";
        }

        private void btnCompilations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CompilationsForm(), sender);
            label1.Text = "Собственные подборки";
        }

        private void btnCreateCompilations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateCompilations(), sender);
            label1.Text = "Создание подборки";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsForm(), sender);
            label1.Text = "Настройки";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
