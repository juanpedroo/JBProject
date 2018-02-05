namespace projetMetro
{
    partial class formDelEleve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDelEleve));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbINESuppr = new MetroFramework.Controls.MetroTextBox();
            this.btSupprEleve = new MetroFramework.Controls.MetroButton();
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(567, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Veuillez entrez l\'INE de l\'élève à supprimer de la base de données";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 149);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "INE : ";
            // 
            // tbINESuppr
            // 
            // 
            // 
            // 
            this.tbINESuppr.CustomButton.Image = null;
            this.tbINESuppr.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.tbINESuppr.CustomButton.Name = "";
            this.tbINESuppr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbINESuppr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbINESuppr.CustomButton.TabIndex = 1;
            this.tbINESuppr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbINESuppr.CustomButton.UseSelectable = true;
            this.tbINESuppr.CustomButton.Visible = false;
            this.tbINESuppr.Lines = new string[0];
            this.tbINESuppr.Location = new System.Drawing.Point(71, 144);
            this.tbINESuppr.MaxLength = 32767;
            this.tbINESuppr.Name = "tbINESuppr";
            this.tbINESuppr.PasswordChar = '\0';
            this.tbINESuppr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbINESuppr.SelectedText = "";
            this.tbINESuppr.SelectionLength = 0;
            this.tbINESuppr.SelectionStart = 0;
            this.tbINESuppr.ShortcutsEnabled = true;
            this.tbINESuppr.Size = new System.Drawing.Size(148, 23);
            this.tbINESuppr.TabIndex = 2;
            this.tbINESuppr.UseSelectable = true;
            this.tbINESuppr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbINESuppr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btSupprEleve
            // 
            this.btSupprEleve.Location = new System.Drawing.Point(252, 300);
            this.btSupprEleve.Name = "btSupprEleve";
            this.btSupprEleve.Size = new System.Drawing.Size(124, 60);
            this.btSupprEleve.TabIndex = 3;
            this.btSupprEleve.Text = "Supprimer";
            this.btSupprEleve.UseSelectable = true;
            this.btSupprEleve.Click += new System.EventHandler(this.btSupprEleve_Click);
            // 
            // mLinkReturn
            // 
            this.mLinkReturn.Image = ((System.Drawing.Image)(resources.GetObject("mLinkReturn.Image")));
            this.mLinkReturn.ImageSize = 32;
            this.mLinkReturn.Location = new System.Drawing.Point(1, 7);
            this.mLinkReturn.Name = "mLinkReturn";
            this.mLinkReturn.Size = new System.Drawing.Size(38, 35);
            this.mLinkReturn.TabIndex = 4;
            this.mLinkReturn.UseSelectable = true;
            this.mLinkReturn.Click += new System.EventHandler(this.mLinkReturn_Click);
            // 
            // formDelEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 430);
            this.Controls.Add(this.mLinkReturn);
            this.Controls.Add(this.btSupprEleve);
            this.Controls.Add(this.tbINESuppr);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Location = new System.Drawing.Point(1, 7);
            this.Name = "formDelEleve";
            this.Load += new System.EventHandler(this.formDelEleve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbINESuppr;
        private MetroFramework.Controls.MetroButton btSupprEleve;
        private MetroFramework.Controls.MetroLink mLinkReturn;
    }
}