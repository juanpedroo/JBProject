using System;
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

namespace projetMetro
{
    public partial class formHelp : MetroFramework.Forms.MetroForm
    {
        public formHelp()
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
            //this.Hide();
           
            //this.Visible = false;
            this.Close();
        }

        private void mLinkRetry_Click(object sender, EventArgs e)
        {
            clearAxPDF();
            axAcroPDF1.LoadFile("helpFile.pdf");

        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void formHelp_Load(object sender, EventArgs e)
        {
            byte[] PDF = Properties.Resources.ManuelUtilisateur;

            MemoryStream ms = new MemoryStream(PDF);

            //Create PDF File From Binary of resources folders helpFile.pdf
            FileStream f = new FileStream("helpFile.pdf", FileMode.OpenOrCreate);

            //Write Bytes into Our Created helpFile.pdf
            ms.WriteTo(f);
            f.Close();
            ms.Close();

            // Finally Show the Created PDF from resources 
            axAcroPDF1.LoadFile("helpFile.pdf");
        }

        private void formHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain fMain = new formMain();
            fMain.Show();
        }
    }
}
