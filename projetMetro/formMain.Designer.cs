namespace projetMetro
{
    partial class formMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.mTileAdmin = new MetroFramework.Controls.MetroTile();
            this.mTileUser = new MetroFramework.Controls.MetroTile();
            this.mTileHelp = new MetroFramework.Controls.MetroTile();
            this.mTileAbout = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mTileAdmin
            // 
            this.mTileAdmin.ActiveControl = null;
            this.mTileAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.mTileAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mTileAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mTileAdmin.Location = new System.Drawing.Point(65, 64);
            this.mTileAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.mTileAdmin.Name = "mTileAdmin";
            this.mTileAdmin.Size = new System.Drawing.Size(130, 130);
            this.mTileAdmin.TabIndex = 2;
            this.mTileAdmin.TabStop = false;
            this.mTileAdmin.Text = "Administrateur";
            this.mTileAdmin.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileAdmin.TileImage")));
            this.mTileAdmin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAdmin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileAdmin.UseCustomBackColor = true;
            this.mTileAdmin.UseCustomForeColor = true;
            this.mTileAdmin.UseSelectable = true;
            this.mTileAdmin.UseTileImage = true;
            this.mTileAdmin.Click += new System.EventHandler(this.mTileAdmin_Click);
            // 
            // mTileUser
            // 
            this.mTileUser.ActiveControl = null;
            this.mTileUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.mTileUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mTileUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mTileUser.Location = new System.Drawing.Point(203, 64);
            this.mTileUser.Margin = new System.Windows.Forms.Padding(4);
            this.mTileUser.Name = "mTileUser";
            this.mTileUser.Size = new System.Drawing.Size(130, 130);
            this.mTileUser.TabIndex = 3;
            this.mTileUser.TabStop = false;
            this.mTileUser.Text = "Utilisateur";
            this.mTileUser.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileUser.TileImage")));
            this.mTileUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileUser.UseCustomBackColor = true;
            this.mTileUser.UseCustomForeColor = true;
            this.mTileUser.UseSelectable = true;
            this.mTileUser.UseTileImage = true;
            this.mTileUser.Click += new System.EventHandler(this.mTileUser_Click);
            // 
            // mTileHelp
            // 
            this.mTileHelp.ActiveControl = null;
            this.mTileHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.mTileHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mTileHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mTileHelp.Location = new System.Drawing.Point(65, 202);
            this.mTileHelp.Margin = new System.Windows.Forms.Padding(4);
            this.mTileHelp.Name = "mTileHelp";
            this.mTileHelp.Size = new System.Drawing.Size(130, 130);
            this.mTileHelp.TabIndex = 4;
            this.mTileHelp.TabStop = false;
            this.mTileHelp.Text = "Aide";
            this.mTileHelp.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileHelp.TileImage")));
            this.mTileHelp.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileHelp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileHelp.UseCustomBackColor = true;
            this.mTileHelp.UseCustomForeColor = true;
            this.mTileHelp.UseSelectable = true;
            this.mTileHelp.UseTileImage = true;
            this.mTileHelp.Click += new System.EventHandler(this.mTileHelp_Click);
            // 
            // mTileAbout
            // 
            this.mTileAbout.ActiveControl = null;
            this.mTileAbout.BackColor = System.Drawing.Color.DodgerBlue;
            this.mTileAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mTileAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mTileAbout.Location = new System.Drawing.Point(203, 202);
            this.mTileAbout.Margin = new System.Windows.Forms.Padding(4);
            this.mTileAbout.Name = "mTileAbout";
            this.mTileAbout.Size = new System.Drawing.Size(130, 130);
            this.mTileAbout.TabIndex = 5;
            this.mTileAbout.TabStop = false;
            this.mTileAbout.Text = "À propos";
            this.mTileAbout.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileAbout.TileImage")));
            this.mTileAbout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAbout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileAbout.UseCustomBackColor = true;
            this.mTileAbout.UseCustomForeColor = true;
            this.mTileAbout.UseSelectable = true;
            this.mTileAbout.UseTileImage = true;
            this.mTileAbout.Click += new System.EventHandler(this.mTileAbout_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.mTileAbout);
            this.Controls.Add(this.mTileHelp);
            this.Controls.Add(this.mTileUser);
            this.Controls.Add(this.mTileAdmin);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "formMain";
            this.Padding = new System.Windows.Forms.Padding(27, 78, 27, 26);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mTileAdmin;
        private MetroFramework.Controls.MetroTile mTileUser;
        private MetroFramework.Controls.MetroTile mTileHelp;
        private MetroFramework.Controls.MetroTile mTileAbout;
    }
}

