﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace projetMetro
{
    public partial class formAdmin : MetroFramework.Forms.MetroForm
    {
        public formAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("fr-FR");
            Application.CurrentCulture = cultureInfo;
           
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {

        }
        
        
        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            //string msg = "Etes-vous sûr de vouloir quitter le mode administrateur ?";
            //string title = "Confirmation";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //MessageBox.Show(msg, title, buttons);
            

            // Displays the MessageBox.

            DialogResult result = MetroMessageBox.Show(this, "\n\nVoulez-vous vraiment vous déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //this.Hide();
                //formMain fMain = new formMain();
                //fMain.Show();
                this.Close();
            }




        }

        private void mTileAddEleve_Click(object sender, EventArgs e)
        {
           //  this.Hide();
            formAddEleve fAddE = new formAddEleve();
            fAddE.ShowDialog();

            
        }

        private void mTileDelEleve_Click(object sender, EventArgs e)
        {
            formDelEleve fDelE = new formDelEleve();
            fDelE.ShowDialog();
            
        }

        private void mTileDispEleve_Click(object sender, EventArgs e)
        {
            formDispEleve fDisE = new formDispEleve();
            fDisE.ShowDialog();
        }

        private void mTilePath_Click(object sender, EventArgs e)
        {
            formPath fPath = new formPath();
            fPath.ShowDialog();
        }

        private void formAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //formMain fMain = new formMain();
            //fMain.Show();
            this.Close();
        }

        private void mTileManualAdmin_Click(object sender, EventArgs e)
        {
            formAdminManual fAManual = new formAdminManual();
            fAManual.ShowDialog();
        }

        private void mTileBarcode_Click(object sender, EventArgs e)
        {
                byte[] bytes = Properties.Resources.ManuelAdmin;
            using (FileStream fs = File.Create("Manuel.pdf"))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            Process.Start("Manuel.pdf");

            //xProcess barcode = Process.Start("");

        }

        private void mTileConvert_Click(object sender, EventArgs e)
        {
            byte[] bytes = Properties.Resources.ManuelAdmin;
            using (FileStream fs = File.Create("Aide.pdf"))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            Process.Start("Aide.pdf");

          
        }

        private void mTileStats_Click(object sender, EventArgs e)
        {
            formStats fStats = new formStats();
            fStats.ShowDialog();
        }

        private void mTileStatut_Click(object sender, EventArgs e)
        {
            formStatus fStatus = new formStatus();
            fStatus.ShowDialog();
        }

        private void mTileLinkServ_Click(object sender, EventArgs e)
        {
            formLinkServer fLinkS = new formLinkServer();
            fLinkS.ShowDialog();
        }

        private void metroTileImport_Click(object sender, EventArgs e)
        {
            formImport fImport = new formImport();
            fImport.ShowDialog();
        }

        private void mTileManualAdmin_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show(mTileManualAdmin.Text, mTileManualAdmin);
        }

        private void mTileActionBD_Click(object sender, EventArgs e)
        {
            formPurge fPurge = new formPurge();
            fPurge.ShowDialog();
        }
    }
}
