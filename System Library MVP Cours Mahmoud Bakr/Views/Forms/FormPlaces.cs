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
 
        }
    }
}
