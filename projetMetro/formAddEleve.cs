using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace projetMetro
{
    public partial class formAddEleve : MetroFramework.Forms.MetroForm
    {
        public formAddEleve()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            formAdmin fAdmin = new formAdmin();
            fAdmin.Show();
            this.Visible = false;
        }
    }
}
