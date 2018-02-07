using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace projetMetro
{
    public partial class formAdminManual : MetroFramework.Forms.MetroForm
    {
        public formAdminManual()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public void clearAxPDF()
        {
            if (axAcroPDF1 != null)
            {
                foreach (Process proc in Process.GetProcessesByName("AcroRd32"))
                {
                    proc.Kill();
                }
            }
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mLinkRetry_Click(object sender, EventArgs e)
        {
            clearAxPDF();
            axAcroPDF1.LoadFile("C:/Users/Baptiste/Desktop/MetroProjet/manualAdmin.pdf");
        }

        private void formAdminManual_Load(object sender, EventArgs e)
        {
            
            axAcroPDF1.LoadFile("C:/Users/Baptiste/Desktop/MetroProjet/manualAdmin.pdf");
        }

        private void formAdminManual_FormClosed(object sender, FormClosedEventArgs e)
        {
            clearAxPDF();
            this.Close();
        }
    }
}
