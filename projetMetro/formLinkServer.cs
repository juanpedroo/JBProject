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
    public partial class formLinkServer : MetroFramework.Forms.MetroForm
    {
        public static string serv = "";
        public formLinkServer()
        {
            InitializeComponent();
            mLbServ.Text = "";
            mLbServ.Text = Properties.Settings.Default.pathServ;
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btServ_Click(object sender, EventArgs e)
        {
            serv = mTbServ.Text;
            mLbServ.Text = serv;

        }

        private void formLinkServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.pathServ = serv;
            Properties.Settings.Default.Save();
        }
    }
}
