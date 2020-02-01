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
    public partial class FormAuthors : Form
    {
        public FormAuthors()
        {
            InitializeComponent();

        }
        Logic.Services.ClassDB db = new Logic.Services.ClassDB();

        private void FormAuthors_Load(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = db.RunQuery("Select * from Countrys");
            cmbCountry.DataSource = tbl;
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "ID";

            RefreshGrida();

            MaxID();
        }

        void MaxID()
        {
            DataTable tblmax = new DataTable();
            tblmax = db.RunQuery("Select max (ID) From Authors");
            if (tblmax.Rows[0][0].ToString() != "")
            {
                txtAuthID.Text = (Convert.ToInt16(tblmax.Rows[0][0].ToString()) + 1).ToString();
            }
            else
            {
                txtAuthID.Text = "1";
            }
        }
        private void ptnAdd_Click(object sender, EventArgs e)
        {
            string msg;
            msg = db.RunDml("insert into Authors values('" + txtAuthID.Text + "',N'" + txtAuth.Text + "','"+ dtpDOB.Value.ToShortDateString() + "' , '" + cmbCountry.SelectedValue + "')");
            if (msg == "ok")
            {
                MessageBox.Show("Authors Data Added Succeed...");
            }
            else
            {
                MessageBox.Show(msg);
            }
            RefreshGrida();
            ClearData();
            MaxID();
        }

        void RefreshGrida()
        {
            DataTable tblSelect = new DataTable();
            tblSelect = db.RunQuery("Select a.ID 'رقم المؤلف', a.Name 'أسم المؤلف', a.DOB 'تاريخ الميلاد', c.Name 'الدولة' from Authors a, Countrys c where a.Country_ID = c.ID ");
            dgv.DataSource = tblSelect;
        }

        private void ptnUpdate_Click(object sender, EventArgs e)
        {
            string msg;
            msg = db.RunDml("Update Authors Set Name = N'" + txtAuth.Text + "', DOB = '" + dtpDOB.Value.ToShortDateString() + "' , Country_ID = '" + cmbCountry.SelectedValue + "' Where ID ='" + txtAuthID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Authors Data Updated Succeed...");
            }
            else
            {
                MessageBox.Show(msg);
            }
            RefreshGrida();
            ClearData();
        }

        private void ptnDelete_Click(object sender, EventArgs e)
        {
            string msg;
            msg = db.RunDml("Delete From Authors Where ID ='" + txtAuthID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Authors Data Deleted Succeed...");
            }
            else
            {
                MessageBox.Show(msg);
            }
            RefreshGrida();
            ClearData();
        }

        private void ptnDeleteAll_Click(object sender, EventArgs e)
        {
            string msg;
            msg = db.RunDml("Delete From Authors");
            if (msg == "ok")
            {
                MessageBox.Show("Authors All Data Deleted Succeed...");
            }
            else
            {
                MessageBox.Show(msg);
            }
            RefreshGrida();
            ClearData();
        }

        void ClearData()
        {
            txtAuthID.Clear();
            txtAuth.Clear();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAuthID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAuth.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpDOB.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbCountry.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void ptnNew_Click(object sender, EventArgs e)
        {
            RefreshGrida();
            ClearData();
            MaxID();
        }
    }
}