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
    
    public partial class formPath : MetroFramework.Forms.MetroForm
    {
        public static string cal="";
        
        public static string pdf="";

        public formPath()
        {
            InitializeComponent();
        }
        public void ChooseFolderCal()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                cal = folderBrowserDialog1.SelectedPath;
                metroTextBox1.Text = cal;
            }
        }
        public void ChooseFolderPDF()
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                pdf = folderBrowserDialog2.SelectedPath;
                metroTextBox2.Text = pdf;
            }
        }
        private void formPath_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text = Properties.Settings.Default.pathCal;
            metroTextBox2.Text = Properties.Settings.Default.pathPDF;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ChooseFolderCal();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ChooseFolderPDF();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            cal = metroTextBox1.Text;
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            pdf = metroTextBox2.Text;
        }

        private void formPath_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.pathCal = cal;
            Properties.Settings.Default.pathPDF = pdf;
            Properties.Settings.Default.Save();
        }

        private void formPath_Load_1(object sender, EventArgs e)
        {

        }
    }
}
