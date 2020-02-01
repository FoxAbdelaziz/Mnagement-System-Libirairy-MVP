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
    public partial class FormCountry : Form
    {
        public FormCountry()
        {
            InitializeComponent();
        }
        Logic.Services.ClassDB db = new Logic.Services.ClassDB();

        private void FormCountry_Load(object sender, EventArgs e)
        {

            MaxID();
            RefreshGrida();
        }

        private void ptnNew_Click(object sender, EventArgs e)
        {
            RefreshGrida();
            ClearData();
            MaxID();
        }

        void ClearData()
        {
            txtCountryID.Clear();
            txtCountryCode.Clear();
            txtCountry.Clear();
        }
        void MaxID()
        {
            DataTable tblmax = new DataTable();
            tblmax = db.RunQuery("Select max (ID) From Countrys");
            if (tblmax.Rows[0][0].ToString() != "")
            {
                txtCountryID.Text = (Convert.ToInt16(tblmax.Rows[0][0].ToString()) + 1).ToString();
            }
            else
            {
                txtCountryID.Text = "1";
            }
        }
        void RefreshGrida()
        {
            DataTable tblSelect = new DataTable();
            tblSelect = db.RunQuery("Select ID 'رقم الدولة', Code 'كود الدولة', Name 'الدولة' From Countrys");
            dgv.DataSource = tblSelect;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCountryID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCountryCode.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCountry.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void ptnAdd_Click(object sender, EventArgs e)
        {
            string msg;
            msg = db.RunDml("insert into Countrys values('" + txtCountryID.Text + "',N'" + txtCountryCode.Text + "','" + txtCountry.Text + "' )");
            if (msg == "ok")
            {
                MessageBox.Show("Countrys Data Added Succeed...");
            }
            else
            {
                MessageBox.Show(msg);
            }
            RefreshGrida();
            ClearData();
            MaxID();
        }

        private void ptnUpdate_Click(object sender, EventArgs e)
        {
            string msg;
            msg = db.RunDml("Update Countrys Set Code = N'" + txtCountryCode.Text + "' , Name = '" + txtCountry.Text + "' Where ID ='" + txtCountryID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Countrys Data Updated Succeed...");
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
            msg = db.RunDml("Delete From Countrys Where ID ='" + txtCountryID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Countrys Data Deleted Succeed...");
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
            msg = db.RunDml("Countrys From Authors");
            if (msg == "ok")
            {
                MessageBox.Show("Countrys All Data Deleted Succeed...");
            }
            else
            {
                MessageBox.Show(msg);
            }
            RefreshGrida();
            ClearData();
        }
    }
}
