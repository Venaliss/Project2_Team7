﻿namespace ListRecommendations
{
    partial class RegistrationForm
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
            this.lblRegistr = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistr = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxPassword1 = new System.Windows.Forms.TextBox();
            this.txtBoxPassword2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblRegistr
            // 
            this.lblRegistr.AutoSize = true;
            this.lblRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegistr.Location = new System.Drawing.Point(151, 78);
            this.lblRegistr.Name = "lblRegistr";
            this.lblRegistr.Size = new System.Drawing.Size(194, 32);
            this.lblRegistr.TabIndex = 0;
            this.lblRegistr.Text = "Регистрация";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(112, 135);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(112, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // btnRegistr
            // 
            this.btnRegistr.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegistr.Location = new System.Drawing.Point(157, 357);
            this.btnRegistr.Name = "btnRegistr";
            this.btnRegistr.Size = new System.Drawing.Size(188, 36);
            this.btnRegistr.TabIndex = 3;
            this.btnRegistr.Text = "Зарегистрироваться";
            this.btnRegistr.UseVisualStyleBackColor = false;
            this.btnRegistr.Click += new System.EventHandler(this.btnRegistr_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGoBack.Location = new System.Drawing.Point(157, 408);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(188, 36);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Назад";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(115, 155);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(265, 22);
            this.txtBoxLogin.TabIndex = 5;
            // 
            // txtBoxPassword1
            // 
            this.txtBoxPassword1.Location = new System.Drawing.Point(115, 215);
            this.txtBoxPassword1.Name = "txtBoxPassword1";
            this.txtBoxPassword1.Size = new System.Drawing.Size(265, 22);
            this.txtBoxPassword1.TabIndex = 6;
            // 
            // txtBoxPassword2
            // 
            this.txtBoxPassword2.Location = new System.Drawing.Point(115, 275);
            this.txtBoxPassword2.Name = "txtBoxPassword2";
            this.txtBoxPassword2.Size = new System.Drawing.Size(265, 22);
            this.txtBoxPassword2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Повторите пароль";
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Location = new System.Drawing.Point(237, 303);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(143, 21);
            this.checkPass.TabIndex = 9;
            this.checkPass.Text = "Показать пароль";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(503, 478);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPassword2);
            this.Controls.Add(this.txtBoxPassword1);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnRegistr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblRegistr);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistr;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistr;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxPassword1;
        private System.Windows.Forms.TextBox txtBoxPassword2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkPass;
    }
}