namespace WindowsFormsApp6
{
    partial class RecomendationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateCompilations = new System.Windows.Forms.Button();
            this.btnCompilations = new System.Windows.Forms.Button();
            this.btnSpecifications = new System.Windows.Forms.Button();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.btnRecommendation = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnCreateCompilations);
            this.panelMenu.Controls.Add(this.btnCompilations);
            this.panelMenu.Controls.Add(this.btnSpecifications);
            this.panelMenu.Controls.Add(this.btnFavourites);
            this.panelMenu.Controls.Add(this.btnRecommendation);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 480);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(3, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Настройки";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateCompilations
            // 
            this.btnCreateCompilations.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateCompilations.FlatAppearance.BorderSize = 0;
            this.btnCreateCompilations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCompilations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateCompilations.Location = new System.Drawing.Point(3, 320);
            this.btnCreateCompilations.Name = "btnCreateCompilations";
            this.btnCreateCompilations.Size = new System.Drawing.Size(199, 54);
            this.btnCreateCompilations.TabIndex = 3;
            this.btnCreateCompilations.Text = "Создание подборки";
            this.btnCreateCompilations.UseVisualStyleBackColor = false;
            this.btnCreateCompilations.Click += new System.EventHandler(this.btnCreateCompilations_Click);
            // 
            // btnCompilations
            // 
            this.btnCompilations.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCompilations.FlatAppearance.BorderSize = 0;
            this.btnCompilations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompilations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCompilations.Location = new System.Drawing.Point(1, 260);
            this.btnCompilations.Name = "btnCompilations";
            this.btnCompilations.Size = new System.Drawing.Size(199, 54);
            this.btnCompilations.TabIndex = 2;
            this.btnCompilations.Text = "Собственные подборки";
            this.btnCompilations.UseVisualStyleBackColor = false;
            this.btnCompilations.Click += new System.EventHandler(this.btnCompilations_Click);
            // 
            // btnSpecifications
            // 
            this.btnSpecifications.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSpecifications.FlatAppearance.BorderSize = 0;
            this.btnSpecifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecifications.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpecifications.Location = new System.Drawing.Point(1, 200);
            this.btnSpecifications.Name = "btnSpecifications";
            this.btnSpecifications.Size = new System.Drawing.Size(199, 54);
            this.btnSpecifications.TabIndex = 2;
            this.btnSpecifications.Text = "Характеристики";
            this.btnSpecifications.UseVisualStyleBackColor = false;
            this.btnSpecifications.Click += new System.EventHandler(this.btnSpecifications_Click);
            // 
            // btnFavourites
            // 
            this.btnFavourites.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFavourites.FlatAppearance.BorderSize = 0;
            this.btnFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourites.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFavourites.Location = new System.Drawing.Point(1, 140);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(199, 54);
            this.btnFavourites.TabIndex = 2;
            this.btnFavourites.Text = "Избранное";
            this.btnFavourites.UseVisualStyleBackColor = false;
            this.btnFavourites.Click += new System.EventHandler(this.btnFavourites_Click);
            // 
            // btnRecommendation
            // 
            this.btnRecommendation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRecommendation.FlatAppearance.BorderSize = 0;
            this.btnRecommendation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecommendation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecommendation.Location = new System.Drawing.Point(1, 80);
            this.btnRecommendation.Name = "btnRecommendation";
            this.btnRecommendation.Size = new System.Drawing.Size(199, 54);
            this.btnRecommendation.TabIndex = 1;
            this.btnRecommendation.Text = "Рекомендации";
            this.btnRecommendation.UseVisualStyleBackColor = false;
            this.btnRecommendation.Click += new System.EventHandler(this.btnRecommendation_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(194, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 83);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(237, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Домашняя страница";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 397);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ListRecommendations.Properties.Resources.Снимок_экрана_2024_04_13_172732;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RecomendationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(898, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "RecomendationForm";
            this.Text = "Recomendation";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRecommendation;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSpecifications;
        private System.Windows.Forms.Button btnFavourites;
        private System.Windows.Forms.Button btnCompilations;
        private System.Windows.Forms.Button btnCreateCompilations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}