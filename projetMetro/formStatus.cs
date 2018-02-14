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
    public partial class formStatus : MetroFramework.Forms.MetroForm
    {
        private bool dbConnectionState;

        public formStatus()
        {
            InitializeComponent();
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formStatus_Load(object sender, EventArgs e)
        {

        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string connStr = "server=" + formLinkServer.serv + ";userid=admin;password=" + formBeforeAdmin.pass + ";database=projet;Connection Timeout=3";
            MySqlConnection conn = new MySqlConnection(connStr);
            

            try
            {
                conn.Open();
                metroTile1.ForeColor = Color.White;
                metroTile1.BackColor = Color.Green;
                metroTile1.Text = "Fonctionnel";
            }
            catch
            {
                
                metroTile1.ForeColor = Color.White;
                metroTile1.BackColor = Color.Red;
                metroTile1.Text = "Problème d'accès au serveur ou à la BD";

            }
        }
    }
}
