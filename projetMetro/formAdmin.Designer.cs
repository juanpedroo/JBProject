namespace projetMetro
{
    partial class formAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdmin));
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTileImport = new MetroFramework.Controls.MetroTile();
            this.mTileStatus = new MetroFramework.Controls.MetroTile();
            this.mTileStats = new MetroFramework.Controls.MetroTile();
            this.mTileManualAdmin = new MetroFramework.Controls.MetroTile();
            this.mTileLinkServ = new MetroFramework.Controls.MetroTile();
            this.mTilePath = new MetroFramework.Controls.MetroTile();
            this.mTileActionBD = new MetroFramework.Controls.MetroTile();
            this.mTileDispEleve = new MetroFramework.Controls.MetroTile();
            this.mTileDelEleve = new MetroFramework.Controls.MetroTile();
            this.mTileAddEleve = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mTileConvert = new MetroFramework.Controls.MetroTile();
            this.mTileBarcode = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.metroTileImport);
            this.panel1.Controls.Add(this.mTileStatus);
            this.panel1.Controls.Add(this.mTileStats);
            this.panel1.Controls.Add(this.mTileManualAdmin);
            this.panel1.Controls.Add(this.mTileLinkServ);
            this.panel1.Controls.Add(this.mTilePath);
            this.panel1.Controls.Add(this.mTileActionBD);
            this.panel1.Controls.Add(this.mTileDispEleve);
            this.panel1.Controls.Add(this.mTileDelEleve);
            this.panel1.Controls.Add(this.mTileAddEleve);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.mTileConvert);
            this.panel1.Controls.Add(this.mTileBarcode);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 628);
            this.panel1.TabIndex = 5;
            // 
            // metroTileImport
            // 
            this.metroTileImport.ActiveControl = null;
            this.metroTileImport.Location = new System.Drawing.Point(708, 222);
            this.metroTileImport.Name = "metroTileImport";
            this.metroTileImport.Size = new System.Drawing.Size(130, 130);
            this.metroTileImport.TabIndex = 66;
            this.metroTileImport.Text = "Importer les élèves";
            this.metroTileImport.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileImport.TileImage")));
            this.metroTileImport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileImport.UseSelectable = true;
            this.metroTileImport.UseTileImage = true;
            this.metroTileImport.Click += new System.EventHandler(this.metroTileImport_Click);
            // 
            // mTileStatus
            // 
            this.mTileStatus.ActiveControl = null;
            this.mTileStatus.Location = new System.Drawing.Point(708, 387);
            this.mTileStatus.Name = "mTileStatus";
            this.mTileStatus.Size = new System.Drawing.Size(130, 130);
            this.mTileStatus.TabIndex = 65;
            this.mTileStatus.Text = "État des ressources";
            this.mTileStatus.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileStatus.TileImage")));
            this.mTileStatus.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileStatus.UseSelectable = true;
            this.mTileStatus.UseTileImage = true;
            this.mTileStatus.Click += new System.EventHandler(this.mTileStatut_Click);
            // 
            // mTileStats
            // 
            this.mTileStats.ActiveControl = null;
            this.mTileStats.Location = new System.Drawing.Point(572, 387);
            this.mTileStats.Name = "mTileStats";
            this.mTileStats.Size = new System.Drawing.Size(130, 130);
            this.mTileStats.TabIndex = 64;
            this.mTileStats.Text = "Statistiques";
            this.mTileStats.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileStats.TileImage")));
            this.mTileStats.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileStats.UseSelectable = true;
            this.mTileStats.UseTileImage = true;
            this.mTileStats.Click += new System.EventHandler(this.mTileStats_Click);
            // 
            // mTileManualAdmin
            // 
            this.mTileManualAdmin.ActiveControl = null;
            this.mTileManualAdmin.Location = new System.Drawing.Point(174, 86);
            this.mTileManualAdmin.Name = "mTileManualAdmin";
            this.mTileManualAdmin.Size = new System.Drawing.Size(236, 130);
            this.mTileManualAdmin.TabIndex = 62;
            this.mTileManualAdmin.Text = "Manuel Administrateur";
            this.mTileManualAdmin.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileManualAdmin.TileImage")));
            this.mTileManualAdmin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileManualAdmin.UseSelectable = true;
            this.mTileManualAdmin.UseTileImage = true;
            this.mTileManualAdmin.Click += new System.EventHandler(this.mTileManualAdmin_Click);
            // 
            // mTileLinkServ
            // 
            this.mTileLinkServ.ActiveControl = null;
            this.mTileLinkServ.Location = new System.Drawing.Point(174, 222);
            this.mTileLinkServ.Name = "mTileLinkServ";
            this.mTileLinkServ.Size = new System.Drawing.Size(130, 130);
            this.mTileLinkServ.TabIndex = 63;
            this.mTileLinkServ.Text = "Modifier l\'adresse serveur";
            this.mTileLinkServ.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileLinkServ.TileImage")));
            this.mTileLinkServ.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileLinkServ.UseSelectable = true;
            this.mTileLinkServ.UseTileImage = true;
            this.mTileLinkServ.Click += new System.EventHandler(this.mTileLinkServ_Click);
            // 
            // mTilePath
            // 
            this.mTilePath.ActiveControl = null;
            this.mTilePath.Location = new System.Drawing.Point(310, 222);
            this.mTilePath.Name = "mTilePath";
            this.mTilePath.Size = new System.Drawing.Size(236, 130);
            this.mTilePath.TabIndex = 61;
            this.mTilePath.Text = "Changer le chemin des ressources";
            this.mTilePath.TileImage = ((System.Drawing.Image)(resources.GetObject("mTilePath.TileImage")));
            this.mTilePath.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTilePath.UseSelectable = true;
            this.mTilePath.UseTileImage = true;
            this.mTilePath.Click += new System.EventHandler(this.mTilePath_Click);
            // 
            // mTileActionBD
            // 
            this.mTileActionBD.ActiveControl = null;
            this.mTileActionBD.Location = new System.Drawing.Point(416, 86);
            this.mTileActionBD.Name = "mTileActionBD";
            this.mTileActionBD.Size = new System.Drawing.Size(130, 130);
            this.mTileActionBD.TabIndex = 60;
            this.mTileActionBD.Text = "Agir sur la BD";
            this.mTileActionBD.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileActionBD.TileImage")));
            this.mTileActionBD.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileActionBD.UseSelectable = true;
            this.mTileActionBD.UseTileImage = true;
            // 
            // mTileDispEleve
            // 
            this.mTileDispEleve.ActiveControl = null;
            this.mTileDispEleve.Location = new System.Drawing.Point(572, 222);
            this.mTileDispEleve.Name = "mTileDispEleve";
            this.mTileDispEleve.Size = new System.Drawing.Size(130, 130);
            this.mTileDispEleve.TabIndex = 59;
            this.mTileDispEleve.Text = "Afficher les élèves";
            this.mTileDispEleve.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileDispEleve.TileImage")));
            this.mTileDispEleve.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileDispEleve.UseSelectable = true;
            this.mTileDispEleve.UseTileImage = true;
            this.mTileDispEleve.Click += new System.EventHandler(this.mTileDispEleve_Click);
            // 
            // mTileDelEleve
            // 
            this.mTileDelEleve.ActiveControl = null;
            this.mTileDelEleve.Location = new System.Drawing.Point(708, 86);
            this.mTileDelEleve.Name = "mTileDelEleve";
            this.mTileDelEleve.Size = new System.Drawing.Size(130, 130);
            this.mTileDelEleve.TabIndex = 58;
            this.mTileDelEleve.Text = "Supprimer";
            this.mTileDelEleve.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileDelEleve.TileImage")));
            this.mTileDelEleve.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileDelEleve.UseSelectable = true;
            this.mTileDelEleve.UseTileImage = true;
            this.mTileDelEleve.Click += new System.EventHandler(this.mTileDelEleve_Click);
            // 
            // mTileAddEleve
            // 
            this.mTileAddEleve.ActiveControl = null;
            this.mTileAddEleve.Location = new System.Drawing.Point(572, 86);
            this.mTileAddEleve.Name = "mTileAddEleve";
            this.mTileAddEleve.Size = new System.Drawing.Size(130, 130);
            this.mTileAddEleve.TabIndex = 57;
            this.mTileAddEleve.Text = "Ajouter";
            this.mTileAddEleve.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileAddEleve.TileImage")));
            this.mTileAddEleve.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAddEleve.UseSelectable = true;
            this.mTileAddEleve.UseTileImage = true;
            this.mTileAddEleve.Click += new System.EventHandler(this.mTileAddEleve_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(174, 363);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 21);
            this.metroLabel4.TabIndex = 56;
            this.metroLabel4.Text = "Préparer la rentrée";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(174, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(158, 19);
            this.metroLabel3.TabIndex = 55;
            this.metroLabel3.Text = "Gestion  de l\'application";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(572, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 19);
            this.metroLabel2.TabIndex = 54;
            this.metroLabel2.Text = "Gestion des élèves";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(572, 363);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 21);
            this.metroLabel1.TabIndex = 53;
            this.metroLabel1.Text = "Monitoring";
            // 
            // mTileConvert
            // 
            this.mTileConvert.ActiveControl = null;
            this.mTileConvert.Location = new System.Drawing.Point(310, 387);
            this.mTileConvert.Name = "mTileConvert";
            this.mTileConvert.Size = new System.Drawing.Size(236, 130);
            this.mTileConvert.TabIndex = 52;
            this.mTileConvert.Text = "Convertion Dbase MySql";
            this.mTileConvert.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileConvert.TileImage")));
            this.mTileConvert.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileConvert.UseSelectable = true;
            this.mTileConvert.UseTileImage = true;
            this.mTileConvert.Click += new System.EventHandler(this.mTileConvert_Click);
            // 
            // mTileBarcode
            // 
            this.mTileBarcode.ActiveControl = null;
            this.mTileBarcode.Location = new System.Drawing.Point(174, 387);
            this.mTileBarcode.Name = "mTileBarcode";
            this.mTileBarcode.Size = new System.Drawing.Size(130, 130);
            this.mTileBarcode.TabIndex = 51;
            this.mTileBarcode.Text = "Code barre";
            this.mTileBarcode.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileBarcode.TileImage")));
            this.mTileBarcode.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileBarcode.UseSelectable = true;
            this.mTileBarcode.UseTileImage = true;
            this.mTileBarcode.Click += new System.EventHandler(this.mTileBarcode_Click);
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1098, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mLinkReturn);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "formAdmin";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAdmin_FormClosed);
            this.Load += new System.EventHandler(this.formAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkReturn;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile mTileStatus;
        private MetroFramework.Controls.MetroTile mTileStats;
        private MetroFramework.Controls.MetroTile mTileLinkServ;
        private MetroFramework.Controls.MetroTile mTileManualAdmin;
        private MetroFramework.Controls.MetroTile mTilePath;
        private MetroFramework.Controls.MetroTile mTileActionBD;
        private MetroFramework.Controls.MetroTile mTileDispEleve;
        private MetroFramework.Controls.MetroTile mTileDelEleve;
        private MetroFramework.Controls.MetroTile mTileAddEleve;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mTileConvert;
        private MetroFramework.Controls.MetroTile mTileBarcode;
        private MetroFramework.Controls.MetroTile metroTileImport;
    }
}