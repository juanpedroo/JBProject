using MySql.Data.MySqlClient;
using System;
using System.Collections;
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

        public string dayC;
        public string monthC;
        public string yearC;

        private void formStats_Load(object sender, EventArgs e)
        {

            mLabelScanEleve.Text = Convert.ToString(Eleve.getNbEleveScannes());
        }

        private void BTsimulation_Click(object sender, EventArgs e)
        {
            string mdp = formBeforeAdmin.pass;
            MySqlConnection _Connection = null;
            


            try
            {

                _Connection = new MySqlConnection("Database=projet;DataSource=" + formLinkServer.serv + ";UserId=admin;Password=" + mdp + ";");
                _Connection.Open();

                string dateToday = Convert.ToString(DateTime.Today);
                labelDate.Text = dateToday;
                int dayP = Convert.ToInt32(dateToday.Substring(0, 2));
                int monthP = Convert.ToInt32(dateToday.Substring(3, 2));
                int yearP = Convert.ToInt32(dateToday.Substring(6, 4));

                if (dayP < 10)
                {
                    label1.Text = "0" + Convert.ToString(dayP);
                    dayC = "0" + Convert.ToString(monthP);
                }
                if (dayP >= 10)
                {
                    label1.Text = Convert.ToString(dayP);
                    dayC = Convert.ToString(dayP);
                }
                if (monthP < 10)
                {
                    label2.Text = "0" + Convert.ToString(monthP);
                    monthC = "0" + Convert.ToString(monthP);
                }
                if (monthP >= 10)
                {
                    label2.Text = Convert.ToString(monthP);
                    monthC = Convert.ToString(monthP);
                }

                label3.Text = Convert.ToString(yearP);
                yearC = Convert.ToString(yearP);

                int yearA = Convert.ToInt32(yearC);
                int monthA = Convert.ToInt32(monthC);
                int dayA = Convert.ToInt32(dayC);

                
               
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _Connection;
                cmd.CommandText = "incremental";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                MySqlCommand cmdStDay = new MySqlCommand();
                cmdStDay.Connection = _Connection;
                cmdStDay.CommandText = "incStatsDay";
                cmdStDay.CommandType = CommandType.StoredProcedure;
                cmdStDay.ExecuteNonQuery();

                MySqlCommand cmdStMonth = new MySqlCommand();
                cmdStMonth.Connection = _Connection;
                cmdStMonth.CommandText = "incStatsMonth";
                cmdStMonth.CommandType = CommandType.StoredProcedure;
                cmdStMonth.ExecuteNonQuery();

                MySqlCommand cmdStYear = new MySqlCommand();
                cmdStYear.Connection = _Connection;
                cmdStYear.CommandText = "incStatsYear";
                cmdStYear.CommandType = CommandType.StoredProcedure;
                cmdStYear.ExecuteNonQuery();

                //MySqlCommand requete = new MySqlCommand();
                //requete.Connection = _Connection;
                //requete.CommandText = "SELECT statsAll, statsDay, statsMonth, statsYear, dayF, monthF, yearF from stats;";
                //MySqlDataReader readerRequete = requete.ExecuteReader();
                //MySqlCommand command = connection.CreateCommand();
                //command.CommandText = "INSERT INTO tb_mitarbeiter (Vorname) VALUES (?name)";
                //command.Parameters.AddWithValue("?name", mitarbeiter);
                //connection.Open();
                //command.ExecuteNonQuery();

                MySqlCommand insDay = _Connection.CreateCommand();
                insDay.Connection = _Connection;
                insDay.CommandText = "update stats set dayF = @dayP where statsId=1;";
                insDay.Parameters.AddWithValue("?dayP", dayP);
                //_Connection.Open();
                insDay.ExecuteNonQuery();

                MySqlCommand insMonth = _Connection.CreateCommand();
                insMonth.Connection = _Connection;
                insMonth.CommandText = "update stats set monthF = @monthP where statsId=1;";
                insMonth.Parameters.AddWithValue("?monthP", monthP);
                //_Connection.Open();
                insMonth.ExecuteNonQuery();

                MySqlCommand insYear = _Connection.CreateCommand();
                insYear.Connection = _Connection;
                insYear.CommandText = "update stats set yearF = @yearP where statsId=1;";
                insYear.Parameters.AddWithValue("?yearP", yearP);
                //_Connection.Open();
                insYear.ExecuteNonQuery();

                //MySqlCommand command = _Connection.CreateCommand();

                //command.CommandText = @"INSERT INTO 'stats'('dayF') VALUES ("+dayP+")";
                ////command.Parameters.AddWithValue("@dayP", dayP);
                //_Connection.Open();
                //command.ExecuteQuery();




                //MySqlCommand insMonth = new MySqlCommand();
                //insMonth.Connection = _Connection;
                //insMonth.CommandText = "INSERT INTO stats(monthF) values(@monthC)";
                //insMonth.ExecuteReader();

                //MySqlCommand insYear = new MySqlCommand();
                //insYear.Connection = _Connection;
                //insYear.CommandText = "INSERT INTO stats(yearF) values(@yearC)";
                //insYear.ExecuteReader();





                //requete.CommandText = "SELECT statsAll, statsDay, statsMonth, statsYear, day, month, year from stats;";
                //requete1.CommandText = "INSERT INTO stats (statsAll, statsDay, statsMonth, statsYear, day, month, year) values (total, cptDay, cptMonth, cptYear, dayP, monthP, yearP)";



                //MySqlDataReader readerRequete = requete.ExecuteReader();

                /*ArrayList tabStatsAll = new ArrayList();
                ArrayList tabStatsDay = new ArrayList();
                ArrayList tabStatsMonth = new ArrayList();
                ArrayList tabStatsYear = new ArrayList();
                ArrayList tabDay = new ArrayList();
                ArrayList tabMonth = new ArrayList();
                ArrayList tabYear = new ArrayList();
                */

                /*
                while (readerRequete.Read())
                {
                    tabStatsAll.Add(readerRequete["statsAll"].ToString());
                    tabStatsDay.Add(readerRequete["statsDay"].ToString());
                    tabStatsMonth.Add(readerRequete["statsMonth"].ToString());
                    tabStatsYear.Add(readerRequete["statsYear"].ToString());
                    tabDay.Add(readerRequete["day"].ToString());
                    tabMonth.Add(readerRequete["month"].ToString());
                    tabYear.Add(readerRequete["year"].ToString());

                    

                    

                }
                */






            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _Connection.Close();
            }
           


        }
    }
}
