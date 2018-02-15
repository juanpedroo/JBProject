using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetMetro
{
    public partial class formImport : MetroFramework.Forms.MetroForm
    {
        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }
        public formImport()
        {
            InitializeComponent();
        }

        private void formImport_Load(object sender, EventArgs e)
        {
            mPB.Maximum = 4;
            mPB.Minimum = 0;
            mPB.Step = 1;
            mLViewStatus.Scrollable = false;
            
        }

        private void mBtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.DefaultExt = "*.txt";
            fd.Filter = "Fichiers Texte (*.txt)|*.txt";
            fd.ShowDialog();
            mTbPath.Text = fd.FileName;
            mPB.Value = 0;
            mLViewStatus.Items.Clear();
            mLViewStatus.Scrollable = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string connStr = "server=" + formLinkServer.serv + ";user id=admin;password=" + formBeforeAdmin.pass + ";database=projet";
            // MySql Connection Object
            MySqlConnection conn = new MySqlConnection(connStr);

            // Test if the file is utf-16 encoded or not
            if(GetEncoding(mTbPath.Text) == Encoding.Unicode)
            {
                // Convert UTF-16 to UTF-8
                string s = File.ReadAllText(mTbPath.Text, Encoding.Unicode);
                File.WriteAllText(mTbPath.Text, s, Encoding.UTF8);

                // Delete 1st line of the file
                var lines = File.ReadAllLines(mTbPath.Text);
                File.WriteAllLines(mTbPath.Text, lines.Skip(1).ToArray());
            }
            else
            {
                string s = File.ReadAllText(mTbPath.Text);
            }

            // MySQL BulkLoader
            MySqlBulkLoader bl = new MySqlBulkLoader(conn);
            bl.TableName = "eleve";
            bl.FieldTerminator = ";";  //This can be { comma,tab,semi colon, or other character}
            bl.LineTerminator = "\n";
            bl.FileName = mTbPath.Text;
            bl.ConflictOption = MySql.Data.MySqlClient.MySqlBulkLoaderConflictOption.Replace;

            mPB.PerformStep();
            try
            {
                conn.Open();
                mPB.PerformStep();
                mLViewStatus.Items.Add("Connection à la base de données...");
                mLViewStatus.Scrollable = false;

                // Upload data from file
                int count = bl.Load();
                mPB.PerformStep();
                if (count > 1200)
                {
                    mLViewStatus.Items.Add(count / 2 + " lignes ajoutée(s).");
                }
                else
                {
                    mLViewStatus.Items.Add(count + " lignes ajoutée(s).");
                }
                

                conn.Close();
            }
            catch (Exception ex)
            {
                mLViewStatus.Items.Add(ex.ToString());
                mPB.BackColor = Color.Red;
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Erreur !");
            }

            mPB.PerformStep();
            mLViewStatus.Items.Add("Terminé !");
            mLViewStatus.Scrollable = false;
        }

        
    }
}
