using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetMetro
{
    public partial class formUser : MetroFramework.Forms.MetroForm
    {
        public formUser()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            mTBine.Select();
        }

        private void formUser_Load(object sender, EventArgs e)
        {
            mTBine.Select();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            mTBine.Select();
            mTBine.ReadOnly = false;
        }

        public void clearAxPDF()
        {
            if (axAcroPDF1 != null)
            {
                foreach (Process proc in Process.GetProcessesByName("AcroRd32"))
                {
                    proc.Kill();
                }
            }
        }

        private void mLabelAdresseR1_MouseHover_1(object sender, EventArgs e)
        {
            metroToolTip1.Show(" " + mLabelAdresseR1.Text, mLabelAdresseR1);
        }

        private void mLabelAdresseR2_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show(" " + mLabelAdresseR2.Text, mLabelAdresseR2);
        }

        public string reductionRegime(ArrayList tabReg)
        {
            string motRegime = Convert.ToString(tabReg[0]);
            string typeRegime = "";

            if (motRegime.Contains("INTERNE") == true)
            {
                typeRegime = "INTERNE";
            }
            if (motRegime.Contains("EXTERNE") == true)
            {
                typeRegime = "EXTERNE";
            }
            if (motRegime.Contains("DEMI-PENSIONNAIRE") == true)
            {
                typeRegime = "DEMI-PENSIONNAIRE";
            }
            return typeRegime;
        }

        public string reductionResponsable(ArrayList tabLien)
        {
            string motResponsable = Convert.ToString(tabLien[0]);
            string typeResponsable = "";

            if ((motResponsable.Contains("MERE") == false) && (motResponsable.Contains("PERE") == false) && (motResponsable.Contains("TUTEUR") == false))
            {
                typeResponsable = "AUTRE";
            }
            else
            {
                typeResponsable = motResponsable;
            }

            return typeResponsable;
        }

        public int TestAdresseVide(ArrayList tabAdr1test, ArrayList tabAdr2test, ArrayList tabAdr3test, ArrayList tabAdr4test)
        {
            int adr = 0;

            if (tabAdr1test[0].Equals("") == true)
            {
                if (tabAdr2test[0].Equals("") == true)
                {
                    if (tabAdr3test[0].Equals("") == true)
                    {
                        if (tabAdr4test[0].Equals("") == true)
                        {
                            adr = 0; //rien
                        }
                        else
                        {
                            adr = 1; //Adresse4;
                        }
                    }
                    else
                    {
                        if (tabAdr4test[0].Equals("") == false)
                        {
                            adr = 2; // Adresse3 + " " + Adresse4;
                        }
                        else
                        {
                            adr = 3; // Adresse3
                        }
                    }
                }
                else
                {
                    if (tabAdr3test[0].Equals("") == false)
                    {
                        if (tabAdr4test[0].Equals("") == false)
                        {
                            adr = 4; // Adresse2 + " " + Adresse3 + " " + Adresse4;
                        }
                        else
                        {
                            adr = 5; // Adresse2 + " " + Adresse3;
                        }
                    }
                    else
                    {
                        if (tabAdr4test[0].Equals("") == false)
                        {
                            adr = 6; // Adresse2 + " " + Adresse4;
                        }
                        else
                        {
                            adr = 7; // Adresse2
                        }
                    }
                }
            }
            else
            {
                if (tabAdr2test[0].Equals("") == false)
                {
                    if (tabAdr3test[0].Equals("") == false)
                    {
                        if (tabAdr4test[0].Equals("") == false)
                        {
                            adr = 8; // Adresse1 + " " + Adresse2 + " " + Adresse3 + " " + Adresse4;
                        }
                        else
                        {
                            adr = 9;// Adresse1 + " " + Adresse2 + " " + Adresse3;
                        }
                    }
                    else
                    {
                        if (tabAdr4test[0].Equals("") == false)
                        {
                            adr = 10;// Adresse1 + " " + Adresse2 + " " + Adresse4;
                        }
                        else
                        {
                            adr = 11;// Adresse1 + " " + Adresse2;
                        }
                    }
                }
                else
                {
                    if (tabAdr3test[0].Equals("") == false)
                    {
                        if (tabAdr4test[0].Equals("") == false)
                        {
                            adr = 12; // Adresse1 + " " + Adresse3 + " " + Adresse4;
                        }
                        else
                        {
                            adr = 13;// Adresse1 + " " + Adresse3;
                        }
                    }
                    else
                    {
                        if (tabAdr4test[0].Equals("") == false)
                        {
                            adr = 14; // Adresse1 + " " + Adresse4;
                        }
                        else
                        {
                            adr = 15; // Adresse1
                        }
                    }
                }
            }
            return adr;
        }

        public string testNumero(ArrayList tabNum)
        {
            string tabN = Convert.ToString(tabNum[0]);
            if (tabN.Equals("0") == true)
            {
                tabN = "";
            }
            return tabN;
        }

        public string AntiEspace(ArrayList tabAdr1, ArrayList tabAdr2, ArrayList tabAdr3, ArrayList tabAdr4, int adr)
        {
            string Adresse1 = Convert.ToString(tabAdr1[0]);
            string Adresse2 = Convert.ToString(tabAdr2[0]);
            string Adresse3 = Convert.ToString(tabAdr3[0]);
            string Adresse4 = Convert.ToString(tabAdr4[0]);

            string adresse = "";

            if (adr == 0)
            {
                adresse = "";
            }
            if (adr == 1)
            {
                adresse = Adresse4;
            }
            if (adr == 2)
            {
                adresse = Adresse3 + " " + Adresse4;
            }
            if (adr == 3)
            {
                adresse = Adresse3;
            }
            if (adr == 4)
            {
                adresse = Adresse2 + " " + Adresse3 + " " + Adresse4;
            }
            if (adr == 5)
            {
                adresse = Adresse2 + " " + Adresse3;
            }
            if (adr == 6)
            {
                adresse = Adresse2 + " " + Adresse4;
            }
            if (adr == 7)
            {
                adresse = Adresse2;
            }
            if (adr == 8)
            {
                adresse = Adresse1 + " " + Adresse2 + " " + Adresse3 + " " + Adresse4;
            }
            if (adr == 9)
            {
                adresse = Adresse1 + " " + Adresse2 + " " + Adresse3;
            }
            if (adr == 10)
            {
                adresse = Adresse1 + " " + Adresse2 + " " + Adresse4;
            }
            if (adr == 11)
            {
                adresse = Adresse1 + " " + Adresse2;
            }
            if (adr == 12)
            {
                adresse = Adresse1 + " " + Adresse3 + " " + Adresse4;
            }
            if (adr == 13)
            {
                adresse = Adresse1 + " " + Adresse3;
            }
            if (adr == 14)
            {
                adresse = Adresse1 + " " + Adresse4;
            }
            if (adr == 15)
            {
                adresse = Adresse1;
            }
            return adresse;
        }

        private void axAcroPDF1_Enter_1(object sender, EventArgs e)
        {
            mTBine.Clear();
            mTBine.ReadOnly = true;
            timer.Interval = 1200;
            timer.Tick += Timer_Tick;
            mTBine.Select();
            timer.Enabled = true;
            timer.Start();
        }

        private void mLinkReturn_Click_1(object sender, EventArgs e)
        {
            formMain fMain = new formMain();
            fMain.Show();
            this.Visible = false;
        }

        private void mTileSortie_Click(object sender, EventArgs e)
        {
            mTileSortie.BackColor = Color.Green;
        }

        private void mBTafficher_Click(object sender, EventArgs e)
        {
            string INE = mTBine.Text;
            MySqlConnection _Connection = null;
            axAcroPDF1.LoadFile("none.pdf");
            clearAxPDF();

            try
            {

                //unEleve = new eleve(labelINE.Text, labelNomE.Text, labelPrenomE.Text, labelClasse.Text, labelRegime.Text, labelDate.Text);
                //lesEleves.Add(unEleve);

                _Connection = new MySqlConnection("Database=projet;DataSource=localhost;UserId=user;Password=;");
                MySqlCommand requete = new MySqlCommand();
                requete.Connection = _Connection;
                requete.CommandText = "SELECT numeroINE as INE, nom as Nom, NomSansEspace(nom) as NomSansEspace, PrenomSansAccent(prenom) as PrenomSansAccent, prenom as Prenom, DateSansSlash(dateNaiss) as DateNaiss, classe as Classe, regime as Regime, r1Civilite as civiliteR1, r1Nom as nomR1, r1Prenom as prenomR1, AdresseMinuscule(r1Adresse1) as adresse1R1, AdresseMinuscule(r1Adresse2) as adresse2R1, AdresseMinuscule(r1Adresse3) as adresse3R1, AdresseMinuscule(r1Adresse4) as adresse4R1, r1CodePostal as CPR1, r1Ville as villeR1, r1Pays as paysR1, r1Email as mailR1, NumeroAvec0(r1FixeCom) as fixeComR1, NumeroAvec0(r1Portable) as portableR1, r1Lien as lienR1, r2Civilite as civiliteR2, r2Nom as nomR2, r2Prenom as prenomR2, AdresseMinuscule(r2Adresse1) as adresse1R2, AdresseMinuscule(r2Adresse2) as adresse2R2, AdresseMinuscule(r2Adresse3) as adresse3R2, AdresseMinuscule(r2Adresse4) as adresse4R2, r2CodePostal as CPR2, r2Ville as villeR2, r2Pays as paysR2, r2Email as mailR2, NumeroAvec0(r2FixeCom) as fixeComR2, NumeroAvec0(r2Portable) as portableR2, r2Lien as lienR2 FROM eleve Where numeroINE = @INE";
                requete.Parameters.AddWithValue("@INE", INE);
                _Connection.Open();
                MySqlDataReader readerRequete = requete.ExecuteReader();

                ArrayList tabINE = new ArrayList();
                ArrayList tabNom = new ArrayList();
                ArrayList tabPrenom = new ArrayList();
                ArrayList tabDate = new ArrayList();
                ArrayList tabNomSansEspace = new ArrayList();
                ArrayList tabPrenomSansAccent = new ArrayList();
                ArrayList tabClasse = new ArrayList();
                ArrayList tabRegime = new ArrayList();

                ArrayList tabNomR1 = new ArrayList();
                ArrayList tabPrenomR1 = new ArrayList();
                ArrayList tabAdresseR1 = new ArrayList();
                ArrayList tabCPR1 = new ArrayList();
                ArrayList tabVilleR1 = new ArrayList();
                ArrayList tabPaysR1 = new ArrayList();
                ArrayList tabMailR1 = new ArrayList();
                ArrayList tabFixeR1 = new ArrayList();
                ArrayList tabPortableR1 = new ArrayList();
                ArrayList tabLienR1 = new ArrayList();
                ArrayList tabAdresse1R1 = new ArrayList();
                ArrayList tabAdresse2R1 = new ArrayList();
                ArrayList tabAdresse3R1 = new ArrayList();
                ArrayList tabAdresse4R1 = new ArrayList();

                ArrayList tabNomR2 = new ArrayList();
                ArrayList tabPrenomR2 = new ArrayList();
                ArrayList tabAdresseR2 = new ArrayList();
                ArrayList tabCPR2 = new ArrayList();
                ArrayList tabVilleR2 = new ArrayList();
                ArrayList tabPaysR2 = new ArrayList();
                ArrayList tabMailR2 = new ArrayList();
                ArrayList tabFixeR2 = new ArrayList();
                ArrayList tabPortableR2 = new ArrayList();
                ArrayList tabLienR2 = new ArrayList();
                ArrayList tabAdresse1R2 = new ArrayList();
                ArrayList tabAdresse2R2 = new ArrayList();
                ArrayList tabAdresse3R2 = new ArrayList();
                ArrayList tabAdresse4R2 = new ArrayList();

                while (readerRequete.Read())
                {
                    tabINE.Add(readerRequete["INE"].ToString());
                    tabNom.Add(readerRequete["Nom"].ToString());
                    tabPrenom.Add(readerRequete["Prenom"].ToString());
                    tabDate.Add(readerRequete["DateNaiss"].ToString());
                    tabPrenomSansAccent.Add(readerRequete["PrenomSansAccent"].ToString());
                    tabNomSansEspace.Add(readerRequete["NomSansEspace"].ToString());
                    tabClasse.Add(readerRequete["Classe"].ToString());
                    tabRegime.Add(readerRequete["Regime"].ToString());

                    tabNomR1.Add(readerRequete["nomR1"].ToString());
                    tabPrenomR1.Add(readerRequete["prenomR1"].ToString());
                    tabAdresseR1.Add(readerRequete["adresse1R1"].ToString());
                    tabCPR1.Add(readerRequete["CPR1"].ToString());
                    tabVilleR1.Add(readerRequete["villeR1"].ToString());
                    tabPaysR1.Add(readerRequete["paysR1"].ToString());
                    tabMailR1.Add(readerRequete["mailR1"].ToString());
                    tabFixeR1.Add(readerRequete["fixeComR1"].ToString());
                    tabPortableR1.Add(readerRequete["portableR1"].ToString());
                    tabLienR1.Add(readerRequete["lienR1"].ToString());
                    tabAdresse1R1.Add(readerRequete["adresse1R1"].ToString());
                    tabAdresse2R1.Add(readerRequete["adresse2R1"].ToString());
                    tabAdresse3R1.Add(readerRequete["adresse3R1"].ToString());
                    tabAdresse4R1.Add(readerRequete["adresse4R1"].ToString());

                    tabNomR2.Add(readerRequete["nomR2"].ToString());
                    tabPrenomR2.Add(readerRequete["prenomR2"].ToString());
                    tabAdresseR2.Add(readerRequete["adresse1R2"].ToString());
                    tabCPR2.Add(readerRequete["CPR2"].ToString());
                    tabVilleR2.Add(readerRequete["villeR2"].ToString());
                    tabPaysR2.Add(readerRequete["paysR2"].ToString());
                    tabMailR2.Add(readerRequete["mailR2"].ToString());
                    tabFixeR2.Add(readerRequete["fixeComR2"].ToString());
                    tabPortableR2.Add(readerRequete["portableR2"].ToString());
                    tabLienR2.Add(readerRequete["lienR2"].ToString());
                    tabAdresse1R2.Add(readerRequete["adresse1R2"].ToString());
                    tabAdresse2R2.Add(readerRequete["adresse2R2"].ToString());
                    tabAdresse3R2.Add(readerRequete["adresse3R2"].ToString());
                    tabAdresse4R2.Add(readerRequete["adresse4R2"].ToString());

                    string regimeReduit = reductionRegime(tabRegime);
                    string responsableReduit1 = reductionResponsable(tabLienR1);
                    string responsableReduit2 = reductionResponsable(tabLienR2);
                    string numFixeR1 = testNumero(tabFixeR1);
                    string numFixeR2 = testNumero(tabFixeR2);
                    string portableR1 = testNumero(tabPortableR1);
                    string portableR2 = testNumero(tabPortableR2);
                    int adrVide = TestAdresseVide(tabAdresse1R1, tabAdresse2R1, tabAdresse3R1, tabAdresse4R1);
                    int adrVide2 = TestAdresseVide(tabAdresse1R2, tabAdresse2R2, tabAdresse3R2, tabAdresse4R2);
                    string AdresseR1 = AntiEspace(tabAdresse1R1, tabAdresse2R1, tabAdresse3R1, tabAdresse4R1, adrVide);
                    string AdresseR2 = AntiEspace(tabAdresse1R2, tabAdresse2R2, tabAdresse3R2, tabAdresse4R2, adrVide2);

                    mLabelNomE.Text = tabNom[0].ToString();
                    mLabelPrenomE.Text = tabPrenom[0].ToString();
                    mLabelClasseE.Text = tabClasse[0].ToString();
                    mLabelRegimeE.Text = regimeReduit;
                    //mLabelINE.Text = tabINE[0].ToString();
                    //mLabelDate.Text = tabDate[0].ToString();

                    mLabelNomR1.Text = tabNomR1[0].ToString();
                    mLabelPrenomR1.Text = tabPrenomR1[0].ToString();
                    mLabelAdresseR1.Text = AdresseR1;
                    mLabelCPR1.Text = tabCPR1[0].ToString();
                    mLabelVilleR1.Text = tabVilleR1[0].ToString();
                    mLabelPaysR1.Text = tabPaysR1[0].ToString();
                    mLabelMailR1.Text = tabMailR1[0].ToString();
                    mLabelFixeR1.Text = numFixeR1;
                    mLabelPortableR1.Text = portableR1;
                    mLabelResp1.Text = "Responsable 1 : " + responsableReduit1;

                    mLabelNomR2.Text = tabNomR2[0].ToString();
                    mLabelPrenomR2.Text = tabPrenomR2[0].ToString();
                    mLabelAdresseR2.Text = AdresseR2;
                    mLabelCPR2.Text = tabCPR2[0].ToString();
                    mLabelVilleR2.Text = tabVilleR2[0].ToString();
                    mLabelPaysR2.Text = tabPaysR2[0].ToString();
                    mLabelMailR2.Text = tabMailR2[0].ToString();
                    mLabelFixeR2.Text = numFixeR2;
                    mLabelPortableR2.Text = portableR2;
                    mLabelResp2.Text = "Responsable 2 : " + responsableReduit2;

                    string chemin = formPath.pdf + "EDT/Emploi_Du_Temps_" + tabNomSansEspace[0] + "_" + tabPrenomSansAccent[0] + "_" + tabDate[0] + ".pdf";
                    axAcroPDF1.LoadFile(chemin);
                    axAcroPDF1.setShowToolbar(false);
                    axAcroPDF1.setShowScrollbars(false);
                    axAcroPDF1.Select();

                    DateTime help = DateTime.Now;
                    //DateTime help = new DateTime(2018, 01, 28, 13, 50, 00);

                    int i;
                    FileStream fs = new FileStream(@""+ formPath.cal +"ical/Emploi_Du_Temps_" + tabNomSansEspace[0] + "_" + tabPrenomSansAccent[0] + "_" + tabDate[0] + ".ics", FileMode.Open, FileAccess.Read);
                    fs.Seek(9, SeekOrigin.Begin);
                    StreamReader sr = new StreamReader(fs);
                    string ical = sr.ReadToEnd();
                    char[] delim = { '\n' };
                    string[] lines = ical.Split(delim);
                    delim[0] = ':';

                    for (i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains("BEGIN:VEVENT"))
                        {

                            string[] eventData = new string[8];

                            for (int j = 0; j < 8; j++)
                            {
                                eventData[j] = lines[i + j + 1].Split(delim)[1];
                                //lboxIcal.Items.Add(eventData[j]);
                            }
                            i += 10;
                        }


                    }
                    sr.Close();
                    mLabelDate.Text = help.ToString();
                    string[] split = mLabelDate.Text.Split(new Char[] { '/', '/', ' ', ':' });
                    int[] ouioui = new int[5];
                    for (int l = 0; l < 5; l++)
                    {
                        ouioui[l] = Convert.ToInt32(split[l]);

                    }

                    ouioui[4] = ouioui[4] + 20;
                    mTileSortie.Text = Convert.ToString(ouioui[4]);

                    /*
                    if (TimeZoneInfo.Local.IsDaylightSavingTime(help))
                    {
                        ouioui[3] = ouioui[3] - 1;
                        //lbTest.Text = "été";
                    }
                    else
                    {
                        ouioui[3] = ouioui[3] - 0;
                        //lbTest.Text = "hiver";
                    }
                    */

                    //lbCpt.Text = Convert.ToString(ouioui[4]);
                    if (ouioui[4] >= 60)
                    {
                        ouioui[3]++;
                        ouioui[4] = 0;
                    }
                    //lbTailleTab.Text = Convert.ToString(ouioui[4]);
                    for (int k = 0; k < 5; k++)
                    {
                        //lboxTest.Items.Add(ouioui[k]);
                    }

                    string dtStart = "DTSTART:" + ouioui[2].ToString("D4") + ouioui[1].ToString("D2") + ouioui[0].ToString("D2") + "T" + ouioui[3].ToString("D2") + 0.ToString("D2") + "00Z";

                    //lbTest.Text = dtStart;
                    //String dtTest = "DTSTART:20180522T060000Z";
                    //String dtTest1 = "DTSTART:20170918T090000Z";
                    mTileSortie.Text = dtStart;

                    int tmp = i;
                    mTileSortie.Text = "";
                    int cpt = 0;
                    string[,] tabDt = new string[1500, 2];
                    // Création tableau de DTSTART en colonne 0 et DTEND en colonne 1
                    for (i = 0; i < tmp; i++)
                    {

                        if (lines[i].Contains("DTSTART:"))
                        {
                            int valSecond = Convert.ToInt32(lines[i].Substring(17, 2));
                            string first = lines[i].Substring(0, 17);
                            mLabelDate.Text = first;

                            string second = "";
                            string third = lines[i].Substring(19, 5);
                            //labelau.Text = Convert.ToString(valSecond);
                            valSecond = valSecond + 1;


                            int valEnd = Convert.ToInt32(lines[i + 1].Substring(15, 2));
                            string firstEnd = lines[i + 1].Substring(0, 15);
                            string secondEnd = "";
                            string thirdEnd = lines[i + 1].Substring(17, 5);
                            valEnd = valEnd + 1;

                            if (valSecond < 10)
                            {
                                second = Convert.ToString(valSecond);
                                second = "0" + second;
                            }
                            else
                            {
                                second = Convert.ToString(valSecond);
                            }
                            if (valEnd < 10)
                            {
                                secondEnd = Convert.ToString(valEnd);
                                secondEnd = "0" + secondEnd;
                            }
                            else
                            {
                                secondEnd = Convert.ToString(valEnd);
                            }
                            //labelTest.Text = first + second + third;
                            //labelau.Text = firstEnd + secondEnd + thirdEnd;

                            lines[i] = first + second + third;
                            lines[i + 1] = firstEnd + secondEnd + thirdEnd;
                            tabDt[cpt, 0] = lines[i];
                            tabDt[cpt, 1] = lines[i + 1];

                            cpt++;

                        }
                        // lb1.Items.Add(tabDt[1, 0]);
                        //  lb1.Items.Add(tabDt[1, 1]);
                        // labelDate.Text = tabDt[1, 0];
                    }




                    int subTab0 = Convert.ToInt32(dtStart.Substring(17, 2));
                    //lbTest.Text = Convert.ToString(subTab0);
                    string subDtStartdate = dtStart.Substring(8, 8);
                    //MessageBox.Show(tabDt[37, 0].Substring(8,8));
                    //MessageBox.Show(subDtStartdate + "a"+ "\n" + (tabDt[37, 0].Substring(8, 8))+ "a");

                    mTileSortie.Text = "";
                    //lbCpt.Text = Convert.ToString(cpt);
                    for (int z = 0; z < cpt; z++)
                    {

                        string fax = subDtStartdate;
                        //= tabDt[i, 0].Substring(8, 8);

                        //MessageBox.Show(Convert.ToString(i));
                        /*lbDateSubs.Text = subDtStartdate;
                        LBfax.Items.Add(tabDt[z, 0]);
                        lbSubtab0.Text = tabDt[0, 0].Substring(17, 2);
                        lbSubtab1.Text = tabDt[0, 1].Substring(15, 2);
                        lbSubDtStart.Text = dtStart.Substring(17, 2);
                        */

                        if (subDtStartdate == tabDt[z, 0].Substring(8, 8))
                        {
                            if ((Convert.ToInt32(tabDt[z, 0].Substring(17, 2)) <= Convert.ToInt32(dtStart.Substring(17, 2))) && (Convert.ToInt32(dtStart.Substring(17, 2)) < Convert.ToInt32(tabDt[z, 1].Substring(15, 2))))
                            {
                                mTileSortie.Text = "Cours";
                                //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Baptiste\Desktop\Ical.net test\743.wav");
                                //simpleSound.Play();
                            }

                        }

                    }
                    if (mTileSortie.Text == "")
                    {
                        mTileSortie.Text = "Pas Cours";
                        //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Baptiste\Desktop\Ical.net test\1025.wav");
                        //simpleSound.Play();
                    }

                    if (mTileSortie.Text == "Cours")
                    {
                        //mTileSortie.Font = new Font("Verdana", 24);
                        mTileSortie.BackColor = Color.Red;

                    }
                    else
                    {
                        //mTileSortie.Font = new Font("Verdana", 24);
                        mTileSortie.BackColor = Color.Green;
                    }



                }
            }
            finally
            {
                _Connection.Close();
            }
        }

        private void mLabelPrenomE_Click(object sender, EventArgs e)
        {

        }

        private void mLabelClasseE_Click(object sender, EventArgs e)
        {

        }

        private void mLabelRegimeE_Click(object sender, EventArgs e)
        {

        }

        private void mLabelNomE_Click(object sender, EventArgs e)
        {

        }

        private void mLabelPortableR2_Click(object sender, EventArgs e)
        {

        }

        private void mLabelFixeR2_Click(object sender, EventArgs e)
        {

        }

        private void mLabelMailR2_Click(object sender, EventArgs e)
        {

        }

        private void mLabelPaysR2_Click(object sender, EventArgs e)
        {

        }

        private void mLabelVilleR2_Click(object sender, EventArgs e)
        {

        }

        private void mLabelCPR2_Click(object sender, EventArgs e)
        {

        }

        private void mLabelAdresseR2_Click(object sender, EventArgs e)
        {

        }

        private void mLabelPrenomR2_Click(object sender, EventArgs e)
        {

        }

        private void mLabelNomR2_Click(object sender, EventArgs e)
        {

        }

        private void mLabelPortableR1_Click(object sender, EventArgs e)
        {

        }

        private void mLabelFixeR1_Click(object sender, EventArgs e)
        {

        }

        private void mLabelMailR1_Click(object sender, EventArgs e)
        {

        }

        private void mLabelPaysR1_Click(object sender, EventArgs e)
        {

        }

        private void mLabelVilleR1_Click(object sender, EventArgs e)
        {

        }

        private void mLabelCPR1_Click(object sender, EventArgs e)
        {

        }

        private void mLabelAdresseR1_Click(object sender, EventArgs e)
        {

        }

        private void mLabelPrenomR1_Click(object sender, EventArgs e)
        {

        }

        private void mLabelNomR1_Click(object sender, EventArgs e)
        {

        }

        private void mLabelNomE_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show(" " + mLabelNomE.Text, mLabelNomE);
        }

        private void mLabelPrenomE_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show(" " + mLabelPrenomE.Text, mLabelPrenomE);
        }

        private void mLabelMailR1_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show(" " + mLabelMailR1.Text, mLabelMailR1);
        }

        private void mLabelMailR2_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.Show(" " + mLabelMailR2.Text, mLabelMailR2);
        }

        private void formUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain fMain = new formMain();
            fMain.Show(); 
        }
    }
}
