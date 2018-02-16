namespace projetMetro
{
    partial class formStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStats));
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.mLabelAll = new MetroFramework.Controls.MetroLabel();
            this.mLabelDay = new MetroFramework.Controls.MetroLabel();
            this.mLabelMonth = new MetroFramework.Controls.MetroLabel();
            this.mLabelYear = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mBTreinitialiser = new MetroFramework.Controls.MetroButton();
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
            this.mLinkReturn.TabIndex = 4;
            this.mLinkReturn.UseSelectable = true;
            this.mLinkReturn.Click += new System.EventHandler(this.mLinkReturn_Click);
            // 
            // mLabelAll
            // 
            this.mLabelAll.AutoSize = true;
            this.mLabelAll.Location = new System.Drawing.Point(317, 71);
            this.mLabelAll.Name = "mLabelAll";
            this.mLabelAll.Size = new System.Drawing.Size(21, 19);
            this.mLabelAll.TabIndex = 12;
            this.mLabelAll.Text = "__";
            // 
            // mLabelDay
            // 
            this.mLabelDay.AutoSize = true;
            this.mLabelDay.Location = new System.Drawing.Point(317, 112);
            this.mLabelDay.Name = "mLabelDay";
            this.mLabelDay.Size = new System.Drawing.Size(21, 19);
            this.mLabelDay.TabIndex = 13;
            this.mLabelDay.Text = "__";
            // 
            // mLabelMonth
            // 
            this.mLabelMonth.AutoSize = true;
            this.mLabelMonth.Location = new System.Drawing.Point(317, 152);
            this.mLabelMonth.Name = "mLabelMonth";
            this.mLabelMonth.Size = new System.Drawing.Size(21, 19);
            this.mLabelMonth.TabIndex = 14;
            this.mLabelMonth.Text = "__";
            // 
            // mLabelYear
            // 
            this.mLabelYear.AutoSize = true;
            this.mLabelYear.Location = new System.Drawing.Point(317, 190);
            this.mLabelYear.Name = "mLabelYear";
            this.mLabelYear.Size = new System.Drawing.Size(21, 19);
            this.mLabelYear.TabIndex = 15;
            this.mLabelYear.Text = "__";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(258, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Nombre d\'élèves scannés depuis le début :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(226, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Nombre d\'élèves scannés aujourd\'hui";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 152);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(228, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Nombre d\'élèves scannés ce mois-ci :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(235, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Nombre d\'élèves scannés cette année :";
            // 
            // mBTreinitialiser
            // 
            this.mBTreinitialiser.BackColor = System.Drawing.Color.DodgerBlue;
            this.mBTreinitialiser.ForeColor = System.Drawing.Color.White;
            this.mBTreinitialiser.Location = new System.Drawing.Point(377, 263);
            this.mBTreinitialiser.Name = "mBTreinitialiser";
            this.mBTreinitialiser.Size = new System.Drawing.Size(105, 23);
            this.mBTreinitialiser.TabIndex = 20;
            this.mBTreinitialiser.Text = "Réinitialiser";
            this.mBTreinitialiser.UseCustomBackColor = true;
            this.mBTreinitialiser.UseCustomForeColor = true;
            this.mBTreinitialiser.UseSelectable = true;
            this.mBTreinitialiser.Click += new System.EventHandler(this.mBTreinitialiser_Click);
            // 
            // formStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(492, 293);
            this.Controls.Add(this.mBTreinitialiser);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mLabelYear);
            this.Controls.Add(this.mLabelMonth);
            this.Controls.Add(this.mLabelDay);
            this.Controls.Add(this.mLabelAll);
            this.Controls.Add(this.mLinkReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formStats";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.formStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkReturn;
        private MetroFramework.Controls.MetroLabel mLabelAll;
        private MetroFramework.Controls.MetroLabel mLabelDay;
        private MetroFramework.Controls.MetroLabel mLabelMonth;
        private MetroFramework.Controls.MetroLabel mLabelYear;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mBTreinitialiser;
    }
}