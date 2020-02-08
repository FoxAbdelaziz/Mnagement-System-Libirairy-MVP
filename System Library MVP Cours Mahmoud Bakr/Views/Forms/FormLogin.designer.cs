namespace System_Library_MVP_Cours_Mahmoud_Bakr.Views.Forms
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ptnLogin = new System.Windows.Forms.Button();
            this.pictureBoxShowPaass = new System.Windows.Forms.PictureBox();
            this.ptnExit = new System.Windows.Forms.Button();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPaass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "الرقم السري";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(244, 37);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "عبد العزيز";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 37);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "0000";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // ptnLogin
            // 
            this.ptnLogin.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Profile;
            this.ptnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnLogin.Location = new System.Drawing.Point(27, 132);
            this.ptnLogin.Name = "ptnLogin";
            this.ptnLogin.Size = new System.Drawing.Size(141, 50);
            this.ptnLogin.TabIndex = 2;
            this.ptnLogin.Text = "تسجيل الدخول ";
            this.ptnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ptnLogin.UseVisualStyleBackColor = true;
            this.ptnLogin.Click += new System.EventHandler(this.ptnLogin_Click);
            // 
            // pictureBoxShowPaass
            // 
            this.pictureBoxShowPaass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxShowPaass.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Hied;
            this.pictureBoxShowPaass.Location = new System.Drawing.Point(326, 85);
            this.pictureBoxShowPaass.Name = "pictureBoxShowPaass";
            this.pictureBoxShowPaass.Size = new System.Drawing.Size(38, 37);
            this.pictureBoxShowPaass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShowPaass.TabIndex = 7;
            this.pictureBoxShowPaass.TabStop = false;
            this.pictureBoxShowPaass.Click += new System.EventHandler(this.pictureBoxShowPaass_Click);
            this.pictureBoxShowPaass.MouseEnter += new System.EventHandler(this.pictureBoxShowPaass_MouseEnter);
            this.pictureBoxShowPaass.MouseLeave += new System.EventHandler(this.pictureBoxShowPaass_MouseLeave);
            // 
            // ptnExit
            // 
            this.ptnExit.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Exit;
            this.ptnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnExit.Location = new System.Drawing.Point(223, 132);
            this.ptnExit.Name = "ptnExit";
            this.ptnExit.Size = new System.Drawing.Size(141, 50);
            this.ptnExit.TabIndex = 5;
            this.ptnExit.Text = "خروج";
            this.ptnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ptnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogin.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Login;
            this.pictureBoxLogin.Location = new System.Drawing.Point(381, 12);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(155, 170);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 2;
            this.pictureBoxLogin.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.ptnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 194);
            this.Controls.Add(this.pictureBoxShowPaass);
            this.Controls.Add(this.ptnLogin);
            this.Controls.Add(this.ptnExit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPaass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button ptnExit;
        private System.Windows.Forms.Button ptnLogin;
        private System.Windows.Forms.PictureBox pictureBoxShowPaass;
    }
}