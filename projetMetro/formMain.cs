using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projetMetro
{
    public partial class formMain : MetroFramework.Forms.MetroForm
    {
        //public static formMain fMain = new formMain();
        public formMain()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            if (formPath.cal == "")
            {
                formPath.cal = "C:\\cal";
            }
            if (formPath.pdf == "")
            {
                formPath.pdf = "C:\\pdf";
            }

            formPath.cal = Properties.Settings.Default.pathCal;
            formPath.pdf = Properties.Settings.Default.pathPDF;
            
        }

        private void mTileUser_Click(object sender, EventArgs e)
        {
            MySqlConnection _Connection = new MySqlConnection();
            string _ConnectionString = "Database=projet;DataSource=10.11.21.189;UserId=user;Password=";
            _Connection.ConnectionString = _ConnectionString;

            try
            {
                _Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            _Connection.Close();
            //this.Hide();
            formUser fUser = new formUser();
            fUser.Show();
            this.Visible = false;
            fUser.Activate();
            ///this.Close();
        }

        private void mTileAbout_Click(object sender, EventArgs e)
        {
            
            formAbout fAbout = new formAbout();
            fAbout.Show();
            this.Visible = false;
            //this.Close();
        }

        private void mTileAdmin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            formBeforeAdmin fBAdmin = new formBeforeAdmin();
            fBAdmin.Show();
            this.Visible = false;
            //this.Close();
        }

        private void mTileHelp_Click(object sender, EventArgs e)
        {
            //this.Hide();
            formHelp fHelp = new formHelp();
            fHelp.Show();
            this.Visible = false;
            //this.Close();
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
