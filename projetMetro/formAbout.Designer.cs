namespace projetMetro
{
    partial class formAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbout));
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.mLinkBP = new MetroFramework.Controls.MetroLink();
            this.mLinkJF = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mLinkReturn
            // 
            this.mLinkReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mLinkReturn.Image = ((System.Drawing.Image)(resources.GetObject("mLinkReturn.Image")));
            this.mLinkReturn.ImageSize = 32;
            this.mLinkReturn.Location = new System.Drawing.Point(1, 7);
            this.mLinkReturn.Name = "mLinkReturn";
            this.mLinkReturn.Size = new System.Drawing.Size(38, 35);
            this.mLinkReturn.TabIndex = 3;
            this.mLinkReturn.UseSelectable = true;
            this.mLinkReturn.Click += new System.EventHandler(this.mLinkReturn_Click);
            // 
            // mLinkBP
            // 
            this.mLinkBP.BackColor = System.Drawing.Color.DodgerBlue;
            this.mLinkBP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mLinkBP.ForeColor = System.Drawing.Color.White;
            this.mLinkBP.Location = new System.Drawing.Point(119, 190);
            this.mLinkBP.Name = "mLinkBP";
            this.mLinkBP.Size = new System.Drawing.Size(140, 23);
            this.mLinkBP.TabIndex = 4;
            this.mLinkBP.Text = "Baptiste Pautard";
            this.mLinkBP.UseCustomBackColor = true;
            this.mLinkBP.UseCustomForeColor = true;
            this.mLinkBP.UseSelectable = true;
            this.mLinkBP.Click += new System.EventHandler(this.mLinkBP_Click);
            // 
            // mLinkJF
            // 
            this.mLinkJF.BackColor = System.Drawing.Color.DodgerBlue;
            this.mLinkJF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mLinkJF.ForeColor = System.Drawing.Color.White;
            this.mLinkJF.Location = new System.Drawing.Point(119, 161);
            this.mLinkJF.Name = "mLinkJF";
            this.mLinkJF.Size = new System.Drawing.Size(140, 23);
            this.mLinkJF.TabIndex = 5;
            this.mLinkJF.Text = "Jonathan Ferreira";
            this.mLinkJF.UseCustomBackColor = true;
            this.mLinkJF.UseCustomForeColor = true;
            this.mLinkJF.UseSelectable = true;
            this.mLinkJF.Click += new System.EventHandler(this.mLinkJF_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(101, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(205, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Application réalisée dans le cadre";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(369, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "de notre deuxième année de BTS SIO option programmation";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(157, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Nos liens :";
            // 
            // metroLink1
            // 
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.Image = global::projetMetro.Properties.Resources.githubcat;
            this.metroLink1.ImageSize = 64;
            this.metroLink1.Location = new System.Drawing.Point(160, 255);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(65, 71);
            this.metroLink1.TabIndex = 9;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::projetMetro.Properties.Resources.githublogo64;
            this.pictureBox1.Location = new System.Drawing.Point(161, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mLinkJF);
            this.Controls.Add(this.mLinkBP);
            this.Controls.Add(this.mLinkReturn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "formAbout";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAbout_FormClosed);
            this.Load += new System.EventHandler(this.formAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkReturn;
        private MetroFramework.Controls.MetroLink mLinkBP;
        private MetroFramework.Controls.MetroLink mLinkJF;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}