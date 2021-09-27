
namespace CarRentalSYS
{
    partial class frmAddCarClass
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
            this.ClassCodelbl = new System.Windows.Forms.Label();
            this.Desclbl = new System.Windows.Forms.Label();
            this.ratelbl = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.AddCarClassbtn = new System.Windows.Forms.Button();
            this.mnuAddCarClass = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labelRedAsterisk1 = new System.Windows.Forms.Label();
            this.labelRedAsterisk2 = new System.Windows.Forms.Label();
            this.labelRedAsterisk3 = new System.Windows.Forms.Label();
            this.mnuAddCarClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassCodelbl
            // 
            this.ClassCodelbl.AutoSize = true;
            this.ClassCodelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCodelbl.Location = new System.Drawing.Point(46, 68);
            this.ClassCodelbl.Name = "ClassCodelbl";
            this.ClassCodelbl.Size = new System.Drawing.Size(196, 20);
            this.ClassCodelbl.TabIndex = 0;
            this.ClassCodelbl.Text = "Class Code (2 letters)";
            // 
            // Desclbl
            // 
            this.Desclbl.AutoSize = true;
            this.Desclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desclbl.Location = new System.Drawing.Point(46, 134);
            this.Desclbl.Name = "Desclbl";
            this.Desclbl.Size = new System.Drawing.Size(300, 20);
            this.Desclbl.TabIndex = 1;
            this.Desclbl.Text = "Description (up to 200 characters)";
            // 
            // ratelbl
            // 
            this.ratelbl.AutoSize = true;
            this.ratelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratelbl.Location = new System.Drawing.Point(46, 201);
            this.ratelbl.Name = "ratelbl";
            this.ratelbl.Size = new System.Drawing.Size(187, 20);
            this.ratelbl.TabIndex = 2;
            this.ratelbl.Text = "Rate (up to 999.99 €)";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(413, 113);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(538, 62);
            this.txtDescription.TabIndex = 4;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(413, 202);
            this.txtRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(121, 22);
            this.txtRate.TabIndex = 5;
            // 
            // AddCarClassbtn
            // 
            this.AddCarClassbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarClassbtn.Location = new System.Drawing.Point(413, 279);
            this.AddCarClassbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCarClassbtn.Name = "AddCarClassbtn";
            this.AddCarClassbtn.Size = new System.Drawing.Size(194, 40);
            this.AddCarClassbtn.TabIndex = 6;
            this.AddCarClassbtn.Text = "Add Car Class";
            this.AddCarClassbtn.UseVisualStyleBackColor = true;
            this.AddCarClassbtn.Click += new System.EventHandler(this.AddCarClassbtn_Click);
            // 
            // mnuAddCarClass
            // 
            this.mnuAddCarClass.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuAddCarClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuReturn});
            this.mnuAddCarClass.Location = new System.Drawing.Point(0, 0);
            this.mnuAddCarClass.Name = "mnuAddCarClass";
            this.mnuAddCarClass.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuAddCarClass.Size = new System.Drawing.Size(982, 28);
            this.mnuAddCarClass.TabIndex = 7;
            this.mnuAddCarClass.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuReturn
            // 
            this.mnuReturn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuReturn.Name = "mnuReturn";
            this.mnuReturn.Size = new System.Drawing.Size(66, 24);
            this.mnuReturn.Text = "Return";
            this.mnuReturn.Click += new System.EventHandler(this.mnuReturn_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(413, 66);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCode.MaxLength = 2;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(71, 22);
            this.txtCode.TabIndex = 8;
            // 
            // labelRedAsterisk1
            // 
            this.labelRedAsterisk1.AutoSize = true;
            this.labelRedAsterisk1.ForeColor = System.Drawing.Color.Red;
            this.labelRedAsterisk1.Location = new System.Drawing.Point(264, 68);
            this.labelRedAsterisk1.Name = "labelRedAsterisk1";
            this.labelRedAsterisk1.Size = new System.Drawing.Size(13, 17);
            this.labelRedAsterisk1.TabIndex = 9;
            this.labelRedAsterisk1.Text = "*";
            // 
            // labelRedAsterisk2
            // 
            this.labelRedAsterisk2.AutoSize = true;
            this.labelRedAsterisk2.ForeColor = System.Drawing.Color.Red;
            this.labelRedAsterisk2.Location = new System.Drawing.Point(274, 202);
            this.labelRedAsterisk2.Name = "labelRedAsterisk2";
            this.labelRedAsterisk2.Size = new System.Drawing.Size(13, 17);
            this.labelRedAsterisk2.TabIndex = 10;
            this.labelRedAsterisk2.Text = "*";
            // 
            // labelRedAsterisk3
            // 
            this.labelRedAsterisk3.AutoSize = true;
            this.labelRedAsterisk3.ForeColor = System.Drawing.Color.Red;
            this.labelRedAsterisk3.Location = new System.Drawing.Point(385, 134);
            this.labelRedAsterisk3.Name = "labelRedAsterisk3";
            this.labelRedAsterisk3.Size = new System.Drawing.Size(13, 17);
            this.labelRedAsterisk3.TabIndex = 11;
            this.labelRedAsterisk3.Text = "*";
            // 
            // frmAddCarClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 632);
            this.Controls.Add(this.labelRedAsterisk3);
            this.Controls.Add(this.labelRedAsterisk2);
            this.Controls.Add(this.labelRedAsterisk1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.AddCarClassbtn);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.ratelbl);
            this.Controls.Add(this.Desclbl);
            this.Controls.Add(this.ClassCodelbl);
            this.Controls.Add(this.mnuAddCarClass);
            this.MainMenuStrip = this.mnuAddCarClass;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddCarClass";
            this.Text = "frmAddCarClass";
            this.Load += new System.EventHandler(this.frmAddCarClass_Load);
            this.mnuAddCarClass.ResumeLayout(false);
            this.mnuAddCarClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassCodelbl;
        private System.Windows.Forms.Label Desclbl;
        private System.Windows.Forms.Label ratelbl;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button AddCarClassbtn;
        private System.Windows.Forms.MenuStrip mnuAddCarClass;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuReturn;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label labelRedAsterisk1;
        private System.Windows.Forms.Label labelRedAsterisk2;
        private System.Windows.Forms.Label labelRedAsterisk3;
    }
}