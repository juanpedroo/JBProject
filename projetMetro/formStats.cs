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
            string mdp = formBeforeAdmin.pass;
            MySqlConnection _Connection = null;

            try
            {

            _Connection = new MySqlConnection("Database=projet;DataSource=" + formLinkServer.serv + ";UserId=admin;Password=" + mdp + ";");
            MySqlCommand final = new MySqlCommand();
            final.Connection = _Connection;
            final.CommandText = "SELECT statsAll, statsDay, statsMonth, statsYear from stats where statsId = '1'";
            _Connection.Open();
            MySqlDataReader readerFinal = final.ExecuteReader();

            ArrayList tabAll = new ArrayList();
            ArrayList tabSjour = new ArrayList();
            ArrayList tabSmois = new ArrayList();
            ArrayList tabSannee = new ArrayList();

            readerFinal.Read();

            tabSjour.Add(readerFinal["statsDay"].ToString());
            tabSmois.Add(readerFinal["statsMonth"].ToString());
            tabSannee.Add(readerFinal["statsYear"].ToString());
            tabAll.Add(readerFinal["statsAll"].ToString());

            mLabelAll.Text = tabAll[0].ToString();
            mLabelDay.Text = tabSjour[0].ToString();
            mLabelMonth.Text = tabSmois[0].ToString();
            mLabelYear.Text = tabSannee[0].ToString();

            _Connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _Connection.Close();
            }
        }


        private void mBTreinitialiser_Click(object sender, EventArgs e)
        {
            string mdp = formBeforeAdmin.pass;
            MySqlConnection _Connection = null;

            try
            {

                _Connection = new MySqlConnection("Database=projet;DataSource=" + formLinkServer.serv + ";UserId=admin;Password=" + mdp + ";");

                _Connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _Connection;
                cmd.CommandText = "initStats";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                _Connection.Close();

                mLabelAll.Text = "0";
                mLabelDay.Text = "0";
                mLabelMonth.Text = "0";
                mLabelYear.Text = "0";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _Connection.Close();
            }
        }
    }
}
