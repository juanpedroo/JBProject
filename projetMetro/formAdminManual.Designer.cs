﻿namespace projetMetro
{
    partial class formAdminManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdminManual));
            this.mLinkRetry = new MetroFramework.Controls.MetroLink();
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // mLinkRetry
            // 
            this.mLinkRetry.Image = ((System.Drawing.Image)(resources.GetObject("mLinkRetry.Image")));
            this.mLinkRetry.ImageSize = 32;
            this.mLinkRetry.Location = new System.Drawing.Point(50, 7);
            this.mLinkRetry.Name = "mLinkRetry";
            this.mLinkRetry.Size = new System.Drawing.Size(38, 35);
            this.mLinkRetry.TabIndex = 6;
            this.mLinkRetry.UseSelectable = true;
            this.mLinkRetry.Click += new System.EventHandler(this.mLinkRetry_Click);
            // 
            // mLinkReturn
            // 
            this.mLinkReturn.Image = ((System.Drawing.Image)(resources.GetObject("mLinkReturn.Image")));
            this.mLinkReturn.ImageSize = 32;
            this.mLinkReturn.Location = new System.Drawing.Point(1, 7);
            this.mLinkReturn.Name = "mLinkReturn";
            this.mLinkReturn.Size = new System.Drawing.Size(38, 35);
            this.mLinkReturn.TabIndex = 5;
            this.mLinkReturn.UseSelectable = true;
            this.mLinkReturn.Click += new System.EventHandler(this.mLinkReturn_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(15, 63);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1066, 641);
            this.axAcroPDF1.TabIndex = 7;
            // 
            // formAdminManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1098, 714);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.mLinkRetry);
            this.Controls.Add(this.mLinkReturn);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "formAdminManual";
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAdminManual_FormClosed);
            this.Load += new System.EventHandler(this.formAdminManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkRetry;
        private MetroFramework.Controls.MetroLink mLinkReturn;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}