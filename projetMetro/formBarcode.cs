﻿using System;
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
    public partial class formBarcode : MetroFramework.Forms.MetroForm
    {
        public formBarcode()
        {
            InitializeComponent();
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}