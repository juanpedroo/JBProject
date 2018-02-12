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
using System.IO;

namespace projetMetro
{
    public partial class formAdminManual : MetroFramework.Forms.MetroForm
    {
        public formAdminManual()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //axAcroPDF1.src()
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
            axAcroPDF1.LoadFile("AdminHelpFile.pdf");
        }

        private void formAdminManual_Load(object sender, EventArgs e)
        {
            byte[] PDF = Properties.Resources.ManuelAdmin;

            MemoryStream ms = new MemoryStream(PDF);

            //Create PDF File From Binary of resources folders helpFile.pdf
            FileStream f = new FileStream("AdminHelpFile.pdf", FileMode.OpenOrCreate);

            //Write Bytes into Our Created helpFile.pdf
            ms.WriteTo(f);
            f.Close();
            ms.Close();

            // Finally Show the Created PDF from resources 
            axAcroPDF1.LoadFile("AdminHelpFile.pdf.pdf");
        }

        private void formAdminManual_FormClosed(object sender, FormClosedEventArgs e)
        {
            clearAxPDF();
            this.Close();
        }
    }
}
