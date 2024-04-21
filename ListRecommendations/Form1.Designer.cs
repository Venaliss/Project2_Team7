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
            this.pctrBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistration
            // 
            this.lblRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegistration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegistration.Location = new System.Drawing.Point(754, 12);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(142, 25);
            this.lblRegistration.TabIndex = 0;
            this.lblRegistration.Text = "Регистрация";
            this.lblRegistration.Click += new System.EventHandler(this.lblRegistration_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogin.Location = new System.Drawing.Point(676, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(61, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Вход";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // pctrBoxMain
            // 
            this.pctrBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrBoxMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctrBoxMain.Image = global::ListRecommendations.Properties.Resources.MainFormPicture;
            this.pctrBoxMain.Location = new System.Drawing.Point(12, 40);
            this.pctrBoxMain.Name = "pctrBoxMain";
            this.pctrBoxMain.Size = new System.Drawing.Size(884, 431);
            this.pctrBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBoxMain.TabIndex = 6;
            this.pctrBoxMain.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(908, 483);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.pctrBoxMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pctrBoxMain;
    }
}

