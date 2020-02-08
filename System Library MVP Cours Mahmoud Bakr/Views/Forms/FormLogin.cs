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
    public partial class FormLogin : Form
    {
        Logic.Services.ClassDB DB = new Logic.Services.ClassDB();
        public FormLogin()
        {
            InitializeComponent();
        }
        int TryLogin = 0;

        DataTable tbl = new DataTable();

        private void ptnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                tbl = DB.RunQuery("Select * From ViewUsers Where Username = N'" + txtUsername.Text + "' And Password = '" + txtPassword.Text + "' ");
                if (tbl.Rows.Count > 0)
                {
                    FormMain.GetMainForm.lblEmpID.Text = tbl.Rows[0][0].ToString();
                    FormMain.GetMainForm.lblUser.Text = tbl.Rows[0][3].ToString();
                    FormMain.GetMainForm.lblEmployee.Text = tbl.Rows[0][1].ToString();
                    FormMain.GetMainForm.lblJob.Text = tbl.Rows[0][2].ToString();

                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        if (tbl.Rows[i][5].ToString() == "شاشة النسخة الاحتياطية")
                        {
                            FormMain.GetMainForm.MenuBackUpDate.Enabled = true;
                        }
                        else if (tbl.Rows[i][5].ToString() == "شاشة استعادة البيانات")
                        {
                            FormMain.GetMainForm.MenuRestorData.Enabled = true;
                        }
                        else if (tbl.Rows[i][5].ToString() == "البيانات الأساسية")
                        {
                            FormMain.GetMainForm.MenuBiscData.Enabled = true;
                            FormMain.GetMainForm.ToolStripMenuCategory.Enabled = true;
                            FormMain.GetMainForm.toolStripCategory.Enabled = true;
                            FormMain.GetMainForm.ToolStripMenuAuthors.Enabled = true;
                            FormMain.GetMainForm.toolStripAuthors.Enabled = true;
                            FormMain.GetMainForm.ToolStripMenuPlaces.Enabled = true;
                            FormMain.GetMainForm.toolStripPlaces.Enabled = true;
                            FormMain.GetMainForm.ToolStripMenuDarNashr.Enabled = true;
                            FormMain.GetMainForm.toolStripDarNashr.Enabled = true;
                            FormMain.GetMainForm.ToolStripMenuCountry.Enabled = true;
                            FormMain.GetMainForm.toolStripCountry.Enabled = true;                           
                        }
                        else if (tbl.Rows[i][5].ToString() == "التقارير")
                        {
    
                            
                        }
                        else if (tbl.Rows[i][5].ToString() == "الادارة")
                        {
 
                        }
                    }
                    FormMain.GetMainForm.lblDateEnter.Text = DateTime.Now.ToString();

                    string msg = "";
                    string Process = "عملية الدخول نجحت";
                    msg = DB.RunDml("Insert into [ControlSystem] Values (N'" + txtUsername.Text + "' , '" + txtPassword.Text + "' , '" + DateTime.Now + "' , N'" + Process + "' , ' ' , ' ')");
                    FormMain.GetMainForm.lblServer.Text = Properties.Settings.Default.ServerName.ToString();


                    this.Close();
                }
                else
                {
                    string msg = "";
                    string Process = "عملية الدخول فشلت";
                    msg = DB.RunDml("Insert into [ControlSystem] Values (N'" + txtUsername.Text + "' , '" + txtPassword.Text + "' , '" + DateTime.Now + "' , N'" + Process + "'  , ' ' , ' ')");

                    MessageBox.Show("أسم المستخدم / الرقم السري خطأ | حاول مرة أخري");
                    TryLogin++;
                    if (TryLogin == 3)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Object reference not set to an instance of an object."))
                {
                    MessageBox.Show("حدث خطا في الاتصال بقاعدة البيانات");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBoxShowPaass_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxShowPaass.Image = Properties.Resources.Hied;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pictureBoxShowPaass_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxShowPaass.Image = Properties.Resources.Show;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBoxShowPaass_Click(object sender, EventArgs e)
        {
            pictureBoxShowPaass.Image = Properties.Resources.Show;
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
