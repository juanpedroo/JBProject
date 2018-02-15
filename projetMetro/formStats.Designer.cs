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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mLinkReturn = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mLabelScanEleve = new MetroFramework.Controls.MetroLabel();
            this.labelDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTsimulation = new System.Windows.Forms.Button();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Nombre d\'élèves scannés :";
            // 
            // mLabelScanEleve
            // 
            this.mLabelScanEleve.AutoSize = true;
            this.mLabelScanEleve.Location = new System.Drawing.Point(195, 63);
            this.mLabelScanEleve.Name = "mLabelScanEleve";
            this.mLabelScanEleve.Size = new System.Drawing.Size(0, 0);
            this.mLabelScanEleve.TabIndex = 6;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(24, 109);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(28, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // BTsimulation
            // 
            this.BTsimulation.Location = new System.Drawing.Point(214, 294);
            this.BTsimulation.Name = "BTsimulation";
            this.BTsimulation.Size = new System.Drawing.Size(115, 59);
            this.BTsimulation.TabIndex = 11;
            this.BTsimulation.Text = "Simulation";
            this.BTsimulation.UseVisualStyleBackColor = true;
            this.BTsimulation.Click += new System.EventHandler(this.BTsimulation_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(184, 377);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(115, 29);
            this.metroDateTime1.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(366, 7);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(376, 388);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // formStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(765, 465);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.BTsimulation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.mLabelScanEleve);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mLinkReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formStats";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.formStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkReturn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mLabelScanEleve;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTsimulation;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}