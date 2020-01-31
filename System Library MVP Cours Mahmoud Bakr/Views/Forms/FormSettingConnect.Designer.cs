namespace System_Library_MVP_Cours_Mahmoud_Bakr.Views.Forms
{
    partial class FormSettingConnect
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
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDBNamae = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdSqlServer = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.ptnExit = new System.Windows.Forms.Button();
            this.ptnSave = new System.Windows.Forms.Button();
            this.rdWindows = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم السيرفر";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(172, 37);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(330, 37);
            this.txtServerName.TabIndex = 1;
            // 
            // txtDBNamae
            // 
            this.txtDBNamae.Location = new System.Drawing.Point(172, 92);
            this.txtDBNamae.Name = "txtDBNamae";
            this.txtDBNamae.Size = new System.Drawing.Size(330, 37);
            this.txtDBNamae.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم قاعدة البيانات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "طريقة الدخول";
            // 
            // rdSqlServer
            // 
            this.rdSqlServer.AutoSize = true;
            this.rdSqlServer.Checked = true;
            this.rdSqlServer.Location = new System.Drawing.Point(172, 190);
            this.rdSqlServer.Name = "rdSqlServer";
            this.rdSqlServer.Size = new System.Drawing.Size(257, 33);
            this.rdSqlServer.TabIndex = 6;
            this.rdSqlServer.TabStop = true;
            this.rdSqlServer.Text = "Sql Server  Authentication";
            this.rdSqlServer.UseVisualStyleBackColor = true;
            this.rdSqlServer.CheckedChanged += new System.EventHandler(this.rdSqlServer_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(172, 299);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(330, 37);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "كلمة المرور";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(172, 244);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(330, 37);
            this.txtUsername.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم المستخدم";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(272, 420);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(230, 29);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "zzahran1010@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "وجود خطا عليك التواصل مع المبرمج";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(379, 455);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(123, 29);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "01148868129";
            // 
            // ptnExit
            // 
            this.ptnExit.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Exit;
            this.ptnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnExit.Location = new System.Drawing.Point(284, 361);
            this.ptnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptnExit.Name = "ptnExit";
            this.ptnExit.Size = new System.Drawing.Size(167, 53);
            this.ptnExit.TabIndex = 12;
            this.ptnExit.Text = "خروج";
            this.ptnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ptnExit.UseVisualStyleBackColor = true;
            this.ptnExit.Click += new System.EventHandler(this.ptnExit_Click);
            // 
            // ptnSave
            // 
            this.ptnSave.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Setting;
            this.ptnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnSave.Location = new System.Drawing.Point(45, 361);
            this.ptnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptnSave.Name = "ptnSave";
            this.ptnSave.Size = new System.Drawing.Size(167, 53);
            this.ptnSave.TabIndex = 11;
            this.ptnSave.Text = "حفظ الاعدادات";
            this.ptnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ptnSave.UseVisualStyleBackColor = true;
            this.ptnSave.Click += new System.EventHandler(this.ptnSave_Click);
            // 
            // rdWindows
            // 
            this.rdWindows.AutoSize = true;
            this.rdWindows.Enabled = false;
            this.rdWindows.Location = new System.Drawing.Point(172, 151);
            this.rdWindows.Name = "rdWindows";
            this.rdWindows.Size = new System.Drawing.Size(245, 33);
            this.rdWindows.TabIndex = 16;
            this.rdWindows.Text = "Windows Authentication";
            this.rdWindows.UseVisualStyleBackColor = true;
            // 
            // FormSettingConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 485);
            this.Controls.Add(this.rdWindows);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ptnExit);
            this.Controls.Add(this.ptnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdSqlServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDBNamae);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "FormSettingConnect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة اعددات الاتصال بقاعدة البيانات";
            this.Load += new System.EventHandler(this.FormSettingConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDBNamae;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdSqlServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ptnSave;
        private System.Windows.Forms.Button ptnExit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.RadioButton rdWindows;
    }
}