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
            axAcroPDF1.LoadFile(Properties.Resources.ManuelAdmin+".pdf");
        }

        private void formAdminManual_Load(object sender, EventArgs e)
        {
            //axAcroPDF1.LoadFile(Properties.Resources.ManuelAdmin+".pdf");
            //get current folderpath of the .exe
            string ProgramPath = AppDomain.CurrentDomain.BaseDirectory;
            //jump back relative to the .exe-Path to the Resources Path
            string FileName = string.Format("{0}Resources\\ManuelAdmin", Path.GetFullPath(Path.Combine(ProgramPath, @"..\..\")));

            //Open PDF
            System.Diagnostics.Process.Start(@"" + FileName + "");
        }

        private void formAdminManual_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAdmin fAdmin = new formAdmin();
            fAdmin.Show();
        }
    }
}
