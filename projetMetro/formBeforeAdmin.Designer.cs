namespace projetMetro
{
    partial class formBeforeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBeforeAdmin));
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mBTconnect = new MetroFramework.Controls.MetroButton();
            this.mTBusername = new MetroFramework.Controls.MetroTextBox();
            this.mTBpassword = new MetroFramework.Controls.MetroTextBox();
            this.mLabelEtat = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mLinkReturn
            // 
            this.mLinkReturn.Image = ((System.Drawing.Image)(resources.GetObject("mLinkReturn.Image")));
            this.mLinkReturn.ImageSize = 32;
            this.mLinkReturn.Location = new System.Drawing.Point(1, 7);
            this.mLinkReturn.Name = "mLinkReturn";
            this.mLinkReturn.Size = new System.Drawing.Size(38, 35);
            this.mLinkReturn.TabIndex = 3;
            this.mLinkReturn.UseSelectable = true;
            this.mLinkReturn.Click += new System.EventHandler(this.mLinkReturn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(187, 129);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Compte :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(156, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Mot de passe :";
            // 
            // mBTconnect
            // 
            this.mBTconnect.BackColor = System.Drawing.Color.DodgerBlue;
            this.mBTconnect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBTconnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mBTconnect.Location = new System.Drawing.Point(216, 244);
            this.mBTconnect.Name = "mBTconnect";
            this.mBTconnect.Size = new System.Drawing.Size(112, 40);
            this.mBTconnect.TabIndex = 6;
            this.mBTconnect.Text = "Se connecter";
            this.mBTconnect.UseCustomBackColor = true;
            this.mBTconnect.UseCustomForeColor = true;
            this.mBTconnect.UseSelectable = true;
            this.mBTconnect.Click += new System.EventHandler(this.mBTconnect_Click);
            // 
            // mTBusername
            // 
            this.mTBusername.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mTBusername.CustomButton.Image = null;
            this.mTBusername.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.mTBusername.CustomButton.Name = "";
            this.mTBusername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTBusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBusername.CustomButton.TabIndex = 1;
            this.mTBusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBusername.CustomButton.UseSelectable = true;
            this.mTBusername.CustomButton.Visible = false;
            this.mTBusername.Lines = new string[0];
            this.mTBusername.Location = new System.Drawing.Point(257, 129);
            this.mTBusername.MaxLength = 32767;
            this.mTBusername.Name = "mTBusername";
            this.mTBusername.PasswordChar = '\0';
            this.mTBusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBusername.SelectedText = "";
            this.mTBusername.SelectionLength = 0;
            this.mTBusername.SelectionStart = 0;
            this.mTBusername.ShortcutsEnabled = true;
            this.mTBusername.Size = new System.Drawing.Size(104, 23);
            this.mTBusername.TabIndex = 7;
            this.mTBusername.UseCustomBackColor = true;
            this.mTBusername.UseCustomForeColor = true;
            this.mTBusername.UseSelectable = true;
            this.mTBusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTBpassword
            // 
            // 
            // 
            // 
            this.mTBpassword.CustomButton.Image = null;
            this.mTBpassword.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.mTBpassword.CustomButton.Name = "";
            this.mTBpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTBpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBpassword.CustomButton.TabIndex = 1;
            this.mTBpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBpassword.CustomButton.UseSelectable = true;
            this.mTBpassword.CustomButton.Visible = false;
            this.mTBpassword.Lines = new string[0];
            this.mTBpassword.Location = new System.Drawing.Point(257, 173);
            this.mTBpassword.MaxLength = 32767;
            this.mTBpassword.Name = "mTBpassword";
            this.mTBpassword.PasswordChar = '●';
            this.mTBpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBpassword.SelectedText = "";
            this.mTBpassword.SelectionLength = 0;
            this.mTBpassword.SelectionStart = 0;
            this.mTBpassword.ShortcutsEnabled = true;
            this.mTBpassword.Size = new System.Drawing.Size(104, 23);
            this.mTBpassword.TabIndex = 8;
            this.mTBpassword.UseCustomBackColor = true;
            this.mTBpassword.UseCustomForeColor = true;
            this.mTBpassword.UseSelectable = true;
            this.mTBpassword.UseSystemPasswordChar = true;
            this.mTBpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelEtat
            // 
            this.mLabelEtat.AutoSize = true;
            this.mLabelEtat.ForeColor = System.Drawing.Color.Red;
            this.mLabelEtat.Location = new System.Drawing.Point(165, 213);
            this.mLabelEtat.Name = "mLabelEtat";
            this.mLabelEtat.Size = new System.Drawing.Size(0, 0);
            this.mLabelEtat.TabIndex = 9;
            this.mLabelEtat.UseCustomForeColor = true;
            // 
            // formBeforeAdmin
            // 
            this.AcceptButton = this.mBTconnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.mLabelEtat);
            this.Controls.Add(this.mTBpassword);
            this.Controls.Add(this.mTBusername);
            this.Controls.Add(this.mBTconnect);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mLinkReturn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "formBeforeAdmin";
            this.Resizable = false; 
            this.Load += new System.EventHandler(this.formBeforeAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkReturn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mBTconnect;
        private MetroFramework.Controls.MetroTextBox mTBusername;
        private MetroFramework.Controls.MetroTextBox mTBpassword;
        private MetroFramework.Controls.MetroLabel mLabelEtat;
    }
}