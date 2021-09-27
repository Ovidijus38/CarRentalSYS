
namespace CarRentalSYS
{
    partial class frmCars
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
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnAddCarClass = new System.Windows.Forms.Button();
            this.mnuCars = new System.Windows.Forms.MenuStrip();
            this.mnuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCars.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCar.Location = new System.Drawing.Point(24, 443);
            this.btnRemoveCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(230, 78);
            this.btnRemoveCar.TabIndex = 2;
            this.btnRemoveCar.Text = "Take Car Out of Service";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.Location = new System.Drawing.Point(24, 322);
            this.btnUpdateCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(230, 78);
            this.btnUpdateCar.TabIndex = 3;
            this.btnUpdateCar.Text = "Update Car";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(24, 200);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(230, 78);
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnAddCarClass
            // 
            this.btnAddCarClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarClass.Location = new System.Drawing.Point(24, 90);
            this.btnAddCarClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCarClass.Name = "btnAddCarClass";
            this.btnAddCarClass.Size = new System.Drawing.Size(230, 78);
            this.btnAddCarClass.TabIndex = 5;
            this.btnAddCarClass.Text = "Add Car Class";
            this.btnAddCarClass.UseVisualStyleBackColor = true;
            this.btnAddCarClass.Click += new System.EventHandler(this.btnAddCarClass_Click);
            // 
            // mnuCars
            // 
            this.mnuCars.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuCars.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReturn});
            this.mnuCars.Location = new System.Drawing.Point(0, 0);
            this.mnuCars.Name = "mnuCars";
            this.mnuCars.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuCars.Size = new System.Drawing.Size(1094, 28);
            this.mnuCars.TabIndex = 6;
            this.mnuCars.Text = "menuStrip1";
            // 
            // mnuReturn
            // 
            this.mnuReturn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuReturn.Name = "mnuReturn";
            this.mnuReturn.Size = new System.Drawing.Size(66, 24);
            this.mnuReturn.Text = "Return";
            this.mnuReturn.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 567);
            this.Controls.Add(this.btnAddCarClass);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.mnuCars);
            this.MainMenuStrip = this.mnuCars;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCars";
            this.Text = "frmCars";
            this.Load += new System.EventHandler(this.frmCars_Load);
            this.mnuCars.ResumeLayout(false);
            this.mnuCars.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnAddCarClass;
        private System.Windows.Forms.MenuStrip mnuCars;
        private System.Windows.Forms.ToolStripMenuItem mnuReturn;
    }
}