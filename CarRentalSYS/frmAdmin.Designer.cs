namespace CarRentalSYS
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnListDailyRent = new System.Windows.Forms.Button();
            this.btnYearlyRevenue = new System.Windows.Forms.Button();
            this.mnuAdmin = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListDailyRent
            // 
            this.btnListDailyRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListDailyRent.Location = new System.Drawing.Point(38, 82);
            this.btnListDailyRent.Name = "btnListDailyRent";
            this.btnListDailyRent.Size = new System.Drawing.Size(259, 97);
            this.btnListDailyRent.TabIndex = 0;
            this.btnListDailyRent.Text = "List Daily Rent";
            this.btnListDailyRent.UseVisualStyleBackColor = true;
            this.btnListDailyRent.Click += new System.EventHandler(this.btnListDailyRent_Click);
            // 
            // btnYearlyRevenue
            // 
            this.btnYearlyRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearlyRevenue.Location = new System.Drawing.Point(38, 208);
            this.btnYearlyRevenue.Name = "btnYearlyRevenue";
            this.btnYearlyRevenue.Size = new System.Drawing.Size(259, 97);
            this.btnYearlyRevenue.TabIndex = 1;
            this.btnYearlyRevenue.Text = "Yearly Revenue Analysis";
            this.btnYearlyRevenue.UseVisualStyleBackColor = true;
            this.btnYearlyRevenue.Click += new System.EventHandler(this.btnYearlyRevenue_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuAdmin.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuAdmin.Location = new System.Drawing.Point(0, 0);
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(1290, 33);
            this.mnuAdmin.TabIndex = 2;
            this.mnuAdmin.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(64, 29);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 850);
            this.Controls.Add(this.btnYearlyRevenue);
            this.Controls.Add(this.btnListDailyRent);
            this.Controls.Add(this.mnuAdmin);
            this.MainMenuStrip = this.mnuAdmin;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.mnuAdmin.ResumeLayout(false);
            this.mnuAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListDailyRent;
        private System.Windows.Forms.Button btnYearlyRevenue;
        private System.Windows.Forms.MenuStrip mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}