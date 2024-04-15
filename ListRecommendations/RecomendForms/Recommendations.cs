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

namespace WindowsFormsApp6
{
    public partial class Recommendations : Form
    {
        public Recommendations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarksForm marksForm = new MarksForm();
            marksForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecomendationInfo recomendationInfo = new RecomendationInfo();
            recomendationInfo.Show();
        }
    }
}
