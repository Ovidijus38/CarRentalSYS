
namespace CarRentalSYS
{
    partial class frmCollectCar
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
            this.mnuCollectCar = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckBookings = new System.Windows.Forms.Button();
            this.grpBookingData = new System.Windows.Forms.GroupBox();
            this.comboBoxCollectTime = new System.Windows.Forms.ComboBox();
            this.labelCollectTime = new System.Windows.Forms.Label();
            this.dateTimePickerCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.labelCollectDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBookingStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBookingEndDateTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBookingStartDateTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCarModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarRegNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarMake = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCustomerPostCode = new System.Windows.Forms.TextBox();
            this.labelPostCode = new System.Windows.Forms.Label();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.textBoxCustomerCountryCode = new System.Windows.Forms.TextBox();
            this.labelCustomerCountryCode = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnCollectCar = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerLicenceNo = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblCustomerLicenceNo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.mnuCollectCar.SuspendLayout();
            this.grpBookingData.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCollectCar
            // 
            this.mnuCollectCar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuCollectCar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuReturn});
            this.mnuCollectCar.Location = new System.Drawing.Point(0, 0);
            this.mnuCollectCar.Name = "mnuCollectCar";
            this.mnuCollectCar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuCollectCar.Size = new System.Drawing.Size(1068, 28);
            this.mnuCollectCar.TabIndex = 0;
            this.mnuCollectCar.Text = "menuStrip1";
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
            // btnCheckBookings
            // 
            this.btnCheckBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBookings.ForeColor = System.Drawing.Color.Black;
            this.btnCheckBookings.Location = new System.Drawing.Point(389, 62);
            this.btnCheckBookings.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckBookings.Name = "btnCheckBookings";
            this.btnCheckBookings.Size = new System.Drawing.Size(199, 32);
            this.btnCheckBookings.TabIndex = 28;
            this.btnCheckBookings.Text = "Check Booking";
            this.btnCheckBookings.UseVisualStyleBackColor = true;
            this.btnCheckBookings.Click += new System.EventHandler(this.btnCheckBookings_Click);
            // 
            // grpBookingData
            // 
            this.grpBookingData.Controls.Add(this.textBoxCost);
            this.grpBookingData.Controls.Add(this.labelCost);
            this.grpBookingData.Controls.Add(this.comboBoxCollectTime);
            this.grpBookingData.Controls.Add(this.labelCollectTime);
            this.grpBookingData.Controls.Add(this.dateTimePickerCollectionDate);
            this.grpBookingData.Controls.Add(this.labelCollectDate);
            this.grpBookingData.Controls.Add(this.label8);
            this.grpBookingData.Controls.Add(this.textBoxBookingStatus);
            this.grpBookingData.Controls.Add(this.label7);
            this.grpBookingData.Controls.Add(this.textBoxBookingEndDateTime);
            this.grpBookingData.Controls.Add(this.label1);
            this.grpBookingData.Controls.Add(this.textBoxBookingStartDateTime);
            this.grpBookingData.Controls.Add(this.label2);
            this.grpBookingData.Controls.Add(this.label3);
            this.grpBookingData.Controls.Add(this.textBoxCarModel);
            this.grpBookingData.Controls.Add(this.label4);
            this.grpBookingData.Controls.Add(this.textBoxCarRegNo);
            this.grpBookingData.Controls.Add(this.label5);
            this.grpBookingData.Controls.Add(this.textBoxCarMake);
            this.grpBookingData.Controls.Add(this.label6);
            this.grpBookingData.Controls.Add(this.textBoxCustomerPostCode);
            this.grpBookingData.Controls.Add(this.labelPostCode);
            this.grpBookingData.Controls.Add(this.textBoxCustomerAddress);
            this.grpBookingData.Controls.Add(this.labelAddress);
            this.grpBookingData.Controls.Add(this.labelCustomer);
            this.grpBookingData.Controls.Add(this.textBoxCustomerCountryCode);
            this.grpBookingData.Controls.Add(this.labelCustomerCountryCode);
            this.grpBookingData.Controls.Add(this.txtCustomerName);
            this.grpBookingData.Controls.Add(this.btnCollectCar);
            this.grpBookingData.Controls.Add(this.lblCustomerName);
            this.grpBookingData.Controls.Add(this.txtCustomerLicenceNo);
            this.grpBookingData.Controls.Add(this.txtPhoneNo);
            this.grpBookingData.Controls.Add(this.lblCustomerLicenceNo);
            this.grpBookingData.Controls.Add(this.txtEmail);
            this.grpBookingData.Controls.Add(this.lblEmail);
            this.grpBookingData.Controls.Add(this.lblPhoneNo);
            this.grpBookingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookingData.Location = new System.Drawing.Point(52, 126);
            this.grpBookingData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBookingData.Name = "grpBookingData";
            this.grpBookingData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBookingData.Size = new System.Drawing.Size(967, 494);
            this.grpBookingData.TabIndex = 27;
            this.grpBookingData.TabStop = false;
            this.grpBookingData.Text = "Booking Data";
            this.grpBookingData.Visible = false;
            this.grpBookingData.Enter += new System.EventHandler(this.grpBookingData_Enter);
            // 
            // comboBoxCollectTime
            // 
            this.comboBoxCollectTime.FormattingEnabled = true;
            this.comboBoxCollectTime.Location = new System.Drawing.Point(628, 445);
            this.comboBoxCollectTime.Name = "comboBoxCollectTime";
            this.comboBoxCollectTime.Size = new System.Drawing.Size(99, 28);
            this.comboBoxCollectTime.TabIndex = 40;
            // 
            // labelCollectTime
            // 
            this.labelCollectTime.AutoSize = true;
            this.labelCollectTime.Location = new System.Drawing.Point(621, 414);
            this.labelCollectTime.Name = "labelCollectTime";
            this.labelCollectTime.Size = new System.Drawing.Size(115, 20);
            this.labelCollectTime.TabIndex = 39;
            this.labelCollectTime.Text = "Collect Time";
            // 
            // dateTimePickerCollectionDate
            // 
            this.dateTimePickerCollectionDate.Location = new System.Drawing.Point(260, 446);
            this.dateTimePickerCollectionDate.Name = "dateTimePickerCollectionDate";
            this.dateTimePickerCollectionDate.Size = new System.Drawing.Size(338, 26);
            this.dateTimePickerCollectionDate.TabIndex = 38;
            // 
            // labelCollectDate
            // 
            this.labelCollectDate.AutoSize = true;
            this.labelCollectDate.Location = new System.Drawing.Point(305, 414);
            this.labelCollectDate.Name = "labelCollectDate";
            this.labelCollectDate.Size = new System.Drawing.Size(114, 20);
            this.labelCollectDate.TabIndex = 37;
            this.labelCollectDate.Text = "Collect Date";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Status";
            // 
            // textBoxBookingStatus
            // 
            this.textBoxBookingStatus.Enabled = false;
            this.textBoxBookingStatus.Location = new System.Drawing.Point(641, 380);
            this.textBoxBookingStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBookingStatus.Name = "textBoxBookingStatus";
            this.textBoxBookingStatus.Size = new System.Drawing.Size(251, 26);
            this.textBoxBookingStatus.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "End date and time";
            // 
            // textBoxBookingEndDateTime
            // 
            this.textBoxBookingEndDateTime.Enabled = false;
            this.textBoxBookingEndDateTime.Location = new System.Drawing.Point(641, 319);
            this.textBoxBookingEndDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBookingEndDateTime.Name = "textBoxBookingEndDateTime";
            this.textBoxBookingEndDateTime.Size = new System.Drawing.Size(251, 26);
            this.textBoxBookingEndDateTime.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Start date and time";
            // 
            // textBoxBookingStartDateTime
            // 
            this.textBoxBookingStartDateTime.Enabled = false;
            this.textBoxBookingStartDateTime.Location = new System.Drawing.Point(641, 258);
            this.textBoxBookingStartDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBookingStartDateTime.Name = "textBoxBookingStartDateTime";
            this.textBoxBookingStartDateTime.Size = new System.Drawing.Size(251, 26);
            this.textBoxBookingStartDateTime.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Booking:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Car:";
            // 
            // textBoxCarModel
            // 
            this.textBoxCarModel.Enabled = false;
            this.textBoxCarModel.Location = new System.Drawing.Point(641, 166);
            this.textBoxCarModel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCarModel.Name = "textBoxCarModel";
            this.textBoxCarModel.Size = new System.Drawing.Size(251, 26);
            this.textBoxCarModel.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Model";
            // 
            // textBoxCarRegNo
            // 
            this.textBoxCarRegNo.Enabled = false;
            this.textBoxCarRegNo.Location = new System.Drawing.Point(641, 68);
            this.textBoxCarRegNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCarRegNo.Name = "textBoxCarRegNo";
            this.textBoxCarRegNo.Size = new System.Drawing.Size(251, 26);
            this.textBoxCarRegNo.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "RegNo";
            // 
            // textBoxCarMake
            // 
            this.textBoxCarMake.Enabled = false;
            this.textBoxCarMake.Location = new System.Drawing.Point(641, 117);
            this.textBoxCarMake.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCarMake.Name = "textBoxCarMake";
            this.textBoxCarMake.Size = new System.Drawing.Size(251, 26);
            this.textBoxCarMake.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Make";
            // 
            // textBoxCustomerPostCode
            // 
            this.textBoxCustomerPostCode.Enabled = false;
            this.textBoxCustomerPostCode.Location = new System.Drawing.Point(183, 270);
            this.textBoxCustomerPostCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerPostCode.Name = "textBoxCustomerPostCode";
            this.textBoxCustomerPostCode.Size = new System.Drawing.Size(251, 26);
            this.textBoxCustomerPostCode.TabIndex = 22;
            // 
            // labelPostCode
            // 
            this.labelPostCode.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.labelPostCode.AutoSize = true;
            this.labelPostCode.Location = new System.Drawing.Point(14, 270);
            this.labelPostCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostCode.Name = "labelPostCode";
            this.labelPostCode.Size = new System.Drawing.Size(93, 20);
            this.labelPostCode.TabIndex = 21;
            this.labelPostCode.Text = "Post code";
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Enabled = false;
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(183, 221);
            this.textBoxCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(251, 26);
            this.textBoxCustomerAddress.TabIndex = 20;
            // 
            // labelAddress
            // 
            this.labelAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(13, 221);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(78, 20);
            this.labelAddress.TabIndex = 19;
            this.labelAddress.Text = "Address";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(7, 38);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(96, 20);
            this.labelCustomer.TabIndex = 18;
            this.labelCustomer.Text = "Customer:";
            // 
            // textBoxCustomerCountryCode
            // 
            this.textBoxCustomerCountryCode.Enabled = false;
            this.textBoxCustomerCountryCode.Location = new System.Drawing.Point(183, 172);
            this.textBoxCustomerCountryCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerCountryCode.Name = "textBoxCustomerCountryCode";
            this.textBoxCustomerCountryCode.Size = new System.Drawing.Size(251, 26);
            this.textBoxCustomerCountryCode.TabIndex = 17;
            // 
            // labelCustomerCountryCode
            // 
            this.labelCustomerCountryCode.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.labelCustomerCountryCode.AutoSize = true;
            this.labelCustomerCountryCode.Location = new System.Drawing.Point(14, 172);
            this.labelCustomerCountryCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerCountryCode.Name = "labelCustomerCountryCode";
            this.labelCustomerCountryCode.Size = new System.Drawing.Size(120, 20);
            this.labelCustomerCountryCode.TabIndex = 16;
            this.labelCustomerCountryCode.Text = "Country code";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(183, 74);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(251, 26);
            this.txtCustomerName.TabIndex = 11;
            // 
            // btnCollectCar
            // 
            this.btnCollectCar.ForeColor = System.Drawing.Color.Black;
            this.btnCollectCar.Location = new System.Drawing.Point(17, 424);
            this.btnCollectCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCollectCar.Name = "btnCollectCar";
            this.btnCollectCar.Size = new System.Drawing.Size(217, 48);
            this.btnCollectCar.TabIndex = 10;
            this.btnCollectCar.Text = "Collect Car";
            this.btnCollectCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCollectCar.UseVisualStyleBackColor = true;
            this.btnCollectCar.Click += new System.EventHandler(this.btnCollectCar_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(13, 74);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(57, 20);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Name";
            // 
            // txtCustomerLicenceNo
            // 
            this.txtCustomerLicenceNo.Enabled = false;
            this.txtCustomerLicenceNo.Location = new System.Drawing.Point(183, 123);
            this.txtCustomerLicenceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerLicenceNo.Name = "txtCustomerLicenceNo";
            this.txtCustomerLicenceNo.Size = new System.Drawing.Size(251, 26);
            this.txtCustomerLicenceNo.TabIndex = 12;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Enabled = false;
            this.txtPhoneNo.Location = new System.Drawing.Point(183, 319);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(251, 26);
            this.txtPhoneNo.TabIndex = 15;
            // 
            // lblCustomerLicenceNo
            // 
            this.lblCustomerLicenceNo.AutoSize = true;
            this.lblCustomerLicenceNo.Location = new System.Drawing.Point(13, 123);
            this.lblCustomerLicenceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerLicenceNo.Name = "lblCustomerLicenceNo";
            this.lblCustomerLicenceNo.Size = new System.Drawing.Size(104, 20);
            this.lblCustomerLicenceNo.TabIndex = 3;
            this.lblCustomerLicenceNo.Text = "Licence No";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(183, 368);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 368);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(13, 319);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(84, 20);
            this.lblPhoneNo.TabIndex = 7;
            this.lblPhoneNo.Text = "PhoneNo";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.Location = new System.Drawing.Point(155, 62);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(186, 26);
            this.txtBookingID.TabIndex = 26;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(48, 62);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(95, 20);
            this.lblBookingID.TabIndex = 25;
            this.lblBookingID.Text = "BookingID";
            // 
            // labelCost
            // 
            this.labelCost.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(515, 295);
            this.labelCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(48, 20);
            this.labelCost.TabIndex = 41;
            this.labelCost.Text = "Cost";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Enabled = false;
            this.textBoxCost.Location = new System.Drawing.Point(519, 319);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(102, 26);
            this.textBoxCost.TabIndex = 42;
            // 
            // frmCollectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 669);
            this.Controls.Add(this.btnCheckBookings);
            this.Controls.Add(this.grpBookingData);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.mnuCollectCar);
            this.MainMenuStrip = this.mnuCollectCar;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCollectCar";
            this.Text = "frmCollectCar";
            this.Load += new System.EventHandler(this.frmCollectCar_Load);
            this.mnuCollectCar.ResumeLayout(false);
            this.mnuCollectCar.PerformLayout();
            this.grpBookingData.ResumeLayout(false);
            this.grpBookingData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCollectCar;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuReturn;
        private System.Windows.Forms.Button btnCheckBookings;
        private System.Windows.Forms.GroupBox grpBookingData;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnCollectCar;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerLicenceNo;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblCustomerLicenceNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox textBoxBookingEndDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBookingStartDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCarModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCarRegNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCarMake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCustomerPostCode;
        private System.Windows.Forms.Label labelPostCode;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox textBoxCustomerCountryCode;
        private System.Windows.Forms.Label labelCustomerCountryCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBookingStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCollectTime;
        private System.Windows.Forms.Label labelCollectTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerCollectionDate;
        private System.Windows.Forms.Label labelCollectDate;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelCost;
    }
}