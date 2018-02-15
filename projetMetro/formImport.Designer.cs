namespace projetMetro
{
    partial class formImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formImport));
            this.mBtnImportPath = new MetroFramework.Controls.MetroButton();
            this.mTbPath = new MetroFramework.Controls.MetroTextBox();
            this.mBtImport = new MetroFramework.Controls.MetroButton();
            this.mPB = new MetroFramework.Controls.MetroProgressBar();
            this.mLViewStatus = new MetroFramework.Controls.MetroListView();
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mBtnImportPath
            // 
            this.mBtnImportPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnImportPath.Location = new System.Drawing.Point(425, 75);
            this.mBtnImportPath.Name = "mBtnImportPath";
            this.mBtnImportPath.Size = new System.Drawing.Size(17, 23);
            this.mBtnImportPath.TabIndex = 0;
            this.mBtnImportPath.Text = "...";
            this.mBtnImportPath.UseSelectable = true;
            this.mBtnImportPath.Click += new System.EventHandler(this.mBtnImport_Click);
            // 
            // mTbPath
            // 
            // 
            // 
            // 
            this.mTbPath.CustomButton.Image = null;
            this.mTbPath.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.mTbPath.CustomButton.Name = "";
            this.mTbPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTbPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTbPath.CustomButton.TabIndex = 1;
            this.mTbPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTbPath.CustomButton.UseSelectable = true;
            this.mTbPath.CustomButton.Visible = false;
            this.mTbPath.Lines = new string[0];
            this.mTbPath.Location = new System.Drawing.Point(145, 75);
            this.mTbPath.MaxLength = 32767;
            this.mTbPath.Name = "mTbPath";
            this.mTbPath.PasswordChar = '\0';
            this.mTbPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTbPath.SelectedText = "";
            this.mTbPath.SelectionLength = 0;
            this.mTbPath.SelectionStart = 0;
            this.mTbPath.ShortcutsEnabled = true;
            this.mTbPath.Size = new System.Drawing.Size(274, 23);
            this.mTbPath.TabIndex = 1;
            this.mTbPath.UseSelectable = true;
            this.mTbPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTbPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mBtImport
            // 
            this.mBtImport.BackColor = System.Drawing.Color.DodgerBlue;
            this.mBtImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtImport.ForeColor = System.Drawing.Color.White;
            this.mBtImport.Location = new System.Drawing.Point(464, 163);
            this.mBtImport.Name = "mBtImport";
            this.mBtImport.Size = new System.Drawing.Size(150, 46);
            this.mBtImport.TabIndex = 3;
            this.mBtImport.Text = "Importer le fichier texte";
            this.mBtImport.UseCustomBackColor = true;
            this.mBtImport.UseCustomForeColor = true;
            this.mBtImport.UseSelectable = true;
            this.mBtImport.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mPB
            // 
            this.mPB.Location = new System.Drawing.Point(145, 243);
            this.mPB.Name = "mPB";
            this.mPB.Size = new System.Drawing.Size(274, 27);
            this.mPB.TabIndex = 4;
            // 
            // mLViewStatus
            // 
            this.mLViewStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mLViewStatus.FullRowSelect = true;
            this.mLViewStatus.LabelWrap = false;
            this.mLViewStatus.Location = new System.Drawing.Point(145, 124);
            this.mLViewStatus.MultiSelect = false;
            this.mLViewStatus.Name = "mLViewStatus";
            this.mLViewStatus.OwnerDraw = true;
            this.mLViewStatus.Scrollable = false;
            this.mLViewStatus.Size = new System.Drawing.Size(274, 113);
            this.mLViewStatus.TabIndex = 6;
            this.mLViewStatus.UseCompatibleStateImageBehavior = false;
            this.mLViewStatus.UseSelectable = true;
            this.mLViewStatus.View = System.Windows.Forms.View.List;
            // 
            // mLinkReturn
            // 
            this.mLinkReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mLinkReturn.Image = ((System.Drawing.Image)(resources.GetObject("mLinkReturn.Image")));
            this.mLinkReturn.ImageSize = 32;
            this.mLinkReturn.Location = new System.Drawing.Point(1, 7);
            this.mLinkReturn.Name = "mLinkReturn";
            this.mLinkReturn.Size = new System.Drawing.Size(38, 35);
            this.mLinkReturn.TabIndex = 7;
            this.mLinkReturn.UseSelectable = true;
            this.mLinkReturn.Click += new System.EventHandler(this.mLinkReturn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(145, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(283, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Veuillez sélectionner le fichier à importer";
            // 
            // formImport
            // 
            this.AcceptButton = this.mBtImport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 320);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mLinkReturn);
            this.Controls.Add(this.mLViewStatus);
            this.Controls.Add(this.mPB);
            this.Controls.Add(this.mBtImport);
            this.Controls.Add(this.mTbPath);
            this.Controls.Add(this.mBtnImportPath);
            this.MaximizeBox = false;
            this.Name = "formImport";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.formImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnImportPath;
        private MetroFramework.Controls.MetroTextBox mTbPath;
        private MetroFramework.Controls.MetroButton mBtImport;
        private MetroFramework.Controls.MetroProgressBar mPB;
        private MetroFramework.Controls.MetroListView mLViewStatus;
        private MetroFramework.Controls.MetroLink mLinkReturn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}