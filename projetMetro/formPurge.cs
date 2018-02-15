using MetroFramework;
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
    public partial class formPurge : MetroFramework.Forms.MetroForm
    {
        public formPurge()
        {
            InitializeComponent();
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formPurge_FormClosed(object sender, FormClosedEventArgs e)
        {
            //formMain fAdmin = new formMain();
            //fMain.Show();
        }

        private void mBTpurgeE_Click(object sender, EventArgs e)
        {
            MySqlConnection _Connection = null;
            
            string mdp = formBeforeAdmin.pass;

            try
            {
                MySqlCommand requete = new MySqlCommand();
                _Connection = new MySqlConnection("Database=projet;DataSource=" + formLinkServer.serv + ";UserId=admin;Password=" + mdp);
                requete.Connection = _Connection;
                requete.CommandText = "delete from eleve;";
                _Connection.Open();

                string message = "Etes-vous sur de vouloir vider la table élève de la base de données ?";
                string caption = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MetroMessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Asterisk);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MySqlDataReader readerRequete = requete.ExecuteReader();
                    //this.Close();
                    string mess = "Retournez au menu principal ?";
                    string capt = "Confirmation";
                    MessageBoxButtons butt = MessageBoxButtons.YesNo;
                    DialogResult res;
                    res = MetroMessageBox.Show(this, mess, capt, butt, MessageBoxIcon.Asterisk);

                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {

                    }
                }

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    //this.Close();
                    string mess = "Retournez au menu principal ?";
                    string capt = "Confirmation";
                    MessageBoxButtons butt = MessageBoxButtons.YesNo;
                    DialogResult res;
                    res = MetroMessageBox.Show(this, mess, capt, butt, MessageBoxIcon.Asterisk);

                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            _Connection.Close();
        }
      

        private void mBTpurge_Click(object sender, EventArgs e)
        {
            MySqlConnection _Connection = null;
            
            string mdp = formBeforeAdmin.pass;

            try
            {
                MySqlCommand requete = new MySqlCommand();
                _Connection = new MySqlConnection("Database=projet;DataSource=" + formLinkServer.serv + ";UserId=admin;Password=" + mdp);
                requete.Connection = _Connection;
                requete.CommandText = "initStats";
                requete.CommandType = CommandType.StoredProcedure;
                _Connection.Open();
                

                string message = "Etes-vous sur de vouloir vider la table stats de la base de données ?";
                string caption = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MetroMessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Asterisk);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    requete.ExecuteNonQuery();
                    //this.Close();

                    string mess = "Retournez au menu principal ?";
                    string capt = "Confirmation";
                    MessageBoxButtons butt = MessageBoxButtons.YesNo;
                    DialogResult res;
                    res = MetroMessageBox.Show(this, mess, capt, butt, MessageBoxIcon.Asterisk);

                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {

                    }


                }

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    //this.Close();
                    string mess = "Retournez au menu principal ?";
                    string capt = "Confirmation";
                    MessageBoxButtons butt = MessageBoxButtons.YesNo;
                    DialogResult res;
                    res = MetroMessageBox.Show(this, mess, capt, butt, MessageBoxIcon.Asterisk);

                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            _Connection.Close();

        }
    }
}
