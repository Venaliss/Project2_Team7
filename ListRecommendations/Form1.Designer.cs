namespace ListRecommendations
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblStambul = new System.Windows.Forms.Label();
            this.lblDubai = new System.Windows.Forms.Label();
            this.lblTokyo = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.pctrBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistration
            // 
            this.lblRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegistration.Location = new System.Drawing.Point(759, 13);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(92, 17);
            this.lblRegistration.TabIndex = 0;
            this.lblRegistration.Text = "Регистрация";
            this.lblRegistration.Click += new System.EventHandler(this.lblRegistration_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogin.Location = new System.Drawing.Point(857, 13);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Вход";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblStambul
            // 
            this.lblStambul.AutoSize = true;
            this.lblStambul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStambul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStambul.Location = new System.Drawing.Point(13, 109);
            this.lblStambul.Name = "lblStambul";
            this.lblStambul.Size = new System.Drawing.Size(120, 29);
            this.lblStambul.TabIndex = 2;
            this.lblStambul.Text = "Стамбул";
            this.lblStambul.Click += new System.EventHandler(this.lblStambul_Click);
            // 
            // lblDubai
            // 
            this.lblDubai.AutoSize = true;
            this.lblDubai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDubai.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDubai.Location = new System.Drawing.Point(13, 181);
            this.lblDubai.Name = "lblDubai";
            this.lblDubai.Size = new System.Drawing.Size(87, 29);
            this.lblDubai.TabIndex = 3;
            this.lblDubai.Text = "Дубай";
            this.lblDubai.Click += new System.EventHandler(this.lblDubai_Click);
            // 
            // lblTokyo
            // 
            this.lblTokyo.AutoSize = true;
            this.lblTokyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTokyo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTokyo.Location = new System.Drawing.Point(13, 251);
            this.lblTokyo.Name = "lblTokyo";
            this.lblTokyo.Size = new System.Drawing.Size(89, 29);
            this.lblTokyo.TabIndex = 4;
            this.lblTokyo.Text = "Токио";
            this.lblTokyo.Click += new System.EventHandler(this.lblTokyo_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblText.Location = new System.Drawing.Point(12, 13);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(472, 36);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Изучи популярные маршруты";
            // 
            // pctrBoxMain
            // 
            this.pctrBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrBoxMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctrBoxMain.Location = new System.Drawing.Point(543, 42);
            this.pctrBoxMain.Name = "pctrBoxMain";
            this.pctrBoxMain.Size = new System.Drawing.Size(353, 429);
            this.pctrBoxMain.TabIndex = 6;
            this.pctrBoxMain.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 483);
            this.Controls.Add(this.pctrBoxMain);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTokyo);
            this.Controls.Add(this.lblDubai);
            this.Controls.Add(this.lblStambul);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblRegistration);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblStambul;
        private System.Windows.Forms.Label lblDubai;
        private System.Windows.Forms.Label lblTokyo;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pctrBoxMain;
    }
}

