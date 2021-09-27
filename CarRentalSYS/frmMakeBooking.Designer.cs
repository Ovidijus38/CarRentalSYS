
namespace CarRentalSYS
{
    partial class frmMakeBooking
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
            this.classCodelbl = new System.Windows.Forms.Label();
            this.collectDateAndTimelbl = new System.Windows.Forms.Label();
            this.returnDateAndTimelbl = new System.Windows.Forms.Label();
            this.cboClasses = new System.Windows.Forms.ComboBox();
            this.grpCars = new System.Windows.Forms.GroupBox();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.PickupTimelbl = new System.Windows.Forms.Label();
            this.DropOffTimelbl = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.labelCustomerIdValue = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.btnSearchCustByLicNoAndCountryCode = new System.Windows.Forms.Button();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtLicenceNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.makeBookingbtn = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblLicenceNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.cboPickUpTime = new System.Windows.Forms.ComboBox();
            this.cboDropTime = new System.Windows.Forms.ComboBox();
            this.mnuMakeBooking = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxBookingPrice = new System.Windows.Forms.GroupBox();
            this.labelBookingPrice = new System.Windows.Forms.Label();
            this.grpCars.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.mnuMakeBooking.SuspendLayout();
            this.groupBoxBookingPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // classCodelbl
            // 
            this.classCodelbl.AutoSize = true;
            this.classCodelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCodelbl.Location = new System.Drawing.Point(58, 42);
            this.classCodelbl.Name = "classCodelbl";
            this.classCodelbl.Size = new System.Drawing.Size(106, 20);
            this.classCodelbl.TabIndex = 0;
            this.classCodelbl.Text = "Class Code";
            // 
            // collectDateAndTimelbl
            // 
            this.collectDateAndTimelbl.AutoSize = true;
            this.collectDateAndTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectDateAndTimelbl.Location = new System.Drawing.Point(58, 102);
            this.collectDateAndTimelbl.Name = "collectDateAndTimelbl";
            this.collectDateAndTimelbl.Size = new System.Drawing.Size(111, 20);
            this.collectDateAndTimelbl.TabIndex = 1;
            this.collectDateAndTimelbl.Text = "Pickup Date";
            // 
            // returnDateAndTimelbl
            // 
            this.returnDateAndTimelbl.AutoSize = true;
            this.returnDateAndTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateAndTimelbl.Location = new System.Drawing.Point(58, 157);
            this.returnDateAndTimelbl.Name = "returnDateAndTimelbl";
            this.returnDateAndTimelbl.Size = new System.Drawing.Size(111, 20);
            this.returnDateAndTimelbl.TabIndex = 2;
            this.returnDateAndTimelbl.Text = "Return Date";
            // 
            // cboClasses
            // 
            this.cboClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClasses.FormattingEnabled = true;
            this.cboClasses.Location = new System.Drawing.Point(194, 42);
            this.cboClasses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboClasses.Name = "cboClasses";
            this.cboClasses.Size = new System.Drawing.Size(176, 28);
            this.cboClasses.TabIndex = 3;
            // 
            // grpCars
            // 
            this.grpCars.Controls.Add(this.lstCars);
            this.grpCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCars.Location = new System.Drawing.Point(61, 291);
            this.grpCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCars.Name = "grpCars";
            this.grpCars.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCars.Size = new System.Drawing.Size(536, 186);
            this.grpCars.TabIndex = 4;
            this.grpCars.TabStop = false;
            this.grpCars.Text = "Select Car";
            this.grpCars.Visible = false;
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 20;
            this.lstCars.Location = new System.Drawing.Point(52, 31);
            this.lstCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(464, 104);
            this.lstCars.TabIndex = 0;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // PickupTimelbl
            // 
            this.PickupTimelbl.AutoSize = true;
            this.PickupTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickupTimelbl.Location = new System.Drawing.Point(593, 102);
            this.PickupTimelbl.Name = "PickupTimelbl";
            this.PickupTimelbl.Size = new System.Drawing.Size(112, 20);
            this.PickupTimelbl.TabIndex = 5;
            this.PickupTimelbl.Text = "Pickup Time";
            // 
            // DropOffTimelbl
            // 
            this.DropOffTimelbl.AutoSize = true;
            this.DropOffTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropOffTimelbl.Location = new System.Drawing.Point(593, 157);
            this.DropOffTimelbl.Name = "DropOffTimelbl";
            this.DropOffTimelbl.Size = new System.Drawing.Size(129, 20);
            this.DropOffTimelbl.TabIndex = 6;
            this.DropOffTimelbl.Text = "Drop Off Time";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(189, 225);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(258, 38);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.labelCustomerIdValue);
            this.grpCustomer.Controls.Add(this.labelCustomerID);
            this.grpCustomer.Controls.Add(this.btnSearchCustByLicNoAndCountryCode);
            this.grpCustomer.Controls.Add(this.txtPostCode);
            this.grpCustomer.Controls.Add(this.lblPostCode);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.txtPhoneNo);
            this.grpCustomer.Controls.Add(this.txtEmail);
            this.grpCustomer.Controls.Add(this.txtCountryCode);
            this.grpCustomer.Controls.Add(this.txtLicenceNo);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.btnAddCustomer);
            this.grpCustomer.Controls.Add(this.makeBookingbtn);
            this.grpCustomer.Controls.Add(this.lblAddress);
            this.grpCustomer.Controls.Add(this.lblPhoneNo);
            this.grpCustomer.Controls.Add(this.lblEmail);
            this.grpCustomer.Controls.Add(this.lblDateOfBirth);
            this.grpCustomer.Controls.Add(this.lblLicenceNo);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(685, 208);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomer.Size = new System.Drawing.Size(615, 568);
            this.grpCustomer.TabIndex = 8;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            this.grpCustomer.Visible = false;
            // 
            // labelCustomerIdValue
            // 
            this.labelCustomerIdValue.AutoSize = true;
            this.labelCustomerIdValue.Location = new System.Drawing.Point(479, 459);
            this.labelCustomerIdValue.Name = "labelCustomerIdValue";
            this.labelCustomerIdValue.Size = new System.Drawing.Size(0, 20);
            this.labelCustomerIdValue.TabIndex = 18;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(451, 418);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(121, 20);
            this.labelCustomerID.TabIndex = 17;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // btnSearchCustByLicNoAndCountryCode
            // 
            this.btnSearchCustByLicNoAndCountryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustByLicNoAndCountryCode.Location = new System.Drawing.Point(74, 399);
            this.btnSearchCustByLicNoAndCountryCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCustByLicNoAndCountryCode.Name = "btnSearchCustByLicNoAndCountryCode";
            this.btnSearchCustByLicNoAndCountryCode.Size = new System.Drawing.Size(368, 58);
            this.btnSearchCustByLicNoAndCountryCode.TabIndex = 16;
            this.btnSearchCustByLicNoAndCountryCode.Text = "Search customer by Licence No and Country code";
            this.btnSearchCustByLicNoAndCountryCode.UseVisualStyleBackColor = true;
            this.btnSearchCustByLicNoAndCountryCode.Click += new System.EventHandler(this.btnSearchCustByLicNoAndCountryCode_Click);
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(483, 258);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(89, 26);
            this.txtPostCode.TabIndex = 15;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(65, 261);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(93, 20);
            this.lblPostCode.TabIndex = 14;
            this.lblPostCode.Text = "Post code";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(256, 208);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(316, 26);
            this.txtAddress.TabIndex = 13;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(255, 304);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(317, 26);
            this.txtPhoneNo.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 358);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(483, 162);
            this.txtCountryCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(89, 26);
            this.txtCountryCode.TabIndex = 10;
            // 
            // txtLicenceNo
            // 
            this.txtLicenceNo.Location = new System.Drawing.Point(255, 114);
            this.txtLicenceNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLicenceNo.Name = "txtLicenceNo";
            this.txtLicenceNo.Size = new System.Drawing.Size(317, 26);
            this.txtLicenceNo.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(255, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(317, 26);
            this.txtName.TabIndex = 8;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(281, 471);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(161, 58);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // makeBookingbtn
            // 
            this.makeBookingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBookingbtn.Location = new System.Drawing.Point(69, 471);
            this.makeBookingbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeBookingbtn.Name = "makeBookingbtn";
            this.makeBookingbtn.Size = new System.Drawing.Size(160, 58);
            this.makeBookingbtn.TabIndex = 6;
            this.makeBookingbtn.Text = "Make Booking";
            this.makeBookingbtn.UseVisualStyleBackColor = true;
            this.makeBookingbtn.Click += new System.EventHandler(this.makeBookingbtn_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(65, 211);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(69, 304);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(84, 20);
            this.lblPhoneNo.TabIndex = 4;
            this.lblPhoneNo.Text = "PhoneNo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(70, 358);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(65, 162);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(210, 20);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "Country code (2 letters)";
            // 
            // lblLicenceNo
            // 
            this.lblLicenceNo.AutoSize = true;
            this.lblLicenceNo.Location = new System.Drawing.Point(69, 114);
            this.lblLicenceNo.Name = "lblLicenceNo";
            this.lblLicenceNo.Size = new System.Drawing.Size(104, 20);
            this.lblLicenceNo.TabIndex = 1;
            this.lblLicenceNo.Text = "Licence No";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Location = new System.Drawing.Point(194, 102);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(352, 26);
            this.dtpDateFrom.TabIndex = 9;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Location = new System.Drawing.Point(194, 157);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(352, 26);
            this.dtpDateTo.TabIndex = 10;
            // 
            // cboPickUpTime
            // 
            this.cboPickUpTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPickUpTime.FormattingEnabled = true;
            this.cboPickUpTime.Location = new System.Drawing.Point(804, 99);
            this.cboPickUpTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPickUpTime.Name = "cboPickUpTime";
            this.cboPickUpTime.Size = new System.Drawing.Size(108, 24);
            this.cboPickUpTime.TabIndex = 11;
            // 
            // cboDropTime
            // 
            this.cboDropTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDropTime.FormattingEnabled = true;
            this.cboDropTime.Location = new System.Drawing.Point(804, 154);
            this.cboDropTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDropTime.Name = "cboDropTime";
            this.cboDropTime.Size = new System.Drawing.Size(108, 24);
            this.cboDropTime.TabIndex = 12;
            // 
            // mnuMakeBooking
            // 
            this.mnuMakeBooking.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMakeBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuReturn});
            this.mnuMakeBooking.Location = new System.Drawing.Point(0, 0);
            this.mnuMakeBooking.Name = "mnuMakeBooking";
            this.mnuMakeBooking.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMakeBooking.Size = new System.Drawing.Size(1323, 28);
            this.mnuMakeBooking.TabIndex = 13;
            this.mnuMakeBooking.Text = "menuStrip1";
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
            // groupBoxBookingPrice
            // 
            this.groupBoxBookingPrice.Controls.Add(this.labelBookingPrice);
            this.groupBoxBookingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBookingPrice.Location = new System.Drawing.Point(61, 505);
            this.groupBoxBookingPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBookingPrice.Name = "groupBoxBookingPrice";
            this.groupBoxBookingPrice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBookingPrice.Size = new System.Drawing.Size(536, 200);
            this.groupBoxBookingPrice.TabIndex = 14;
            this.groupBoxBookingPrice.TabStop = false;
            this.groupBoxBookingPrice.Text = "Booking Price";
            this.groupBoxBookingPrice.Visible = false;
            // 
            // labelBookingPrice
            // 
            this.labelBookingPrice.AutoSize = true;
            this.labelBookingPrice.Location = new System.Drawing.Point(44, 45);
            this.labelBookingPrice.Name = "labelBookingPrice";
            this.labelBookingPrice.Size = new System.Drawing.Size(0, 20);
            this.labelBookingPrice.TabIndex = 0;
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 833);
            this.Controls.Add(this.groupBoxBookingPrice);
            this.Controls.Add(this.cboDropTime);
            this.Controls.Add(this.cboPickUpTime);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.DropOffTimelbl);
            this.Controls.Add(this.PickupTimelbl);
            this.Controls.Add(this.grpCars);
            this.Controls.Add(this.cboClasses);
            this.Controls.Add(this.returnDateAndTimelbl);
            this.Controls.Add(this.collectDateAndTimelbl);
            this.Controls.Add(this.classCodelbl);
            this.Controls.Add(this.mnuMakeBooking);
            this.MainMenuStrip = this.mnuMakeBooking;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMakeBooking";
            this.Text = "frmMakeBooking";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            this.grpCars.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.mnuMakeBooking.ResumeLayout(false);
            this.mnuMakeBooking.PerformLayout();
            this.groupBoxBookingPrice.ResumeLayout(false);
            this.groupBoxBookingPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classCodelbl;
        private System.Windows.Forms.Label collectDateAndTimelbl;
        private System.Windows.Forms.Label returnDateAndTimelbl;
        private System.Windows.Forms.ComboBox cboClasses;
        private System.Windows.Forms.GroupBox grpCars;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Label PickupTimelbl;
        private System.Windows.Forms.Label DropOffTimelbl;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button makeBookingbtn;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblLicenceNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.ComboBox cboPickUpTime;
        private System.Windows.Forms.ComboBox cboDropTime;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.TextBox txtLicenceNo;
        private System.Windows.Forms.MenuStrip mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuReturn;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Button btnSearchCustByLicNoAndCountryCode;
        private System.Windows.Forms.GroupBox groupBoxBookingPrice;
        private System.Windows.Forms.Label labelBookingPrice;
        private System.Windows.Forms.Label labelCustomerIdValue;
        private System.Windows.Forms.Label labelCustomerID;
    }
}