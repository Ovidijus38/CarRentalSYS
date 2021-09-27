
namespace CarRentalSYS
{
    partial class frmYearlyRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblYear = new System.Windows.Forms.Label();
            this.YearlyRevenueAnalysis = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.chartYearlyRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.YearlyRevenueAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYearlyRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(58, 88);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 25);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            // 
            // YearlyRevenueAnalysis
            // 
            this.YearlyRevenueAnalysis.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.YearlyRevenueAnalysis.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.YearlyRevenueAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.YearlyRevenueAnalysis.Location = new System.Drawing.Point(0, 0);
            this.YearlyRevenueAnalysis.Name = "YearlyRevenueAnalysis";
            this.YearlyRevenueAnalysis.Size = new System.Drawing.Size(1096, 36);
            this.YearlyRevenueAnalysis.TabIndex = 12;
            this.YearlyRevenueAnalysis.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(55, 32);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(64, 32);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021"});
            this.comboBoxYear.Location = new System.Drawing.Point(166, 88);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(136, 28);
            this.comboBoxYear.TabIndex = 13;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // chartYearlyRevenue
            // 
            chartArea1.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea1.AxisX.Title = "Months";
            chartArea1.AxisY.Title = "Revenue €";
            chartArea1.Name = "ChartArea1";
            this.chartYearlyRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Yearly revenue";
            this.chartYearlyRevenue.Legends.Add(legend1);
            this.chartYearlyRevenue.Location = new System.Drawing.Point(37, 146);
            this.chartYearlyRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartYearlyRevenue.Name = "chartYearlyRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Yearly revenue";
            series1.Name = "Series1";
            this.chartYearlyRevenue.Series.Add(series1);
            this.chartYearlyRevenue.Size = new System.Drawing.Size(1045, 658);
            this.chartYearlyRevenue.TabIndex = 14;
            this.chartYearlyRevenue.Text = "chart1";
            this.chartYearlyRevenue.Click += new System.EventHandler(this.chartYearlyRevenue_Click);
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 819);
            this.Controls.Add(this.chartYearlyRevenue);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.YearlyRevenueAnalysis);
            this.MainMenuStrip = this.YearlyRevenueAnalysis;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "frmYearlyRevenueAnalysis";
            this.Load += new System.EventHandler(this.frmYearlyRevenueAnalysis_Load);
            this.YearlyRevenueAnalysis.ResumeLayout(false);
            this.YearlyRevenueAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYearlyRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.MenuStrip YearlyRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYearlyRevenue;
    }
}