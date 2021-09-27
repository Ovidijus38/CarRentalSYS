
namespace CarRentalSYS
{
    partial class frmRemoveCar
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
            this.components = new System.ComponentModel.Container();
            this.mnuUpdateCar = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCheckReg = new System.Windows.Forms.Button();
            this.grpCarInfo = new System.Windows.Forms.GroupBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.labelRegNumberValue = new System.Windows.Forms.Label();
            this.modeltxt = new System.Windows.Forms.TextBox();
            this.maketxt = new System.Windows.Forms.TextBox();
            this.cboNoOfDoors = new System.Windows.Forms.ComboBox();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.cboTransmission = new System.Windows.Forms.ComboBox();
            this.cboClassCode = new System.Windows.Forms.ComboBox();
            this.btnTakeOutOfService = new System.Windows.Forms.Button();
            this.lblnoOfDoors = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblClassCode = new System.Windows.Forms.Label();
            this.glblRegNo = new System.Windows.Forms.Label();
            this.cboRegNo = new System.Windows.Forms.ComboBox();
            this.mnuUpdateCar.SuspendLayout();
            this.grpCarInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateCar
            // 
            this.mnuUpdateCar.BackColor = System.Drawing.SystemColors.Highlight;
            this.mnuUpdateCar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuUpdateCar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuReturn});
            this.mnuUpdateCar.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateCar.Name = "mnuUpdateCar";
            this.mnuUpdateCar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuUpdateCar.Size = new System.Drawing.Size(910, 25);
            this.mnuUpdateCar.TabIndex = 0;
            this.mnuUpdateCar.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(62, 21);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuReturn
            // 
            this.mnuReturn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuReturn.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReturn.Name = "mnuReturn";
            this.mnuReturn.Size = new System.Drawing.Size(82, 21);
            this.mnuReturn.Text = "Return";
            this.mnuReturn.Click += new System.EventHandler(this.mnuReturn_Click);
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.Location = new System.Drawing.Point(11, 51);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(113, 20);
            this.lblRegNo.TabIndex = 1;
            this.lblRegNo.Text = "Reg Number";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnCheckReg
            // 
            this.btnCheckReg.Location = new System.Drawing.Point(157, 91);
            this.btnCheckReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckReg.Name = "btnCheckReg";
            this.btnCheckReg.Size = new System.Drawing.Size(180, 44);
            this.btnCheckReg.TabIndex = 3;
            this.btnCheckReg.Text = "Check Car";
            this.btnCheckReg.UseVisualStyleBackColor = true;
            this.btnCheckReg.Click += new System.EventHandler(this.btnCheckReg_Click);
            // 
            // grpCarInfo
            // 
            this.grpCarInfo.Controls.Add(this.lblAvailability);
            this.grpCarInfo.Controls.Add(this.labelRegNumberValue);
            this.grpCarInfo.Controls.Add(this.modeltxt);
            this.grpCarInfo.Controls.Add(this.maketxt);
            this.grpCarInfo.Controls.Add(this.cboNoOfDoors);
            this.grpCarInfo.Controls.Add(this.cboFuel);
            this.grpCarInfo.Controls.Add(this.cboTransmission);
            this.grpCarInfo.Controls.Add(this.cboClassCode);
            this.grpCarInfo.Controls.Add(this.btnTakeOutOfService);
            this.grpCarInfo.Controls.Add(this.lblnoOfDoors);
            this.grpCarInfo.Controls.Add(this.lblFuel);
            this.grpCarInfo.Controls.Add(this.lblTransmission);
            this.grpCarInfo.Controls.Add(this.lblModel);
            this.grpCarInfo.Controls.Add(this.lblMake);
            this.grpCarInfo.Controls.Add(this.lblClassCode);
            this.grpCarInfo.Controls.Add(this.glblRegNo);
            this.grpCarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarInfo.Location = new System.Drawing.Point(59, 164);
            this.grpCarInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCarInfo.Name = "grpCarInfo";
            this.grpCarInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCarInfo.Size = new System.Drawing.Size(796, 426);
            this.grpCarInfo.TabIndex = 4;
            this.grpCarInfo.TabStop = false;
            this.grpCarInfo.Text = "Car Info";
            this.grpCarInfo.Visible = false;
            this.grpCarInfo.Enter += new System.EventHandler(this.grpCarInfo_Enter);
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(410, 314);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(0, 20);
            this.lblAvailability.TabIndex = 20;
            this.lblAvailability.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRegNumberValue
            // 
            this.labelRegNumberValue.AutoSize = true;
            this.labelRegNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegNumberValue.Location = new System.Drawing.Point(232, 42);
            this.labelRegNumberValue.Name = "labelRegNumberValue";
            this.labelRegNumberValue.Size = new System.Drawing.Size(277, 20);
            this.labelRegNumberValue.TabIndex = 19;
            this.labelRegNumberValue.Text = "Enter Reg Number in upper part";
            // 
            // modeltxt
            // 
            this.modeltxt.Enabled = false;
            this.modeltxt.Location = new System.Drawing.Point(236, 200);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(181, 26);
            this.modeltxt.TabIndex = 18;
            // 
            // maketxt
            // 
            this.maketxt.Enabled = false;
            this.maketxt.Location = new System.Drawing.Point(236, 148);
            this.maketxt.Name = "maketxt";
            this.maketxt.Size = new System.Drawing.Size(181, 26);
            this.maketxt.TabIndex = 17;
            // 
            // cboNoOfDoors
            // 
            this.cboNoOfDoors.Enabled = false;
            this.cboNoOfDoors.FormattingEnabled = true;
            this.cboNoOfDoors.Location = new System.Drawing.Point(236, 368);
            this.cboNoOfDoors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNoOfDoors.Name = "cboNoOfDoors";
            this.cboNoOfDoors.Size = new System.Drawing.Size(108, 28);
            this.cboNoOfDoors.TabIndex = 16;
            // 
            // cboFuel
            // 
            this.cboFuel.Enabled = false;
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Location = new System.Drawing.Point(236, 313);
            this.cboFuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(108, 28);
            this.cboFuel.TabIndex = 15;
            // 
            // cboTransmission
            // 
            this.cboTransmission.Enabled = false;
            this.cboTransmission.FormattingEnabled = true;
            this.cboTransmission.Location = new System.Drawing.Point(236, 254);
            this.cboTransmission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTransmission.Name = "cboTransmission";
            this.cboTransmission.Size = new System.Drawing.Size(181, 28);
            this.cboTransmission.TabIndex = 14;
            // 
            // cboClassCode
            // 
            this.cboClassCode.Enabled = false;
            this.cboClassCode.FormattingEnabled = true;
            this.cboClassCode.Location = new System.Drawing.Point(236, 99);
            this.cboClassCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboClassCode.Name = "cboClassCode";
            this.cboClassCode.Size = new System.Drawing.Size(181, 28);
            this.cboClassCode.TabIndex = 11;
            // 
            // btnTakeOutOfService
            // 
            this.btnTakeOutOfService.Location = new System.Drawing.Point(406, 368);
            this.btnTakeOutOfService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeOutOfService.Name = "btnTakeOutOfService";
            this.btnTakeOutOfService.Size = new System.Drawing.Size(343, 44);
            this.btnTakeOutOfService.TabIndex = 10;
            this.btnTakeOutOfService.Text = "Take Out Of Service";
            this.btnTakeOutOfService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTakeOutOfService.UseVisualStyleBackColor = true;
            this.btnTakeOutOfService.Click += new System.EventHandler(this.btnTakeOutOfService_Click);
            // 
            // lblnoOfDoors
            // 
            this.lblnoOfDoors.AutoSize = true;
            this.lblnoOfDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoOfDoors.Location = new System.Drawing.Point(94, 368);
            this.lblnoOfDoors.Name = "lblnoOfDoors";
            this.lblnoOfDoors.Size = new System.Drawing.Size(107, 20);
            this.lblnoOfDoors.TabIndex = 9;
            this.lblnoOfDoors.Text = "No of doors";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(94, 313);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(51, 20);
            this.lblFuel.TabIndex = 8;
            this.lblFuel.Text = "Fuel ";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmission.Location = new System.Drawing.Point(94, 257);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(122, 20);
            this.lblTransmission.TabIndex = 7;
            this.lblTransmission.Text = "Transmission";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(94, 203);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 20);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(94, 154);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(53, 20);
            this.lblMake.TabIndex = 5;
            this.lblMake.Text = "Make";
            // 
            // lblClassCode
            // 
            this.lblClassCode.AutoSize = true;
            this.lblClassCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassCode.Location = new System.Drawing.Point(94, 99);
            this.lblClassCode.Name = "lblClassCode";
            this.lblClassCode.Size = new System.Drawing.Size(106, 20);
            this.lblClassCode.TabIndex = 4;
            this.lblClassCode.Text = "Class Code";
            // 
            // glblRegNo
            // 
            this.glblRegNo.AutoSize = true;
            this.glblRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glblRegNo.Location = new System.Drawing.Point(94, 42);
            this.glblRegNo.Name = "glblRegNo";
            this.glblRegNo.Size = new System.Drawing.Size(113, 20);
            this.glblRegNo.TabIndex = 2;
            this.glblRegNo.Text = "Reg Number";
            // 
            // cboRegNo
            // 
            this.cboRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegNo.FormattingEnabled = true;
            this.cboRegNo.Location = new System.Drawing.Point(157, 51);
            this.cboRegNo.Name = "cboRegNo";
            this.cboRegNo.Size = new System.Drawing.Size(180, 24);
            this.cboRegNo.TabIndex = 5;
            // 
            // frmRemoveCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 701);
            this.Controls.Add(this.cboRegNo);
            this.Controls.Add(this.grpCarInfo);
            this.Controls.Add(this.btnCheckReg);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.mnuUpdateCar);
            this.MainMenuStrip = this.mnuUpdateCar;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRemoveCar";
            this.Text = "frmRemoveCar";
            this.Load += new System.EventHandler(this.frmRemoveCar_Load);
            this.mnuUpdateCar.ResumeLayout(false);
            this.mnuUpdateCar.PerformLayout();
            this.grpCarInfo.ResumeLayout(false);
            this.grpCarInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateCar;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuReturn;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCheckReg;
        private System.Windows.Forms.GroupBox grpCarInfo;
        private System.Windows.Forms.Label lblnoOfDoors;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblClassCode;
        private System.Windows.Forms.Label glblRegNo;
        private System.Windows.Forms.ComboBox cboNoOfDoors;
        private System.Windows.Forms.ComboBox cboFuel;
        private System.Windows.Forms.ComboBox cboTransmission;
        private System.Windows.Forms.ComboBox cboClassCode;
        private System.Windows.Forms.Button btnTakeOutOfService;
        private System.Windows.Forms.TextBox maketxt;
        private System.Windows.Forms.TextBox modeltxt;
        private System.Windows.Forms.Label labelRegNumberValue;
        private System.Windows.Forms.ComboBox cboRegNo;
        private System.Windows.Forms.Label lblAvailability;
    }
}