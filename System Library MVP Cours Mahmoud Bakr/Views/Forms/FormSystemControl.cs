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
    public partial class FormSystemControl : Form
    {
        Logic.Services.ClassDB DB = new Logic.Services.ClassDB();
        public FormSystemControl()
        {
            InitializeComponent();
        }

        private void FormSystemControl_Load(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = DB.RunQuery("Select  Username 'اسم المستخدم', Password 'الرقم السري', PDateTime 'وقت الدخول', ProcessStatus 'عملية الدخول' From [ControlSystem] Order By PDateTime desc");
            dgv.DataSource = tbl;

        }

        private void ptnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف بيانات عمليات الدخول ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string msg = "";
                msg = DB.RunDml("Delete From [ControlSystem]");
                if (msg == "ok")

                    MessageBox.Show("تم حذف بيانات عمليات الدخول بنجاح");
                else
                    MessageBox.Show(msg);

                FormSystemControl_Load(null, null);
            }
        }
    }
}