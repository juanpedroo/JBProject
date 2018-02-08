namespace projetMetro
{
    partial class formLinkServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLinkServer));
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.btServ = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mLbServ = new MetroFramework.Controls.MetroLabel();
            this.mTbServ = new IPAddressControlLib.IPAddressControl();
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
            // btServ
            // 
            this.btServ.Location = new System.Drawing.Point(534, 298);
            this.btServ.Name = "btServ";
            this.btServ.Size = new System.Drawing.Size(98, 45);
            this.btServ.TabIndex = 8;
            this.btServ.Text = "Valider";
            this.btServ.UseSelectable = true;
            this.btServ.Click += new System.EventHandler(this.btServ_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(122, 171);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(158, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Chemin serveur MySQL : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(122, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(207, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Adresse serveur MySQL actuelle : ";
            // 
            // mLbServ
            // 
            this.mLbServ.AutoSize = true;
            this.mLbServ.Location = new System.Drawing.Point(335, 105);
            this.mLbServ.Name = "mLbServ";
            this.mLbServ.Size = new System.Drawing.Size(55, 19);
            this.mLbServ.TabIndex = 10;
            this.mLbServ.Text = "Adresse";
            // 
            // mTbServ
            // 
            this.mTbServ.AllowInternalTab = false;
            this.mTbServ.AutoHeight = true;
            this.mTbServ.BackColor = System.Drawing.SystemColors.Window;
            this.mTbServ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mTbServ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mTbServ.Location = new System.Drawing.Point(286, 171);
            this.mTbServ.MinimumSize = new System.Drawing.Size(87, 20);
            this.mTbServ.Name = "mTbServ";
            this.mTbServ.ReadOnly = false;
            this.mTbServ.Size = new System.Drawing.Size(170, 20);
            this.mTbServ.TabIndex = 11;
            this.mTbServ.Text = "...";
            // 
            // formLinkServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(655, 366);
            this.Controls.Add(this.mTbServ);
            this.Controls.Add(this.mLbServ);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btServ);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mLinkReturn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLinkServer";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formLinkServer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkReturn;
        private MetroFramework.Controls.MetroButton btServ;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel mLbServ;
        private IPAddressControlLib.IPAddressControl mTbServ;
    }
}