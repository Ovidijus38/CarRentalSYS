
namespace CarRentalSYS
{
    partial class frmAddCar
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
            this.regNolbl = new System.Windows.Forms.Label();
            this.classCodelbl = new System.Windows.Forms.Label();
            this.makelbl = new System.Windows.Forms.Label();
            this.modellbl = new System.Windows.Forms.Label();
            this.transmissionlbl = new System.Windows.Forms.Label();
            this.fuelTypelbl = new System.Windows.Forms.Label();
            this.noofdoorslbl = new System.Windows.Forms.Label();
            this.regNotxt = new System.Windows.Forms.TextBox();
            this.maketxt = new System.Windows.Forms.TextBox();
            this.modeltxt = new System.Windows.Forms.TextBox();
            this.AddCarbtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboClassCode = new System.Windows.Forms.ComboBox();
            this.cboTransmission = new System.Windows.Forms.ComboBox();
            this.cboFuelType = new System.Windows.Forms.ComboBox();
            this.mnuAddCar = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.cboNoOfDoors = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.mnuAddCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // regNolbl
            // 
            this.regNolbl.AutoSize = true;
            this.regNolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNolbl.Location = new System.Drawing.Point(171, 110);
            this.regNolbl.Name = "regNolbl";
            this.regNolbl.Size = new System.Drawing.Size(65, 20);
            this.regNolbl.TabIndex = 0;
            this.regNolbl.Text = "RegNo";
            // 
            // classCodelbl
            // 
            this.classCodelbl.AutoSize = true;
            this.classCodelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCodelbl.Location = new System.Drawing.Point(171, 165);
            this.classCodelbl.Name = "classCodelbl";
            this.classCodelbl.Size = new System.Drawing.Size(106, 20);
            this.classCodelbl.TabIndex = 1;
            this.classCodelbl.Text = "Class Code";
            // 
            // makelbl
            // 
            this.makelbl.AutoSize = true;
            this.makelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makelbl.Location = new System.Drawing.Point(171, 230);
            this.makelbl.Name = "makelbl";
            this.makelbl.Size = new System.Drawing.Size(53, 20);
            this.makelbl.TabIndex = 2;
            this.makelbl.Text = "Make";
            // 
            // modellbl
            // 
            this.modellbl.AutoSize = true;
            this.modellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modellbl.Location = new System.Drawing.Point(171, 278);
            this.modellbl.Name = "modellbl";
            this.modellbl.Size = new System.Drawing.Size(59, 20);
            this.modellbl.TabIndex = 3;
            this.modellbl.Text = "Model";
            // 
            // transmissionlbl
            // 
            this.transmissionlbl.AutoSize = true;
            this.transmissionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionlbl.Location = new System.Drawing.Point(171, 351);
            this.transmissionlbl.Name = "transmissionlbl";
            this.transmissionlbl.Size = new System.Drawing.Size(122, 20);
            this.transmissionlbl.TabIndex = 4;
            this.transmissionlbl.Text = "Transmission";
            this.transmissionlbl.Click += new System.EventHandler(this.transmissionlbl_Click);
            // 
            // fuelTypelbl
            // 
            this.fuelTypelbl.AutoSize = true;
            this.fuelTypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelTypelbl.Location = new System.Drawing.Point(171, 423);
            this.fuelTypelbl.Name = "fuelTypelbl";
            this.fuelTypelbl.Size = new System.Drawing.Size(91, 20);
            this.fuelTypelbl.TabIndex = 5;
            this.fuelTypelbl.Text = "Fuel Type";
            // 
            // noofdoorslbl
            // 
            this.noofdoorslbl.AutoSize = true;
            this.noofdoorslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofdoorslbl.Location = new System.Drawing.Point(171, 486);
            this.noofdoorslbl.Name = "noofdoorslbl";
            this.noofdoorslbl.Size = new System.Drawing.Size(107, 20);
            this.noofdoorslbl.TabIndex = 6;
            this.noofdoorslbl.Text = "No of doors";
            // 
            // regNotxt
            // 
            this.regNotxt.Location = new System.Drawing.Point(343, 109);
            this.regNotxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regNotxt.Name = "regNotxt";
            this.regNotxt.Size = new System.Drawing.Size(135, 22);
            this.regNotxt.TabIndex = 7;
            this.regNotxt.TextChanged += new System.EventHandler(this.regNotxt_TextChanged);
            // 
            // maketxt
            // 
            this.maketxt.Location = new System.Drawing.Point(343, 230);
            this.maketxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maketxt.Name = "maketxt";
            this.maketxt.Size = new System.Drawing.Size(135, 22);
            this.maketxt.TabIndex = 9;
            // 
            // modeltxt
            // 
            this.modeltxt.Location = new System.Drawing.Point(343, 278);
            this.modeltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(135, 22);
            this.modeltxt.TabIndex = 10;
            // 
            // AddCarbtn
            // 
            this.AddCarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarbtn.Location = new System.Drawing.Point(456, 558);
            this.AddCarbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCarbtn.Name = "AddCarbtn";
            this.AddCarbtn.Size = new System.Drawing.Size(159, 55);
            this.AddCarbtn.TabIndex = 14;
            this.AddCarbtn.Text = "Add Car";
            this.AddCarbtn.UseVisualStyleBackColor = true;
            this.AddCarbtn.Click += new System.EventHandler(this.AddCarbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboClassCode
            // 
            this.cboClassCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassCode.FormattingEnabled = true;
            this.cboClassCode.Location = new System.Drawing.Point(343, 165);
            this.cboClassCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboClassCode.Name = "cboClassCode";
            this.cboClassCode.Size = new System.Drawing.Size(135, 24);
            this.cboClassCode.TabIndex = 15;
            this.cboClassCode.SelectedIndexChanged += new System.EventHandler(this.cboclassCode_SelectedIndexChanged);
            // 
            // cboTransmission
            // 
            this.cboTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransmission.FormattingEnabled = true;
            this.cboTransmission.Location = new System.Drawing.Point(343, 351);
            this.cboTransmission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTransmission.Name = "cboTransmission";
            this.cboTransmission.Size = new System.Drawing.Size(135, 24);
            this.cboTransmission.TabIndex = 16;
            this.cboTransmission.SelectedIndexChanged += new System.EventHandler(this.cboTransmision_SelectedIndexChanged);
            // 
            // cboFuelType
            // 
            this.cboFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuelType.FormattingEnabled = true;
            this.cboFuelType.Location = new System.Drawing.Point(343, 423);
            this.cboFuelType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFuelType.Name = "cboFuelType";
            this.cboFuelType.Size = new System.Drawing.Size(135, 24);
            this.cboFuelType.TabIndex = 17;
            // 
            // mnuAddCar
            // 
            this.mnuAddCar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuAddCar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuReturn});
            this.mnuAddCar.Location = new System.Drawing.Point(0, 0);
            this.mnuAddCar.Name = "mnuAddCar";
            this.mnuAddCar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuAddCar.Size = new System.Drawing.Size(1076, 28);
            this.mnuAddCar.TabIndex = 18;
            this.mnuAddCar.Text = "menuStrip1";
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
            // cboNoOfDoors
            // 
            this.cboNoOfDoors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNoOfDoors.FormattingEnabled = true;
            this.cboNoOfDoors.Location = new System.Drawing.Point(343, 482);
            this.cboNoOfDoors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNoOfDoors.Name = "cboNoOfDoors";
            this.cboNoOfDoors.Size = new System.Drawing.Size(135, 24);
            this.cboNoOfDoors.TabIndex = 19;
            // 
            // frmAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 651);
            this.Controls.Add(this.cboNoOfDoors);
            this.Controls.Add(this.cboFuelType);
            this.Controls.Add(this.cboTransmission);
            this.Controls.Add(this.cboClassCode);
            this.Controls.Add(this.AddCarbtn);
            this.Controls.Add(this.modeltxt);
            this.Controls.Add(this.maketxt);
            this.Controls.Add(this.regNotxt);
            this.Controls.Add(this.noofdoorslbl);
            this.Controls.Add(this.fuelTypelbl);
            this.Controls.Add(this.transmissionlbl);
            this.Controls.Add(this.modellbl);
            this.Controls.Add(this.makelbl);
            this.Controls.Add(this.classCodelbl);
            this.Controls.Add(this.regNolbl);
            this.Controls.Add(this.mnuAddCar);
            this.MainMenuStrip = this.mnuAddCar;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddCar";
            this.Text = "frmAddCar";
            this.Load += new System.EventHandler(this.regNotxt_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.mnuAddCar.ResumeLayout(false);
            this.mnuAddCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regNolbl;
        private System.Windows.Forms.Label classCodelbl;
        private System.Windows.Forms.Label makelbl;
        private System.Windows.Forms.Label modellbl;
        private System.Windows.Forms.Label transmissionlbl;
        private System.Windows.Forms.Label fuelTypelbl;
        private System.Windows.Forms.Label noofdoorslbl;
        private System.Windows.Forms.TextBox regNotxt;
        private System.Windows.Forms.TextBox maketxt;
        private System.Windows.Forms.TextBox modeltxt;
        private System.Windows.Forms.Button AddCarbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboFuelType;
        private System.Windows.Forms.ComboBox cboTransmission;
        private System.Windows.Forms.ComboBox cboClassCode;
        private System.Windows.Forms.MenuStrip mnuAddCar;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuReturn;
        private System.Windows.Forms.ComboBox cboNoOfDoors;
    }
}