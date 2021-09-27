
namespace CarRentalSYS
{
    partial class frmListDailyRent
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
            this.lblChoose = new System.Windows.Forms.Label();
            this.cboChooseCarClass = new System.Windows.Forms.ComboBox();
            this.btnShowAnalysis = new System.Windows.Forms.Button();
            this.grpTotalRent = new System.Windows.Forms.GroupBox();
            this.lstRentDisplay = new System.Windows.Forms.ListBox();
            this.mnuListDailyRent = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTotalRent.SuspendLayout();
            this.mnuListDailyRent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(63, 77);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(179, 25);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Choose car class";
            this.lblChoose.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboChooseCarClass
            // 
            this.cboChooseCarClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChooseCarClass.FormattingEnabled = true;
            this.cboChooseCarClass.Location = new System.Drawing.Point(312, 78);
            this.cboChooseCarClass.Name = "cboChooseCarClass";
            this.cboChooseCarClass.Size = new System.Drawing.Size(218, 28);
            this.cboChooseCarClass.TabIndex = 1;
            this.cboChooseCarClass.SelectedIndexChanged += new System.EventHandler(this.cboChooseCarClass_SelectedIndexChanged);
            // 
            // btnShowAnalysis
            // 
            this.btnShowAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAnalysis.Location = new System.Drawing.Point(444, 420);
            this.btnShowAnalysis.Name = "btnShowAnalysis";
            this.btnShowAnalysis.Size = new System.Drawing.Size(243, 61);
            this.btnShowAnalysis.TabIndex = 3;
            this.btnShowAnalysis.Text = "Show Daily Rent";
            this.btnShowAnalysis.UseVisualStyleBackColor = true;
            this.btnShowAnalysis.Click += new System.EventHandler(this.btnShowAnalysis_Click);
            // 
            // grpTotalRent
            // 
            this.grpTotalRent.Controls.Add(this.lstRentDisplay);
            this.grpTotalRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotalRent.Location = new System.Drawing.Point(68, 186);
            this.grpTotalRent.Name = "grpTotalRent";
            this.grpTotalRent.Size = new System.Drawing.Size(865, 188);
            this.grpTotalRent.TabIndex = 4;
            this.grpTotalRent.TabStop = false;
            this.grpTotalRent.Text = "Total Daily Rent";
            this.grpTotalRent.Enter += new System.EventHandler(this.grpTotalRent_Enter);
            // 
            // lstRentDisplay
            // 
            this.lstRentDisplay.FormattingEnabled = true;
            this.lstRentDisplay.ItemHeight = 25;
            this.lstRentDisplay.Location = new System.Drawing.Point(28, 58);
            this.lstRentDisplay.Name = "lstRentDisplay";
            this.lstRentDisplay.Size = new System.Drawing.Size(812, 104);
            this.lstRentDisplay.TabIndex = 0;
            // 
            // mnuListDailyRent
            // 
            this.mnuListDailyRent.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuListDailyRent.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuListDailyRent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuListDailyRent.Location = new System.Drawing.Point(0, 0);
            this.mnuListDailyRent.Name = "mnuListDailyRent";
            this.mnuListDailyRent.Size = new System.Drawing.Size(1305, 33);
            this.mnuListDailyRent.TabIndex = 5;
            this.mnuListDailyRent.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(64, 29);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(55, 29);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmListDailyRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1305, 887);
            this.Controls.Add(this.grpTotalRent);
            this.Controls.Add(this.btnShowAnalysis);
            this.Controls.Add(this.cboChooseCarClass);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.mnuListDailyRent);
            this.MainMenuStrip = this.mnuListDailyRent;
            this.Name = "frmListDailyRent";
            this.Text = "frmListDailyRent";
            this.Load += new System.EventHandler(this.frmListDailyRent_Load);
            this.grpTotalRent.ResumeLayout(false);
            this.mnuListDailyRent.ResumeLayout(false);
            this.mnuListDailyRent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.ComboBox cboChooseCarClass;
        private System.Windows.Forms.Button btnShowAnalysis;
        private System.Windows.Forms.GroupBox grpTotalRent;
        private System.Windows.Forms.ListBox lstRentDisplay;
        private System.Windows.Forms.MenuStrip mnuListDailyRent;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}