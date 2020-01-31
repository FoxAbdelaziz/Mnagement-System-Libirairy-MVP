using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System_Library_MVP_Cours_Mahmoud_Bakr.Views.Forms
{
    public partial class FormBackUpData : Form
    {
        Logic.Services.ClassDB DB = new Logic.Services.ClassDB();
        public FormBackUpData()
        {
            InitializeComponent();
        }

        private void ptnBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogBackUp.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialogBackUp.SelectedPath;
            }
        }

        private void ptnCreate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (txtFileName.Text != "")
            {
                string FileName = txtFileName.Text + "\\BackUp DBLibraryMVPCours" + DateTime.Now.ToShortDateString().Replace('/' , '-') + " " + DateTime.Now.ToShortTimeString().Replace(':', '-');
                string msg = "";
                msg = DB.RunDml("BackUp Database DBLibraryMVPCours to Disk  = '" + FileName + ".bak' ");
                if (msg == "ok")            
                    MessageBox.Show("تم حفظ النسخة الاحتياطية بنجاح");
                else if (msg.Contains("Access is denied."))
                    MessageBox.Show("C:اختيار مكان غير هذا الفولدر عليك اختيار مكان غير الــ");
                else
                    MessageBox.Show(msg);

                txtFileName.Clear();

                this.Cursor = Cursors.Default;
            }
        }
    }
}
