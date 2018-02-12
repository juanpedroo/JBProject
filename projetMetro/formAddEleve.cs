using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;


namespace projetMetro
{
    public partial class formAddEleve : MetroFramework.Forms.MetroForm
    {
        public formAddEleve()
        {
            InitializeComponent();
            //var myEncoding = new Encoding(10081);

        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
            
        }

        

        private void mBTaddEleve_Click(object sender, EventArgs e)
        {
            MySqlConnection _Connection = null;

            string mdp = formBeforeAdmin.pass;
            try
            {
                _Connection = new MySqlConnection("Database=projet;DataSource=localhost;UserId=admin;Password="+mdp+";");
                MySqlCommand requete = new MySqlCommand();

                requete.Connection = _Connection;

                _Connection.Open();
                //Eleve
                string ineEleve = mTBineE.Text;
                string nomEleve = mTBnomE.Text;
                string prenomEleve = mTBprenomE.Text;
                string dateEleve = mTBdateNaissE.Text;
                string classeEleve = mTBclasseE.Text;
                string regimeEleve = mTBregimeE.Text;
                //Responsable 1
                string civiliteResp1 = mCBciviliteR1.Text;
                string lienResp1 = mCBlienR1.Text;
                string nomResp1 = mTBnomR1.Text;
                string prenomResp1 = mTBprenomR1.Text;
                string adresseResp1 = mTBadresseR1.Text;
                string cpResp1 =mTBcpR1.Text;
                string villeResp1 = mTBvilleR1.Text;
                string paysResp1 = mTBpaysR1.Text;
                string mailResp1 = mTBmailR1.Text;
                string fixeResp1 = mTBfixeR1.Text;
                string portableResp1 = mTBportableR1.Text;
                //Responsable 2
                string civiliteResp2 = mCBciviliteR2.Text;
                string lienResp2 = mCBlienR2.Text;
                string nomResp2 = mTBnomR2.Text;
                string prenomResp2 = mTBprenomR2.Text;
                string adresseResp2 = mTBadresseR2.Text;
                string cpResp2 = mTBcpR2.Text;
                string villeResp2 = mTBvilleR2.Text;
                string paysResp2 = mTBpaysR2.Text;
                string mailResp2 = mTBmailR2.Text;
                string fixeResp2 = mTBfixeR2.Text;
                string portableResp2 = mTBportableR2.Text;

                requete.CommandText = "INSERT INTO eleve(numeroINE, nom, prenom, dateNaiss, classe, regime, r1Civilite, r1Nom, r1Prenom, r1Adresse1, r1CodePostal, r1Ville, r1Email, r1FixeCom, r1Portable, r1Lien, r2Civilite, r2Nom, r2Prenom, r2Adresse1, r2CodePostal, r2Ville, r2Email, r2FixeCom, r2Portable, r2Lien) VALUES ("+ineEleve+ "," +nomEleve+"," +prenomEleve+ "," +dateEleve+ "," +classeEleve+ "," +regimeEleve+ "," +civiliteResp1+ "," +nomResp1+ "," +prenomResp1+ "," +adresseResp1+ "," +cpResp1+ "," +villeResp1+ "," +mailResp1+ "," +fixeResp1+ "," +portableResp1+ "," +lienResp1+ "," + civiliteResp2 + "," + nomResp2 + "," + prenomResp2 + "," + adresseResp2 + "," + cpResp2 + "," + villeResp2 + "," + mailResp2 + "," + fixeResp2 + "," + portableResp2 + "," + lienResp2 + ");";

                MySqlDataReader readerRequete = requete.ExecuteReader();

            }
            finally
            {
                _Connection.Close();
            }
        }

        private void formAddEleve_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
