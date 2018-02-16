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
                string dateToday = Convert.ToString(DateTime.Today);
                labelDate.Text = dateToday;
                int dayP = Convert.ToInt32(dateToday.Substring(0, 2));
                int monthP = Convert.ToInt32(dateToday.Substring(3, 2));
                int yearP = Convert.ToInt32(dateToday.Substring(6, 4));
                label1.Text = Convert.ToString(dayP);
                label2.Text = Convert.ToString(monthP);
                label3.Text = Convert.ToString(yearP);

                _Connection = new MySqlConnection("Integrated Security=SSPI" + "MultipleActiveResultSets=True;Database =projet;DataSource=" + formLinkServer.serv + ";UserId=admin;Password=" + mdp + ";");
                _Connection.Open();

                MySqlCommand insDay = _Connection.CreateCommand();
                insDay.Connection = _Connection;
                insDay.CommandText = "update stats set dayF = @dayP where statsId=1;";
                insDay.Parameters.AddWithValue("?dayP", dayP);

                MySqlCommand insMonth = _Connection.CreateCommand();
                insMonth.Connection = _Connection;
                insMonth.CommandText = "update stats set monthF = @monthP where statsId=1;";
                insMonth.Parameters.AddWithValue("?monthP", monthP);

                MySqlCommand insYear = _Connection.CreateCommand();
                insYear.Connection = _Connection;
                insYear.CommandText = "update stats set yearF = @yearP where statsId=1;";
                insYear.Parameters.AddWithValue("?yearP", yearP);

                MySqlCommand cmdStDay = new MySqlCommand();
                cmdStDay.Connection = _Connection;
                cmdStDay.CommandText = "incStatsDay";
                cmdStDay.CommandType = CommandType.StoredProcedure;

                MySqlCommand cmdStMonth = new MySqlCommand();
                cmdStMonth.Connection = _Connection;
                cmdStMonth.CommandText = "incStatsMonth";
                cmdStMonth.CommandType = CommandType.StoredProcedure;

                MySqlCommand cmdStYear = new MySqlCommand();
                cmdStYear.Connection = _Connection;
                cmdStYear.CommandText = "incStatsYear";
                cmdStYear.CommandType = CommandType.StoredProcedure;

                MySqlCommand resetStDay = new MySqlCommand();
                resetStDay.Connection = _Connection;
                resetStDay.CommandText = "resetStatsDay";
                resetStDay.CommandType = CommandType.StoredProcedure;

                MySqlCommand resetStMonth = new MySqlCommand();
                resetStMonth.Connection = _Connection;
                resetStMonth.CommandText = "resetStatsMonth";
                resetStMonth.CommandType = CommandType.StoredProcedure;

                MySqlCommand resetStYear = new MySqlCommand();
                resetStYear.Connection = _Connection;
                resetStYear.CommandText = "resetStatsYear";
                resetStYear.CommandType = CommandType.StoredProcedure;

                MySqlCommand requete = new MySqlCommand();
                requete.Connection = _Connection;
                requete.CommandText = "SELECT dayF as jourBD, monthF as moisBD, yearF as anneeBD from stats where statsId = '1'";
                //_Connection.Open();
                MySqlDataReader readerRequete = requete.ExecuteReader();

                ArrayList tabJour = new ArrayList();
                ArrayList tabMois = new ArrayList();
                ArrayList tabAnnee = new ArrayList();

                while (readerRequete.Read())
                {
                    tabJour.Add(readerRequete["jourBD"].ToString());
                    tabMois.Add(readerRequete["moisBD"].ToString());
                    tabAnnee.Add(readerRequete["anneeBD"].ToString());

                    int jourBD = Convert.ToInt32(tabJour[0]);
                    int moisBD = Convert.ToInt32(tabMois[0]);
                    int anneeBD = Convert.ToInt32(tabAnnee[0]);

                    if(jourBD == 0 || moisBD == 0 || anneeBD == 0)
                    {
                        insDay.ExecuteNonQuery();
                        insMonth.ExecuteNonQuery();
                        insYear.ExecuteNonQuery();
                    }

                    if(jourBD == dayP)
                    {
                        cmdStDay.ExecuteNonQuery();
                    }
                    if(jourBD != dayP || jourBD != 0)
                    {
                        insDay.ExecuteNonQuery();
                        resetStDay.ExecuteNonQuery();
                    }

                    if (moisBD == monthP)
                    {
                        cmdStMonth.ExecuteNonQuery();
                    }
                    if (moisBD != monthP || moisBD != 0)
                    {
                        insMonth.ExecuteNonQuery();
                        resetStMonth.ExecuteNonQuery();
                    }

                    if (anneeBD == yearP)
                    {
                        cmdStYear.ExecuteNonQuery();
                    }
                    if (anneeBD != yearP || anneeBD != 0)
                    {
                        insYear.ExecuteNonQuery();
                        resetStYear.ExecuteNonQuery();
                    }

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = _Connection;
                    cmd.CommandText = "incremental";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();


                    
                }

                _Connection.Close();

                MySqlCommand final = new MySqlCommand();
                final.Connection = _Connection;
                final.CommandText = "SELECT statsAll, statsDay, statsMonth, statsYear from stats where statsId = '1'";
                _Connection.Open();
                MySqlDataReader readerFinal = final.ExecuteReader();

                ArrayList tabAll = new ArrayList();
                ArrayList tabSjour = new ArrayList();
                ArrayList tabSmois = new ArrayList();
                ArrayList tabSannee = new ArrayList();

                while (readerFinal.Read())
                {
                    tabSjour.Add(readerRequete["statsDay"].ToString());
                    tabSmois.Add(readerRequete["statsMonth"].ToString());
                    tabSannee.Add(readerRequete["statsYear"].ToString());
                    tabAll.Add(readerRequete["statsAll"].ToString());

                    mLabelAll.Text = tabAll[0].ToString();
                    mLabelDay.Text = tabSjour[0].ToString();
                    mLabelMonth.Text = tabSmois[0].ToString();
                    mLabelYear.Text = tabSannee[0].ToString();

                   
                }
                _Connection.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _Connection.Close();
            }
           


        }
    }
}
