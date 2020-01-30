﻿namespace System_Library_MVP_Cours_Mahmoud_Bakr.Views.Forms
{
    partial class FormPlaces
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
            this.ptnDelete = new System.Windows.Forms.Button();
            this.ptnPlaceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptnUpdate = new System.Windows.Forms.Button();
            this.ptnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptnDeleteAll = new System.Windows.Forms.Button();
            this.ptnNew = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ptnFirst = new System.Windows.Forms.PictureBox();
            this.ptnPrevious = new System.Windows.Forms.PictureBox();
            this.ptnNext = new System.Windows.Forms.PictureBox();
            this.ptnLast = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnLast)).BeginInit();
            this.SuspendLayout();
            // 
            // ptnDelete
            // 
            this.ptnDelete.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnDelete.Location = new System.Drawing.Point(143, 27);
            this.ptnDelete.Name = "ptnDelete";
            this.ptnDelete.Size = new System.Drawing.Size(107, 41);
            this.ptnDelete.TabIndex = 0;
            this.ptnDelete.Text = "مسح";
            this.ptnDelete.UseVisualStyleBackColor = true;
            // 
            // ptnPlaceName
            // 
            this.ptnPlaceName.Location = new System.Drawing.Point(347, 22);
            this.ptnPlaceName.Name = "ptnPlaceName";
            this.ptnPlaceName.Size = new System.Drawing.Size(289, 37);
            this.ptnPlaceName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "مكان الكتاب";
            // 
            // txtPlaceID
            // 
            this.txtPlaceID.Location = new System.Drawing.Point(109, 22);
            this.txtPlaceID.Name = "txtPlaceID";
            this.txtPlaceID.Size = new System.Drawing.Size(125, 37);
            this.txtPlaceID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "رقم المكان";
            // 
            // ptnUpdate
            // 
            this.ptnUpdate.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnUpdate.Location = new System.Drawing.Point(256, 27);
            this.ptnUpdate.Name = "ptnUpdate";
            this.ptnUpdate.Size = new System.Drawing.Size(107, 41);
            this.ptnUpdate.TabIndex = 5;
            this.ptnUpdate.Text = "حفظ";
            this.ptnUpdate.UseVisualStyleBackColor = true;
            // 
            // ptnAdd
            // 
            this.ptnAdd.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnAdd.Location = new System.Drawing.Point(369, 27);
            this.ptnAdd.Name = "ptnAdd";
            this.ptnAdd.Size = new System.Drawing.Size(107, 41);
            this.ptnAdd.TabIndex = 6;
            this.ptnAdd.Text = "اضافة";
            this.ptnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptnFirst);
            this.groupBox1.Controls.Add(this.ptnPrevious);
            this.groupBox1.Controls.Add(this.ptnNext);
            this.groupBox1.Controls.Add(this.ptnLast);
            this.groupBox1.Location = new System.Drawing.Point(46, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 80);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أسهم التنقل";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptnDeleteAll);
            this.groupBox2.Controls.Add(this.ptnNew);
            this.groupBox2.Controls.Add(this.ptnDelete);
            this.groupBox2.Controls.Add(this.ptnUpdate);
            this.groupBox2.Controls.Add(this.ptnAdd);
            this.groupBox2.Location = new System.Drawing.Point(46, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 80);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات";
            // 
            // ptnDeleteAll
            // 
            this.ptnDeleteAll.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnDeleteAll.Location = new System.Drawing.Point(30, 27);
            this.ptnDeleteAll.Name = "ptnDeleteAll";
            this.ptnDeleteAll.Size = new System.Drawing.Size(107, 41);
            this.ptnDeleteAll.TabIndex = 8;
            this.ptnDeleteAll.Text = "مسح الكل";
            this.ptnDeleteAll.UseVisualStyleBackColor = true;
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
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(14, 251);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(672, 231);
            this.dgv.TabIndex = 16;
            // 
            // ptnFirst
            // 
            this.ptnFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptnFirst.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Actions_go_first_view_icon;
            this.ptnFirst.Location = new System.Drawing.Point(98, 22);
            this.ptnFirst.Name = "ptnFirst";
            this.ptnFirst.Size = new System.Drawing.Size(55, 52);
            this.ptnFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnFirst.TabIndex = 3;
            this.ptnFirst.TabStop = false;
            // 
            // ptnPrevious
            // 
            this.ptnPrevious.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptnPrevious.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Actions_go_previous_view_icon;
            this.ptnPrevious.Location = new System.Drawing.Point(179, 22);
            this.ptnPrevious.Name = "ptnPrevious";
            this.ptnPrevious.Size = new System.Drawing.Size(55, 52);
            this.ptnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnPrevious.TabIndex = 2;
            this.ptnPrevious.TabStop = false;
            // 
            // ptnNext
            // 
            this.ptnNext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptnNext.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Actions_go_next_view_icon;
            this.ptnNext.Location = new System.Drawing.Point(375, 22);
            this.ptnNext.Name = "ptnNext";
            this.ptnNext.Size = new System.Drawing.Size(55, 52);
            this.ptnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnNext.TabIndex = 1;
            this.ptnNext.TabStop = false;
            // 
            // ptnLast
            // 
            this.ptnLast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptnLast.Image = global::System_Library_MVP_Cours_Mahmoud_Bakr.Properties.Resources.Actions_go_last_view_icon;
            this.ptnLast.Location = new System.Drawing.Point(458, 22);
            this.ptnLast.Name = "ptnLast";
            this.ptnLast.Size = new System.Drawing.Size(55, 52);
            this.ptnLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptnLast.TabIndex = 0;
            this.ptnLast.TabStop = false;
            // 
            // FormPlaces
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 505);
            this.Controls.Add(this.ptnPlaceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlaceID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormPlaces";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أماكن الكتب";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptnLast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ptnDelete;
        private System.Windows.Forms.TextBox ptnPlaceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ptnUpdate;
        private System.Windows.Forms.Button ptnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptnFirst;
        private System.Windows.Forms.PictureBox ptnPrevious;
        private System.Windows.Forms.PictureBox ptnNext;
        private System.Windows.Forms.PictureBox ptnLast;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ptnDeleteAll;
        private System.Windows.Forms.Button ptnNew;
        private System.Windows.Forms.DataGridView dgv;
    }
}