namespace System_Library_MVP_Cours_Mahmoud_Bakr.Views.Forms
{
    partial class FormBackUpData
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
            this.ptnBrowser = new System.Windows.Forms.Button();
            this.ptnCancel = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptnCreate = new System.Windows.Forms.Button();
            this.folderBrowserDialogBackUp = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ptnBrowser
            // 
            this.ptnBrowser.Location = new System.Drawing.Point(727, 98);
            this.ptnBrowser.Name = "ptnBrowser";
            this.ptnBrowser.Size = new System.Drawing.Size(75, 37);
            this.ptnBrowser.TabIndex = 9;
            this.ptnBrowser.Text = ".......";
            this.ptnBrowser.UseVisualStyleBackColor = true;
            this.ptnBrowser.Click += new System.EventHandler(this.ptnBrowser_Click);
            // 
            // ptnCancel
            // 
            this.ptnCancel.Location = new System.Drawing.Point(373, 168);
            this.ptnCancel.Name = "ptnCancel";
            this.ptnCancel.Size = new System.Drawing.Size(247, 64);
            this.ptnCancel.TabIndex = 8;
            this.ptnCancel.Text = "الغاء";
            this.ptnCancel.UseVisualStyleBackColor = true;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(30, 98);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(674, 37);
            this.txtFileName.TabIndex = 7;
            this.txtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "رجاء اختيار مكان حفظ النسخة الاحتياطيية";
            // 
            // ptnCreate
            // 
            this.ptnCreate.Location = new System.Drawing.Point(77, 168);
            this.ptnCreate.Name = "ptnCreate";
            this.ptnCreate.Size = new System.Drawing.Size(247, 64);
            this.ptnCreate.TabIndex = 5;
            this.ptnCreate.Text = "انشاء النسخة ";
            this.ptnCreate.UseVisualStyleBackColor = true;
            this.ptnCreate.Click += new System.EventHandler(this.ptnCreate_Click);
            // 
            // FormBackUpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 277);
            this.Controls.Add(this.ptnBrowser);
            this.Controls.Add(this.ptnCancel);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptnCreate);
            this.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "FormBackUpData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة عمل نسخة أحتياطية";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ptnBrowser;
        private System.Windows.Forms.Button ptnCancel;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ptnCreate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBackUp;
    }
}