namespace ORS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportaionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCustomers = new System.Windows.Forms.TabControl();
            this.tabMakeReservation = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxLessThan2 = new System.Windows.Forms.CheckBox();
            this.dateOfJourney = new System.Windows.Forms.DateTimePicker();
            this.numericChildren = new System.Windows.Forms.NumericUpDown();
            this.numericAdults = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblReservationUpto = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cmbTranportation = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTransportType = new System.Windows.Forms.Label();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.lblJourneyDate = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabMakeReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdults)).BeginInit();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabReservations.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.transportaionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(924, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveResToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveResToolStripMenuItem
            // 
            this.saveResToolStripMenuItem.Name = "saveResToolStripMenuItem";
            this.saveResToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveResToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.saveResToolStripMenuItem.Text = "&Save Reservations";
            this.saveResToolStripMenuItem.ToolTipText = "To Save the Reservations to a File";
            this.saveResToolStripMenuItem.Click += new System.EventHandler(this.saveResToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.ToolTipText = "To close the application";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "&Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addCustomerToolStripMenuItem.Text = "&Add";
            this.addCustomerToolStripMenuItem.ToolTipText = "To add new customer details";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.updateToolStripMenuItem.Text = "&Update ";
            this.updateToolStripMenuItem.ToolTipText = "To update customer details";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.ToolTipText = "To delete a customer";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // transportaionToolStripMenuItem
            // 
            this.transportaionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainToolStripMenuItem,
            this.bussToolStripMenuItem,
            this.flightToolStripMenuItem});
            this.transportaionToolStripMenuItem.Name = "transportaionToolStripMenuItem";
            this.transportaionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.transportaionToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.transportaionToolStripMenuItem.Text = "&Transportaion";
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.trainToolStripMenuItem.Text = "&Train";
            this.trainToolStripMenuItem.ToolTipText = "To add a new Train details";
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // bussToolStripMenuItem
            // 
            this.bussToolStripMenuItem.Name = "bussToolStripMenuItem";
            this.bussToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bussToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bussToolStripMenuItem.Text = "&Buss";
            this.bussToolStripMenuItem.ToolTipText = "To add new bus details";
            this.bussToolStripMenuItem.Click += new System.EventHandler(this.bussToolStripMenuItem_Click);
            // 
            // flightToolStripMenuItem
            // 
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.flightToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.flightToolStripMenuItem.Text = "&Flight";
            this.flightToolStripMenuItem.ToolTipText = "To add new flight details";
            this.flightToolStripMenuItem.Click += new System.EventHandler(this.flightToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "H&elp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.ToolTipText = "To see applicaton info";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.tabMakeReservation);
            this.tabCustomers.Controls.Add(this.tabReservations);
            this.tabCustomers.Controls.Add(this.tabCustomer);
            this.tabCustomers.Location = new System.Drawing.Point(12, 27);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.SelectedIndex = 0;
            this.tabCustomers.Size = new System.Drawing.Size(899, 487);
            this.tabCustomers.TabIndex = 1;
            // 
            // tabMakeReservation
            // 
            this.tabMakeReservation.Controls.Add(this.label1);
            this.tabMakeReservation.Controls.Add(this.checkBoxLessThan2);
            this.tabMakeReservation.Controls.Add(this.dateOfJourney);
            this.tabMakeReservation.Controls.Add(this.numericChildren);
            this.tabMakeReservation.Controls.Add(this.numericAdults);
            this.tabMakeReservation.Controls.Add(this.label10);
            this.tabMakeReservation.Controls.Add(this.lblAdults);
            this.tabMakeReservation.Controls.Add(this.cmbCustomer);
            this.tabMakeReservation.Controls.Add(this.lblName);
            this.tabMakeReservation.Controls.Add(this.grpDetails);
            this.tabMakeReservation.Controls.Add(this.pictureBox);
            this.tabMakeReservation.Controls.Add(this.cmbTranportation);
            this.tabMakeReservation.Controls.Add(this.cmbTo);
            this.tabMakeReservation.Controls.Add(this.cmbFrom);
            this.tabMakeReservation.Controls.Add(this.btnSubmit);
            this.tabMakeReservation.Controls.Add(this.lblTransportType);
            this.tabMakeReservation.Controls.Add(this.lblPassengers);
            this.tabMakeReservation.Controls.Add(this.lblJourneyDate);
            this.tabMakeReservation.Controls.Add(this.lblTo);
            this.tabMakeReservation.Controls.Add(this.lblFrom);
            this.tabMakeReservation.Location = new System.Drawing.Point(4, 22);
            this.tabMakeReservation.Name = "tabMakeReservation";
            this.tabMakeReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabMakeReservation.Size = new System.Drawing.Size(891, 461);
            this.tabMakeReservation.TabIndex = 0;
            this.tabMakeReservation.Text = "Make Reservation";
            this.tabMakeReservation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "All Fields Mandantory:";
            // 
            // checkBoxLessThan2
            // 
            this.checkBoxLessThan2.AutoSize = true;
            this.checkBoxLessThan2.Location = new System.Drawing.Point(406, 197);
            this.checkBoxLessThan2.Name = "checkBoxLessThan2";
            this.checkBoxLessThan2.Size = new System.Drawing.Size(69, 17);
            this.checkBoxLessThan2.TabIndex = 6;
            this.checkBoxLessThan2.Text = "< 2 years";
            this.checkBoxLessThan2.UseVisualStyleBackColor = true;
            // 
            // dateOfJourney
            // 
            this.dateOfJourney.Location = new System.Drawing.Point(194, 137);
            this.dateOfJourney.MinDate = new System.DateTime(2011, 12, 24, 0, 0, 0, 0);
            this.dateOfJourney.Name = "dateOfJourney";
            this.dateOfJourney.Size = new System.Drawing.Size(179, 20);
            this.dateOfJourney.TabIndex = 3;
            // 
            // numericChildren
            // 
            this.numericChildren.Location = new System.Drawing.Point(343, 195);
            this.numericChildren.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericChildren.Name = "numericChildren";
            this.numericChildren.Size = new System.Drawing.Size(43, 20);
            this.numericChildren.TabIndex = 5;
            // 
            // numericAdults
            // 
            this.numericAdults.Location = new System.Drawing.Point(173, 195);
            this.numericAdults.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericAdults.Name = "numericAdults";
            this.numericAdults.Size = new System.Drawing.Size(43, 20);
            this.numericAdults.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Children";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Location = new System.Drawing.Point(116, 197);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(36, 13);
            this.lblAdults.TabIndex = 15;
            this.lblAdults.Text = "Adults";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(194, 104);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(179, 21);
            this.cmbCustomer.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Customer Name";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblPrice);
            this.grpDetails.Controls.Add(this.lblReservationUpto);
            this.grpDetails.Controls.Add(this.lblCustomerPhone);
            this.grpDetails.Controls.Add(this.lblCustomerName);
            this.grpDetails.Location = new System.Drawing.Point(85, 308);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(731, 135);
            this.grpDetails.TabIndex = 12;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Reservation Details";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(39, 101);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "[Total Price]";
            // 
            // lblReservationUpto
            // 
            this.lblReservationUpto.AutoSize = true;
            this.lblReservationUpto.Location = new System.Drawing.Point(39, 65);
            this.lblReservationUpto.Name = "lblReservationUpto";
            this.lblReservationUpto.Size = new System.Drawing.Size(133, 13);
            this.lblReservationUpto.TabIndex = 2;
            this.lblReservationUpto.Text = "[Reservation From and To]";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(473, 34);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(91, 13);
            this.lblCustomerPhone.TabIndex = 1;
            this.lblCustomerPhone.Text = "[Customer Phone]";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(39, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(88, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "[Customer Name]";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::ORS.Properties.Resources.Flight;
            this.pictureBox.Location = new System.Drawing.Point(514, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(284, 262);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // cmbTranportation
            // 
            this.cmbTranportation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTranportation.FormattingEnabled = true;
            this.cmbTranportation.Location = new System.Drawing.Point(274, 226);
            this.cmbTranportation.Name = "cmbTranportation";
            this.cmbTranportation.Size = new System.Drawing.Size(179, 21);
            this.cmbTranportation.TabIndex = 7;
            this.cmbTranportation.SelectedIndexChanged += new System.EventHandler(this.cmbTranportation_SelectedIndexChanged);
            // 
            // cmbTo
            // 
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(194, 70);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(179, 21);
            this.cmbTo.TabIndex = 1;
            // 
            // cmbFrom
            // 
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(194, 36);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(179, 21);
            this.cmbFrom.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(194, 272);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTransportType
            // 
            this.lblTransportType.AutoSize = true;
            this.lblTransportType.Location = new System.Drawing.Point(69, 234);
            this.lblTransportType.Name = "lblTransportType";
            this.lblTransportType.Size = new System.Drawing.Size(169, 13);
            this.lblTransportType.TabIndex = 4;
            this.lblTransportType.Text = "Select the means of Transportaion";
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Location = new System.Drawing.Point(69, 169);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(96, 13);
            this.lblPassengers.TabIndex = 3;
            this.lblPassengers.Text = "No. Of Passengers";
            // 
            // lblJourneyDate
            // 
            this.lblJourneyDate.AutoSize = true;
            this.lblJourneyDate.Location = new System.Drawing.Point(69, 143);
            this.lblJourneyDate.Name = "lblJourneyDate";
            this.lblJourneyDate.Size = new System.Drawing.Size(82, 13);
            this.lblJourneyDate.TabIndex = 2;
            this.lblJourneyDate.Text = "Date of Journey";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(69, 73);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(69, 36);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.label6);
            this.tabReservations.Controls.Add(this.lstReservations);
            this.tabReservations.Location = new System.Drawing.Point(4, 22);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(891, 461);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "Reservations";
            this.tabReservations.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "List of Reservations";
            // 
            // lstReservations
            // 
            this.lstReservations.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.ItemHeight = 14;
            this.lstReservations.Location = new System.Drawing.Point(15, 37);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(856, 382);
            this.lstReservations.TabIndex = 0;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.label8);
            this.tabCustomer.Controls.Add(this.lstCustomers);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(891, 461);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customers";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "List of Registered Customers";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 14;
            this.lstCustomers.Location = new System.Drawing.Point(6, 32);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(869, 396);
            this.lstCustomers.TabIndex = 0;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Buss.gif");
            this.imgList.Images.SetKeyName(1, "Train.gif");
            this.imgList.Images.SetKeyName(2, "Flight.gif");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 527);
            this.Controls.Add(this.tabCustomers);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Online Reservation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabMakeReservation.ResumeLayout(false);
            this.tabMakeReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdults)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabReservations.ResumeLayout(false);
            this.tabReservations.PerformLayout();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportaionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bussToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCustomers;
        private System.Windows.Forms.TabPage tabMakeReservation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTransportType;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.Label lblJourneyDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTranportation;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblReservationUpto;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.NumericUpDown numericChildren;
        private System.Windows.Forms.NumericUpDown numericAdults;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.DateTimePicker dateOfJourney;
        private System.Windows.Forms.CheckBox checkBoxLessThan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
    }
}

