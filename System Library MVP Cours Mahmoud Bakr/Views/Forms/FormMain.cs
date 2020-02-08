using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Library_MVP_Cours_Mahmoud_Bakr.Views.Forms
{
    public partial class FormMain : Form
    {
        private static FormMain frm;
        static void FormClose(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FormMain GetMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FormMain();
                    frm.FormClosed += new FormClosedEventHandler(FormClose);
                }
                return frm;
            }
        }
        public FormMain()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
        }

        private void ToolStripMenuCategory_Click(object sender, EventArgs e)
        {
            new FormCategory().ShowDialog();
        }

        private void toolStripCategory_Click(object sender, EventArgs e)
        {
            new FormCategory().ShowDialog();

        }

        private void toolStripPlaces_Click(object sender, EventArgs e)
        {
            new FormPlaces().ShowDialog();

        }

        private void ToolStripMenuPlaces_Click(object sender, EventArgs e)
        {
            new FormPlaces().ShowDialog();

        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDateDay.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblDay.Text = new System.Globalization.CultureInfo("AR-EG").DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
        }

        private void toolStripAuthors_Click(object sender, EventArgs e)
        {
            new FormAuthors().ShowDialog();

        }

        private void ToolStripMenuAuthors_Click(object sender, EventArgs e)
        {
            new FormAuthors().ShowDialog();

        }

        private void toolStripDarNashr_Click(object sender, EventArgs e)
        {
            new FormDar_Nashr().ShowDialog();

        }

        private void ToolStripMenuDarNashr_Click(object sender, EventArgs e)
        {
            new FormDar_Nashr().ShowDialog();

        }

        private void ToolStripMenuCountry_Click(object sender, EventArgs e)
        {
            new FormCountry().ShowDialog();

        }

        private void MenuSettingConnect_Click(object sender, EventArgs e)
        {
            new FormSettingConnect().ShowDialog();
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripCountry_Click(object sender, EventArgs e)
        {
            new FormCountry().ShowDialog();

        }

        private void MenuBackUpDate_Click(object sender, EventArgs e)
        {
            new FormBackUpData().ShowDialog();

        }

        private void MenuRestorData_Click(object sender, EventArgs e)
        {
            new FormRestorData().ShowDialog();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            new FormLogin().ShowDialog();

        }
    }
}
