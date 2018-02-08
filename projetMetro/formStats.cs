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
    public partial class formStats : MetroFramework.Forms.MetroForm
    {
        public formStats()
        {
            InitializeComponent();
        }

        

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formStats_Load(object sender, EventArgs e)
        {
            
            mLabelScanEleve.Text = Convert.ToString(Eleve.getNbEleveScannes());
        }
    }
}
