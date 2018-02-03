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
        public static formMain fMain = new formMain();
        public formMain()
        {
            InitializeComponent();
            formPath.cal = "C:\\";
            formPath.pdf = "C:\\";

        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void mTileUser_Click(object sender, EventArgs e)
        {
            MySqlConnection _Connection = new MySqlConnection();
            string _ConnectionString = "Database=projet;DataSource=localhost;UserId=user;Password=";
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
            formUser fUser = new formUser();
            fUser.Show();
            //this.Visible = false;
            this.Hide();
            //this.Close();
        }

        private void mTileAbout_Click(object sender, EventArgs e)
        {
            formAbout fAbout = new formAbout();
            fAbout.Show();
            this.Visible = false;

        }

        private void mTileAdmin_Click(object sender, EventArgs e)
        {
            formBeforeAdmin fBAdmin = new formBeforeAdmin();
            fBAdmin.Show();
            this.Visible = false;
        }

        private void mTileHelp_Click(object sender, EventArgs e)
        {
            formHelp fHelp = new formHelp();
            fHelp.Show();
            this.Visible = false;
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
