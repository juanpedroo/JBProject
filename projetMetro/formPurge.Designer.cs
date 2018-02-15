namespace projetMetro
{
    partial class formPurge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPurge));
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.mBTpurgeE = new MetroFramework.Controls.MetroButton();
            this.mBTpurge = new MetroFramework.Controls.MetroButton();
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
            this.mLinkReturn.TabIndex = 5;
            this.mLinkReturn.UseSelectable = true;
            this.mLinkReturn.Click += new System.EventHandler(this.mLinkReturn_Click);
            // 
            // mBTpurgeE
            // 
            this.mBTpurgeE.BackColor = System.Drawing.Color.DodgerBlue;
            this.mBTpurgeE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBTpurgeE.ForeColor = System.Drawing.Color.White;
            this.mBTpurgeE.Location = new System.Drawing.Point(115, 63);
            this.mBTpurgeE.Name = "mBTpurgeE";
            this.mBTpurgeE.Size = new System.Drawing.Size(371, 62);
            this.mBTpurgeE.TabIndex = 6;
            this.mBTpurgeE.Text = "Purger les élèves";
            this.mBTpurgeE.UseCustomBackColor = true;
            this.mBTpurgeE.UseCustomForeColor = true;
            this.mBTpurgeE.UseSelectable = true;
            this.mBTpurgeE.Click += new System.EventHandler(this.mBTpurgeE_Click);
            // 
            // mBTpurge
            // 
            this.mBTpurge.BackColor = System.Drawing.Color.DodgerBlue;
            this.mBTpurge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBTpurge.ForeColor = System.Drawing.Color.White;
            this.mBTpurge.Location = new System.Drawing.Point(115, 146);
            this.mBTpurge.Name = "mBTpurge";
            this.mBTpurge.Size = new System.Drawing.Size(371, 62);
            this.mBTpurge.TabIndex = 7;
            this.mBTpurge.Text = "Purger les statistiques";
            this.mBTpurge.UseCustomBackColor = true;
            this.mBTpurge.UseCustomForeColor = true;
            this.mBTpurge.UseSelectable = true;
            this.mBTpurge.Click += new System.EventHandler(this.mBTpurge_Click);
            // 
            // formPurge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.mBTpurge);
            this.Controls.Add(this.mBTpurgeE);
            this.Controls.Add(this.mLinkReturn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "formPurge";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formPurge_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkReturn;
        private MetroFramework.Controls.MetroButton mBTpurgeE;
        private MetroFramework.Controls.MetroButton mBTpurge;
    }
}