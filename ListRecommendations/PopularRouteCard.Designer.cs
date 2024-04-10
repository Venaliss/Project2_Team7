namespace ListRecommendations
{
    partial class PopularRouteCard
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
            this.pctrBoxRoute = new System.Windows.Forms.PictureBox();
            this.richTextBoxRoute = new System.Windows.Forms.RichTextBox();
            this.txtBoxMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrBoxRoute
            // 
            this.pctrBoxRoute.Location = new System.Drawing.Point(477, 23);
            this.pctrBoxRoute.Name = "pctrBoxRoute";
            this.pctrBoxRoute.Size = new System.Drawing.Size(311, 415);
            this.pctrBoxRoute.TabIndex = 0;
            this.pctrBoxRoute.TabStop = false;
            // 
            // richTextBoxRoute
            // 
            this.richTextBoxRoute.Location = new System.Drawing.Point(31, 23);
            this.richTextBoxRoute.Name = "richTextBoxRoute";
            this.richTextBoxRoute.Size = new System.Drawing.Size(417, 232);
            this.richTextBoxRoute.TabIndex = 1;
            this.richTextBoxRoute.Text = "";
            // 
            // txtBoxMoney
            // 
            this.txtBoxMoney.Location = new System.Drawing.Point(257, 326);
            this.txtBoxMoney.Name = "txtBoxMoney";
            this.txtBoxMoney.Size = new System.Drawing.Size(191, 22);
            this.txtBoxMoney.TabIndex = 2;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(180, 329);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(43, 17);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "Цена";
            // 
            // PopularRouteCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtBoxMoney);
            this.Controls.Add(this.richTextBoxRoute);
            this.Controls.Add(this.pctrBoxRoute);
            this.Name = "PopularRouteCard";
            this.Text = "PopularRouteCard";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxRoute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMoney;
        public System.Windows.Forms.PictureBox pctrBoxRoute;
        public System.Windows.Forms.RichTextBox richTextBoxRoute;
        public System.Windows.Forms.TextBox txtBoxMoney;
    }
}