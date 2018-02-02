﻿using System;
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

            DialogResult result = MetroMessageBox.Show(this, "\n\nVoulez vous vraiment vous déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                formMain fMain = new formMain();
                fMain.Show();
                this.Visible = false;
            }




        }

        private void mTileAddEleve_Click(object sender, EventArgs e)
        {
            formAddEleve fAddE = new formAddEleve();
            fAddE.Show();
            this.Visible = false;
        }

        private void mTileDelEleve_Click(object sender, EventArgs e)
        {
            formDelEleve fDelE = new formDelEleve();
            fDelE.Show();
            
        }

        private void mTileDispEleve_Click(object sender, EventArgs e)
        {
            formDispEleve fDisE = new formDispEleve();
            fDisE.Show();
        }
    }
}