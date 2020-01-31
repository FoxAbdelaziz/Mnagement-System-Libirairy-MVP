﻿using System;
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

        private void FormDar_Nashr_Load(object sender, EventArgs e)
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
    }
}
