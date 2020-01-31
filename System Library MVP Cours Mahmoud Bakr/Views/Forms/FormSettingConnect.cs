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
    public partial class FormSettingConnect : Form
    {
        public FormSettingConnect()
        {
            InitializeComponent();
        }

        private void ptnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerName = txtServerName.Text;
            Properties.Settings.Default.Mode = rdSqlServer.Checked ==true ? "Sql Server  Authentication" : "Windows Authentication";
            Properties.Settings.Default.Database = txtDBNamae.Text;
            Properties.Settings.Default.Username = txtUsername.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("تم حفظ اعدادت الاتصال بنجاح");
        }

        private void ptnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSettingConnect_Load(object sender, EventArgs e)
        {
            txtServerName.Text = Properties.Settings.Default.ServerName;
            txtDBNamae.Text = Properties.Settings.Default.Database;

            if (Properties.Settings.Default.Mode == "Sql Server  Authentication")
            {
                rdSqlServer.Checked = true;
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;

                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                rdWindows.Checked = false;
                txtUsername.Clear();
                txtPassword.Clear();

                txtUsername.Enabled= false;
                txtPassword.Enabled = false;
            }
        }

        private void rdWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (rdWindows.Checked == true)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;

                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void rdSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSqlServer.Checked == true)
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;

                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
            else
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;

                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
