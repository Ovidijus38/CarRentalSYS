
namespace CarRentalSYS
{
    partial class frmBookings
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
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.btnCollectCar = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.mnuBookings = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnCar.Location = new System.Drawing.Point(12, 540);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(259, 97);
            this.btnReturnCar.TabIndex = 6;
            this.btnReturnCar.Text = "Return Car";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // btnCollectCar
            // 
            this.btnCollectCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectCar.Location = new System.Drawing.Point(12, 407);
            this.btnCollectCar.Name = "btnCollectCar";
            this.btnCollectCar.Size = new System.Drawing.Size(259, 97);
            this.btnCollectCar.TabIndex = 7;
            this.btnCollectCar.Text = "Collect Car";
            this.btnCollectCar.UseVisualStyleBackColor = true;
            this.btnCollectCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.Location = new System.Drawing.Point(12, 265);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(259, 97);
            this.btnCancelBooking.TabIndex = 8;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeBooking.Location = new System.Drawing.Point(12, 135);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(259, 97);
            this.btnMakeBooking.TabIndex = 9;
            this.btnMakeBooking.Text = "Make Booking";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            this.btnMakeBooking.Click += new System.EventHandler(this.btnMakeBooking_Click);
            // 
            // mnuBookings
            // 
            this.mnuBookings.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuBookings.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuBookings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuBookings.Location = new System.Drawing.Point(0, 0);
            this.mnuBookings.Name = "mnuBookings";
            this.mnuBookings.Size = new System.Drawing.Size(1207, 36);
            this.mnuBookings.TabIndex = 10;
            this.mnuBookings.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(79, 32);
            this.exitToolStripMenuItem.Text = "Return";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1207, 735);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnCollectCar);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.mnuBookings);
            this.MainMenuStrip = this.mnuBookings;
            this.Name = "frmBookings";
            this.Text = "frmBookings";
            this.Load += new System.EventHandler(this.frmBookings_Load);
            this.mnuBookings.ResumeLayout(false);
            this.mnuBookings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Button btnCollectCar;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.MenuStrip mnuBookings;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}