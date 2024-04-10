using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListRecommendations.Properties;

namespace ListRecommendations
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        private void lblStambul_Click(object sender, EventArgs e)
        {
            PopularRouteCard routeCard = new PopularRouteCard();
            routeCard.Show();
            routeCard.pctrBoxRoute.Image = Properties.Resources.Stambul__1_;
            routeCard.txtBoxMoney.Text = "100 тысяч рублей";
            routeCard.richTextBoxRoute.Text = "История Стамбула начинается в VII веке до н. э., когда появился город Византий. В 330 году сюда перенесли столицу Римской империи и дали ей имя Новый Рим. Название не прижилось в народе, и вскоре город ознаменовали Константинополем в честь римского императора Константина.После распада Римской империи город стал столицей Византии и крупнейшим центром восточного христианства.Как раз в это время были построены многие дворцы и храмы, включая собор Святой Софии — пожалуй, главную достопримечательность Стамбула.В 1453 году город захватили османы и он стал мусульманским, а все храмы перестроили в мечети.Константинополь носил своё название вплоть до 1930: первый президент Турции Мустафа Кемаль Ататюрк переименовал город в Стамбул. Это был заключительный этап реформ, которые символизировали победу над османским наследием.Стамбул разделён проливом Босфор на две части — европейскую и азиатскую.Это единственный город в мире, который лежит на двух континентах.В Стамбуле нет центра: у каждого района он свой и в каждом — свой колорит. Районов в Стамбуле много — чуть меньше полусотни.Для туристов будут интересны Султанахмет, Эминёню и Аксарай, а также Бешикташ, Бейоглу, Кадыкёй и Ускюдар.";
        }

        private void lblDubai_Click(object sender, EventArgs e)
        {
            PopularRouteCard routeCard = new PopularRouteCard();
            routeCard.Show();
            routeCard.pctrBoxRoute.Image = Properties.Resources.Dubai__1_;
            routeCard.txtBoxMoney.Text = "189 тысяч рублей";
        }

        private void lblTokyo_Click(object sender, EventArgs e)
        {
            PopularRouteCard routeCard = new PopularRouteCard();
            routeCard.Show();
            routeCard.pctrBoxRoute.Image = Properties.Resources.Tokyo__1_;
            routeCard.txtBoxMoney.Text = "270 тысяч рублей";
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
