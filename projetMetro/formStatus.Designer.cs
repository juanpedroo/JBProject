namespace projetMetro
{
    partial class formStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStatus));
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
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
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(259, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(199, 37);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Vérifier l\'état des ressources";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.ForeColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(209, 106);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(312, 113);
            this.metroTile1.TabIndex = 6;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // formStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(756, 263);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mLinkReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formStatus";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.formStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkReturn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}