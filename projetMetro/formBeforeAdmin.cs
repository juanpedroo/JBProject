using MySql.Data.MySqlClient;
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
    public partial class formBeforeAdmin : MetroFramework.Forms.MetroForm
    {
        public formBeforeAdmin()
        {
            InitializeComponent();
            
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            
            formMain fMain = new formMain();
            fMain.Show();
            //this.Visible = false;
            this.Close();
        }

        private void formBeforeAdmin_Load(object sender, EventArgs e)
        {
            mTBusername.Focus();
        }

        static public string pass = "";

        MySqlConnection _Connection = new MySqlConnection("Data Source=projet;Initial Catalog=BDD;UserId=user;Password=");

        private void mBTconnect_Click(object sender, EventArgs e)
        {
            pass = mTBpassword.Text;
            string usr = mTBusername.Text;

            if (mTBusername.Text == "admin")
            {
                string _ConnectionString = "Database=projet;DataSource=localhost;UserId=admin;Password=" + pass;
                _Connection.ConnectionString = _ConnectionString;

                try
                {
                    _Connection.Open();
                }
                catch
                {
                    mLabelEtat.Text = "Le nom de compte ou le mot de passe est incorrect";
                    mTBusername.BackColor = Color.Crimson;
                    mTBpassword.BackColor = Color.Crimson;
                    mTBusername.ForeColor = Color.White;
                    mTBpassword.ForeColor = Color.White;
                    mTBpassword.Clear();
                    mTBusername.Clear();
                    mTBusername.Select();
                    //MessageBox.Show("Le nom de compte ou le mot de passe est incorrect");
                    return;
                }
                _Connection.Close();
                this.Hide();
                formAdmin fAdmin = new formAdmin();
                fAdmin.Show();
                //this.Visible = false;
                this.Close();
            }
            else
            {
                mLabelEtat.Text = "Le nom de compte ou le mot de passe est incorrect";
                mTBusername.BackColor = Color.Crimson;
                mTBpassword.BackColor = Color.Crimson;
                mTBusername.ForeColor = Color.White;
                mTBpassword.ForeColor = Color.White;
                mTBpassword.Clear();
                mTBusername.Clear();
                mTBusername.Select();
            }
        }
    }
}
