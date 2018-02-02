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
    public partial class formDelEleve : MetroFramework.Forms.MetroForm
    {
        public formDelEleve()
        {
            InitializeComponent();
        }

        private void formDelEleve_Load(object sender, EventArgs e)
        {

        }

        private void btSupprEleve_Click(object sender, EventArgs e)
        {
            string INE = tbINESuppr.Text;
            MySqlConnection _Connection = null;
            string[] tabIne = new string[1500];
            int cpt = 0;
            bool ine = false;
            string mdp = formBeforeAdmin.pass;
            MySqlCommand requete = new MySqlCommand();
            MySqlCommand requete1 = new MySqlCommand();

            try
            {
                _Connection = new MySqlConnection("Database=projet;DataSource=localhost;UserId=admin;Password=" +mdp);
                requete.Connection = _Connection;
                requete1.Connection = _Connection;
                requete.CommandText = "DELETE FROM eleve where numeroINE = @INE;";
                requete1.CommandText = "SELECT numeroINE from eleve;";
                requete.Parameters.AddWithValue("@INE", INE);
                _Connection.Open();
                MySqlDataReader readerRequete1 = requete1.ExecuteReader();

                while (readerRequete1.Read())
                {
                    tabIne[cpt] = readerRequete1["numeroINE"].ToString();
                    cpt++;
                    
                }
                _Connection.Close();
            }
            catch
            {
                
            }
            for (int i = 0; i < cpt; i++)
            {
                if (INE == tabIne[i])
                {
                    
                    ine = true;
                    _Connection.Open();
                    //Msg box
                    string message = "Etes-vous sur de vouloir supprimer l'élève appartenant à l'INE : " + INE + " ?";
                    string caption = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MetroMessageBox.Show(this,message, caption, buttons, MessageBoxIcon.Asterisk);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {

                        MySqlDataReader readerRequete = requete.ExecuteReader();


                    }


                }

            }
            if (ine == false)
            {
                MessageBox.Show("Aucun élève appartenant à cet INE a été trouvé !");
            }


            _Connection.Close();
        }
    }
}
