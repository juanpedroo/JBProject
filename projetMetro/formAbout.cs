using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetMetro
{
    public partial class formAbout : MetroFramework.Forms.MetroForm
    {
        public formAbout()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {

            formMain.fMain.Visible = true;
            this.Close();
        }

        private void formAbout_Load(object sender, EventArgs e)
        {

        }

        private void formAbout_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain fMain = new formMain();
            fMain.Show();
        }
    }
}
