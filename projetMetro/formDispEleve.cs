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
    public partial class formDispEleve : MetroFramework.Forms.MetroForm
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        public formDispEleve()
        {
            InitializeComponent();
        }

        private void formDispEleve_Load(object sender, EventArgs e)
        {
            server = formLinkServer.serv;
            database = "projet";
            uid = "admin";
            password = formBeforeAdmin.pass;
            string connectionString;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from eleve", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                //close connection
                this.CloseConnection();
            }

        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MetroMessageBox.Show(this,"Impossible de se connecter au serveur. Veuillez contacter l'administrateur");
                        break;
                    case 1045:
                        MetroMessageBox.Show(this,"Mot de passe/utilisateur invalide ! \n Veuillez réessayer");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void mLinkReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
