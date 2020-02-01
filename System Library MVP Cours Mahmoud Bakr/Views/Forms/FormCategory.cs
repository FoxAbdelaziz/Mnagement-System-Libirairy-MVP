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
    public partial class FormCategory : Form
    {
        Logic.Services.ClassDB db = new Logic.Services.ClassDB();

        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            RefreshGrida();

            MaxID();
        }

        private void ptnNew_Click(object sender, EventArgs e)
        {
            RefreshGrida();
            ClearData();
            MaxID();
        }

        void MaxID()
        {
            DataTable tblmax = new DataTable();
            tblmax = db.RunQuery("Select max (ID) From Categorys");
            if (tblmax.Rows[0][0].ToString() != "")
            {
                txtCatID.Text = (Convert.ToInt16(tblmax.Rows[0][0].ToString()) + 1).ToString();
            }
            else
            {
                txtCatID.Text = "1";
            }
        }
        void RefreshGrida()
        {
            DataTable tblSelect = new DataTable();
            tblSelect = db.RunQuery(" Select ID 'رقم التصنيف', Name 'أسم التصنيف' From Categorys");
            dgv.DataSource = tblSelect;
        }

        void ClearData()
        {
            txtCatID.Clear();
            txtCatName.Clear();
        }
        private void ptnAdd_Click(object sender, EventArgs e)
        {
            string msg;
            msg = db.RunDml("insert into Categorys values('" + txtCatID.Text + "',N'" + txtCatName.Text + "')");
            if (msg == "ok")
            {
                MessageBox.Show("Categorys Data Added Succeed...");
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
            msg = db.RunDml("Update Categorys Set Name = N'" + txtCatName.Text + "' Where ID ='" + txtCatID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Categorys Data Updated Succeed...");
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
            msg = db.RunDml("Delete From Categorys Where ID ='" + txtCatID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Categorys Data Deleted Succeed...");
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
            msg = db.RunDml("Delete From Categorys");
            if (msg == "ok")
            {
                MessageBox.Show("Categorys All Data Deleted Succeed...");
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
                txtCatID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCatName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
