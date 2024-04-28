using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            radioButton1.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                label1.Text = "Language";
                radioButton1.Text = "Russian";
                radioButton2.Text = "English";
                
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
                label1.Text = "Язык";
                radioButton1.Text = "Русский";
                radioButton2.Text = "Английский";
            }
        }
    }
}
