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
    public partial class FormDar_Nashr : Form
    {
        Logic.Services.ClassDB db = new Logic.Services.ClassDB();

        public FormDar_Nashr()
        {
            InitializeComponent();
        }
        BindingManagerBase bmb;

        private void FormDar_Nashr_Load(object sender, EventArgs e)
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
            tblmax = db.RunQuery("Select max (ID) From Dar_Nashr");
            if (tblmax.Rows[0][0].ToString() != "")
            {
                txtDarID.Text = (Convert.ToInt16(tblmax.Rows[0][0].ToString()) + 1).ToString();
            }
            else
            {
                txtDarID.Text = "1";
            }
        }
        void RefreshGrida()
        {
            DataTable tblSelect = new DataTable();
            tblSelect = db.RunQuery("Select d.ID 'رقم دار النشر', d.Name 'دار النشر', c.Name 'الدولة' From Dar_Nashr d , Countrys c Where d.Country_ID = c.ID");
            dgv.DataSource = tblSelect;

            bmb = this.BindingContext[tblSelect];
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }
        void ClearData()
        {
            txtDarID.Clear();
            txtDarName.Clear();
        }
        private void ptnNew_Click(object sender, EventArgs e)
        {
            RefreshGrida();
            ClearData();
            MaxID();
            ptnAdd.Enabled = true;
            ptnNew.Enabled = false;

            ptnUpdate.Enabled = false;
            ptnDelete.Enabled = false;
            ptnDeleteAll.Enabled = false;
        }

        private void ptnAdd_Click(object sender, EventArgs e)
        {
            string msg;
            msg = db.RunDml("insert into Dar_Nashr values('" + txtDarID.Text + "',N'" + txtDarName.Text + "','" + cmbCountry.SelectedValue + "' )");
            if (msg == "ok")
            {
                MessageBox.Show("Dar Nashr Data Added Succeed...");
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
            msg = db.RunDml("Update Dar_Nashr Set Name = N'" + txtDarName.Text + "' , Country_ID = '" + cmbCountry.SelectedValue + "' Where ID ='" + txtDarID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Dar Nashr Data Updated Succeed...");
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
            msg = db.RunDml("Delete From Dar_Nashr Where ID ='" + txtDarID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Dar Nashr Data Deleted Succeed...");
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
            msg = db.RunDml("Delete From Dar_Nashr");
            if (msg == "ok")
            {
                MessageBox.Show("Dar Nashr All Data Deleted Succeed...");
            }
            else
            {
                MessageBox.Show(msg);
            }
            RefreshGrida();
            ClearData();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDarID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDarName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbCountry.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();

                ptnUpdate.Enabled = true;
                ptnDelete.Enabled = true;
                ptnDeleteAll.Enabled = true;

                ptnAdd.Enabled = false;
                ptnNew.Enabled = true;
            }
        }

        private void ptnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void ptnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void ptnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void ptnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPostion.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }
    }
}
