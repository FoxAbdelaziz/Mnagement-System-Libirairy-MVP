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
    public partial class FormPlaces : Form
    {
        Logic.Services.ClassDB db = new Logic.Services.ClassDB();

        public FormPlaces()
        {
            InitializeComponent();
        }

        private void FormPlaces_Load(object sender, EventArgs e)
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
            tblmax = db.RunQuery("Select max (ID) From Places");
            if (tblmax.Rows[0][0].ToString() != "")
            {
                txtPlaceID.Text = (Convert.ToInt16(tblmax.Rows[0][0].ToString()) + 1).ToString();
            }
            else
            {
                txtPlaceID.Text = "1";
            }
        }
        void RefreshGrida()
        {
            DataTable tblSelect = new DataTable();
            tblSelect = db.RunQuery("Select ID 'رقم المكان' , Name 'مكان الكتاب' From Places");
            dgv.DataSource = tblSelect;
        }

        void ClearData()
        {
            txtPlaceID.Clear();
            txtPlaceName.Clear();
        }

        private void ptnAdd_Click(object sender, EventArgs e)
        {
            string msg;
            msg = db.RunDml("insert into Places values('" + txtPlaceID.Text + "',N'" + txtPlaceName.Text + "')");
            if (msg == "ok")
            {
                MessageBox.Show("Places Data Added Succeed...");
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
            msg = db.RunDml("Update Places Set Name = N'" + txtPlaceName.Text + "' Where ID ='" + txtPlaceID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Places Data Updated Succeed...");
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
            msg = db.RunDml("Delete From Places Where ID ='" + txtPlaceID.Text + "' ");
            if (msg == "ok")
            {
                MessageBox.Show("Places Data Deleted Succeed...");
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
            msg = db.RunDml("Delete From Places");
            if (msg == "ok")
            {
                MessageBox.Show("Places All Data Deleted Succeed...");
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
                txtPlaceID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPlaceName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
