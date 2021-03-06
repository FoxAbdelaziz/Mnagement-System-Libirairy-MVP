﻿namespace System_Library_MVP_Cours_Mahmoud_Bakr.Views.Forms
{
    partial class FormAuthors
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ptnDeleteAll = new System.Windows.Forms.Button();
            this.ptnNew = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPostion = new System.Windows.Forms.Label();
            this.ptnLast = new System.Windows.Forms.PictureBox();
            this.ptnNext = new System.Windows.Forms.PictureBox();
            this.ptnPrevious = new System.Windows.Forms.PictureBox();
            this.ptnFirst = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptnDelete = new System.Windows.Forms.Button();
            this.ptnUpdate = new System.Windows.Forms.Button();
            this.ptnAdd = new System.Windows.Forms.Button();
            this.txtAuth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnFirst)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "الدول";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 281);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(672, 231);
            this.dgv.TabIndex = 25;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // ptnDeleteAll
            // 
            this.ptnDeleteAll.Enabled = false;
            this.ptnDeleteAll.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnDeleteAll.Location = new System.Drawing.Point(30, 27);
            this.ptnDeleteAll.Name = "ptnDeleteAll";
            this.ptnDeleteAll.Size = new System.Drawing.Size(107, 41);
            this.ptnDeleteAll.TabIndex = 8;
            this.ptnDeleteAll.Text = "مسح الكل";
            this.ptnDeleteAll.UseVisualStyleBackColor = true;
            this.ptnDeleteAll.Click += new System.EventHandler(this.ptnDeleteAll_Click);
            // 
            // ptnNew
            // 
            this.ptnNew.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnNew.Location = new System.Drawing.Point(482, 27);
            this.ptnNew.Name = "ptnNew";
            this.ptnNew.Size = new System.Drawing.Size(107, 41);
            this.ptnNew.TabIndex = 7;
            this.ptnNew.Text = "جديد";
            this.ptnNew.UseVisualStyleBackColor = true;
            this.ptnNew.Click += new System.EventHandler(this.ptnNew_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(345, 68);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(289, 37);
            this.cmbCountry.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPostion);
            this.groupBox1.Controls.Add(this.ptnLast);
            this.groupBox1.Controls.Add(this.ptnNext);
            this.groupBox1.Controls.Add(this.ptnPrevious);
            this.groupBox1.Controls.Add(this.ptnFirst);
            this.groupBox1.Location = new System.Drawing.Point(44, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 80);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أسهم التنقل";
            // 
            // lblPostion
            // 
            this.lblPostion.AutoSize = true;
            this.lblPostion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPostion.Location = new System.Drawing.Point(304, 30);
            this.lblPostion.Name = "lblPostion";
            this.lblPostion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPostion.Size = new System.Drawing.Size(0, 29);
            this.lblPostion.TabIndex = 14;
            // 
            // ptnLast
            // 
            this.ptnLast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptnLast.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Actions_go_first_view_icon;
            this.ptnLast.Location = new System.Drawing.Point(104, 20);
            this.ptnLast.Name = "ptnLast";
            this.ptnLast.Size = new System.Drawing.Size(55, 52);
            this.ptnLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnLast.TabIndex = 13;
            this.ptnLast.TabStop = false;
            this.ptnLast.Click += new System.EventHandler(this.ptnLast_Click);
            // 
            // ptnNext
            // 
            this.ptnNext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptnNext.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Actions_go_previous_view_icon;
            this.ptnNext.Location = new System.Drawing.Point(185, 20);
            this.ptnNext.Name = "ptnNext";
            this.ptnNext.Size = new System.Drawing.Size(55, 52);
            this.ptnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnNext.TabIndex = 12;
            this.ptnNext.TabStop = false;
            this.ptnNext.Click += new System.EventHandler(this.ptnNext_Click);
            // 
            // ptnPrevious
            // 
            this.ptnPrevious.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptnPrevious.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Actions_go_next_view_icon;
            this.ptnPrevious.Location = new System.Drawing.Point(381, 20);
            this.ptnPrevious.Name = "ptnPrevious";
            this.ptnPrevious.Size = new System.Drawing.Size(55, 52);
            this.ptnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnPrevious.TabIndex = 11;
            this.ptnPrevious.TabStop = false;
            this.ptnPrevious.Click += new System.EventHandler(this.ptnPrevious_Click);
            // 
            // ptnFirst
            // 
            this.ptnFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptnFirst.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Actions_go_last_view_icon;
            this.ptnFirst.Location = new System.Drawing.Point(464, 20);
            this.ptnFirst.Name = "ptnFirst";
            this.ptnFirst.Size = new System.Drawing.Size(55, 52);
            this.ptnFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnFirst.TabIndex = 10;
            this.ptnFirst.TabStop = false;
            this.ptnFirst.Click += new System.EventHandler(this.ptnFirst_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptnDeleteAll);
            this.groupBox2.Controls.Add(this.ptnNew);
            this.groupBox2.Controls.Add(this.ptnDelete);
            this.groupBox2.Controls.Add(this.ptnUpdate);
            this.groupBox2.Controls.Add(this.ptnAdd);
            this.groupBox2.Location = new System.Drawing.Point(44, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 80);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // ptnDelete
            // 
            this.ptnDelete.Enabled = false;
            this.ptnDelete.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnDelete.Location = new System.Drawing.Point(143, 27);
            this.ptnDelete.Name = "ptnDelete";
            this.ptnDelete.Size = new System.Drawing.Size(107, 41);
            this.ptnDelete.TabIndex = 0;
            this.ptnDelete.Text = "مسح";
            this.ptnDelete.UseVisualStyleBackColor = true;
            this.ptnDelete.Click += new System.EventHandler(this.ptnDelete_Click);
            // 
            // ptnUpdate
            // 
            this.ptnUpdate.Enabled = false;
            this.ptnUpdate.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnUpdate.Location = new System.Drawing.Point(256, 27);
            this.ptnUpdate.Name = "ptnUpdate";
            this.ptnUpdate.Size = new System.Drawing.Size(107, 41);
            this.ptnUpdate.TabIndex = 5;
            this.ptnUpdate.Text = "حفظ";
            this.ptnUpdate.UseVisualStyleBackColor = true;
            this.ptnUpdate.Click += new System.EventHandler(this.ptnUpdate_Click);
            // 
            // ptnAdd
            // 
            this.ptnAdd.Enabled = false;
            this.ptnAdd.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnAdd.Location = new System.Drawing.Point(369, 27);
            this.ptnAdd.Name = "ptnAdd";
            this.ptnAdd.Size = new System.Drawing.Size(107, 41);
            this.ptnAdd.TabIndex = 6;
            this.ptnAdd.Text = "اضافة";
            this.ptnAdd.UseVisualStyleBackColor = true;
            this.ptnAdd.Click += new System.EventHandler(this.ptnAdd_Click);
            // 
            // txtAuth
            // 
            this.txtAuth.Location = new System.Drawing.Point(345, 13);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(289, 37);
            this.txtAuth.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "المؤلف";
            // 
            // txtAuthID
            // 
            this.txtAuthID.BackColor = System.Drawing.Color.White;
            this.txtAuthID.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthID.ForeColor = System.Drawing.Color.Red;
            this.txtAuthID.Location = new System.Drawing.Point(107, 13);
            this.txtAuthID.Name = "txtAuthID";
            this.txtAuthID.ReadOnly = true;
            this.txtAuthID.Size = new System.Drawing.Size(125, 44);
            this.txtAuthID.TabIndex = 20;
            this.txtAuthID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "رقم المؤلف";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(107, 68);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(125, 37);
            this.dtpDOB.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "تاريخ الميلاد";
            // 
            // FormAuthors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 525);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtAuth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAuthID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAuthors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المؤولفين";
            this.Load += new System.EventHandler(this.FormAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnFirst)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button ptnDeleteAll;
        private System.Windows.Forms.Button ptnNew;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ptnDelete;
        private System.Windows.Forms.Button ptnUpdate;
        private System.Windows.Forms.Button ptnAdd;
        private System.Windows.Forms.TextBox txtAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPostion;
        private System.Windows.Forms.PictureBox ptnLast;
        private System.Windows.Forms.PictureBox ptnNext;
        private System.Windows.Forms.PictureBox ptnPrevious;
        private System.Windows.Forms.PictureBox ptnFirst;
    }
}