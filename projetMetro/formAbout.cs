﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            //this.WindowState = FormWindowState.Maximized;
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            

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

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/juanpedroo/JBProject");
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/juanpedroo/JBProject");
        }

        private void mLinkJF_Click(object sender, EventArgs e)
        {
            Process.Start("https://jonathanferreira.ovh/");
        }

        private void mLinkBP_Click(object sender, EventArgs e)
        {
            Process.Start("https://baptistepautard.wordpress.com/");
        }
    }
}
