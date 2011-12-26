<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveCurrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveResToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.customerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.updateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.deleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.transportaionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.trainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bussToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.flightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabCustomers = New System.Windows.Forms.TabControl()
        Me.tabMakeReservation = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.numericInfants = New System.Windows.Forms.NumericUpDown()
        Me.lblInfants = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.checkBoxLessThan2 = New System.Windows.Forms.CheckBox()
        Me.dateOfJourney = New System.Windows.Forms.DateTimePicker()
        Me.numericChildren = New System.Windows.Forms.NumericUpDown()
        Me.numericAdults = New System.Windows.Forms.NumericUpDown()
        Me.label10 = New System.Windows.Forms.Label()
        Me.lblAdults = New System.Windows.Forms.Label()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lblTotalTickets = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblReservationUpto = New System.Windows.Forms.Label()
        Me.lblCustomerPhone = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.cmbTranportation = New System.Windows.Forms.ComboBox()
        Me.cmbTo = New System.Windows.Forms.ComboBox()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblTransportType = New System.Windows.Forms.Label()
        Me.lblPassengers = New System.Windows.Forms.Label()
        Me.lblJourneyDate = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.tabReservations = New System.Windows.Forms.TabPage()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lstReservations = New System.Windows.Forms.ListBox()
        Me.tabCustomer = New System.Windows.Forms.TabPage()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MainMenu.SuspendLayout()
        Me.tabCustomers.SuspendLayout()
        Me.tabMakeReservation.SuspendLayout()
        CType(Me.numericInfants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericChildren, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericAdults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetails.SuspendLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReservations.SuspendLayout()
        Me.tabCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.customerToolStripMenuItem, Me.transportaionToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(929, 24)
        Me.MainMenu.TabIndex = 1
        Me.MainMenu.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.saveCurrentToolStripMenuItem, Me.saveResToolStripMenuItem, Me.toolStripMenuItem2, Me.exitToolStripMenuItem1})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'saveCurrentToolStripMenuItem
        '
        Me.saveCurrentToolStripMenuItem.Name = "saveCurrentToolStripMenuItem"
        Me.saveCurrentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.saveCurrentToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.saveCurrentToolStripMenuItem.Text = "Sa&ve Current "
        Me.saveCurrentToolStripMenuItem.ToolTipText = "To save Current reservation"
        '
        'saveResToolStripMenuItem
        '
        Me.saveResToolStripMenuItem.Name = "saveResToolStripMenuItem"
        Me.saveResToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.saveResToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.saveResToolStripMenuItem.Text = "&Save Reservations"
        Me.saveResToolStripMenuItem.ToolTipText = "To Save the Reservations to a File"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(204, 6)
        '
        'exitToolStripMenuItem1
        '
        Me.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1"
        Me.exitToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.exitToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.exitToolStripMenuItem1.Text = "E&xit"
        Me.exitToolStripMenuItem1.ToolTipText = "To close the application"
        '
        'customerToolStripMenuItem
        '
        Me.customerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addCustomerToolStripMenuItem, Me.updateToolStripMenuItem, Me.toolStripMenuItem1, Me.deleteToolStripMenuItem})
        Me.customerToolStripMenuItem.Name = "customerToolStripMenuItem"
        Me.customerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.customerToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.customerToolStripMenuItem.Text = "&Customer"
        '
        'addCustomerToolStripMenuItem
        '
        Me.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem"
        Me.addCustomerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.addCustomerToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.addCustomerToolStripMenuItem.Text = "&Add"
        Me.addCustomerToolStripMenuItem.ToolTipText = "To add new customer details"
        '
        'updateToolStripMenuItem
        '
        Me.updateToolStripMenuItem.Name = "updateToolStripMenuItem"
        Me.updateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.updateToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.updateToolStripMenuItem.Text = "&Update "
        Me.updateToolStripMenuItem.ToolTipText = "To update customer details"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(154, 6)
        '
        'deleteToolStripMenuItem
        '
        Me.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem"
        Me.deleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.deleteToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.deleteToolStripMenuItem.Text = "&Delete"
        Me.deleteToolStripMenuItem.ToolTipText = "To delete a customer"
        '
        'transportaionToolStripMenuItem
        '
        Me.transportaionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.trainToolStripMenuItem, Me.bussToolStripMenuItem, Me.flightToolStripMenuItem})
        Me.transportaionToolStripMenuItem.Name = "transportaionToolStripMenuItem"
        Me.transportaionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.transportaionToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.transportaionToolStripMenuItem.Text = "&Transportaion"
        '
        'trainToolStripMenuItem
        '
        Me.trainToolStripMenuItem.Name = "trainToolStripMenuItem"
        Me.trainToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.trainToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.trainToolStripMenuItem.Text = "&Train"
        Me.trainToolStripMenuItem.ToolTipText = "To add a new Train details"
        '
        'bussToolStripMenuItem
        '
        Me.bussToolStripMenuItem.Name = "bussToolStripMenuItem"
        Me.bussToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.bussToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.bussToolStripMenuItem.Text = "&Bus"
        Me.bussToolStripMenuItem.ToolTipText = "To add new bus details"
        '
        'flightToolStripMenuItem
        '
        Me.flightToolStripMenuItem.Name = "flightToolStripMenuItem"
        Me.flightToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.flightToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.flightToolStripMenuItem.Text = "&Flight"
        Me.flightToolStripMenuItem.ToolTipText = "To add new flight details"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem, Me.viewHelpToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.helpToolStripMenuItem.Text = "H&elp"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.aboutToolStripMenuItem.Text = "A&bout"
        Me.aboutToolStripMenuItem.ToolTipText = "To see applicaton info"
        '
        'viewHelpToolStripMenuItem
        '
        Me.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem"
        Me.viewHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.viewHelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.viewHelpToolStripMenuItem.Text = "View Help"
        '
        'tabCustomers
        '
        Me.tabCustomers.Controls.Add(Me.tabMakeReservation)
        Me.tabCustomers.Controls.Add(Me.tabReservations)
        Me.tabCustomers.Controls.Add(Me.tabCustomer)
        Me.tabCustomers.Location = New System.Drawing.Point(12, 28)
        Me.tabCustomers.Name = "tabCustomers"
        Me.tabCustomers.SelectedIndex = 0
        Me.tabCustomers.Size = New System.Drawing.Size(899, 487)
        Me.tabCustomers.TabIndex = 2
        '
        'tabMakeReservation
        '
        Me.tabMakeReservation.Controls.Add(Me.btnCancel)
        Me.tabMakeReservation.Controls.Add(Me.btnConfirm)
        Me.tabMakeReservation.Controls.Add(Me.numericInfants)
        Me.tabMakeReservation.Controls.Add(Me.lblInfants)
        Me.tabMakeReservation.Controls.Add(Me.label1)
        Me.tabMakeReservation.Controls.Add(Me.checkBoxLessThan2)
        Me.tabMakeReservation.Controls.Add(Me.dateOfJourney)
        Me.tabMakeReservation.Controls.Add(Me.numericChildren)
        Me.tabMakeReservation.Controls.Add(Me.numericAdults)
        Me.tabMakeReservation.Controls.Add(Me.label10)
        Me.tabMakeReservation.Controls.Add(Me.lblAdults)
        Me.tabMakeReservation.Controls.Add(Me.cmbCustomer)
        Me.tabMakeReservation.Controls.Add(Me.lblName)
        Me.tabMakeReservation.Controls.Add(Me.grpDetails)
        Me.tabMakeReservation.Controls.Add(Me.pictureBox)
        Me.tabMakeReservation.Controls.Add(Me.cmbTranportation)
        Me.tabMakeReservation.Controls.Add(Me.cmbTo)
        Me.tabMakeReservation.Controls.Add(Me.cmbFrom)
        Me.tabMakeReservation.Controls.Add(Me.btnSubmit)
        Me.tabMakeReservation.Controls.Add(Me.lblTransportType)
        Me.tabMakeReservation.Controls.Add(Me.lblPassengers)
        Me.tabMakeReservation.Controls.Add(Me.lblJourneyDate)
        Me.tabMakeReservation.Controls.Add(Me.lblTo)
        Me.tabMakeReservation.Controls.Add(Me.lblFrom)
        Me.tabMakeReservation.Location = New System.Drawing.Point(4, 22)
        Me.tabMakeReservation.Name = "tabMakeReservation"
        Me.tabMakeReservation.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMakeReservation.Size = New System.Drawing.Size(891, 461)
        Me.tabMakeReservation.TabIndex = 0
        Me.tabMakeReservation.Text = "Make Reservation"
        Me.tabMakeReservation.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(378, 265)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Location = New System.Drawing.Point(246, 265)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 5
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'numericInfants
        '
        Me.numericInfants.Location = New System.Drawing.Point(442, 199)
        Me.numericInfants.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numericInfants.Name = "numericInfants"
        Me.numericInfants.Size = New System.Drawing.Size(43, 20)
        Me.numericInfants.TabIndex = 19
        Me.numericInfants.Visible = False
        '
        'lblInfants
        '
        Me.lblInfants.AutoSize = True
        Me.lblInfants.Location = New System.Drawing.Point(388, 202)
        Me.lblInfants.Name = "lblInfants"
        Me.lblInfants.Size = New System.Drawing.Size(39, 13)
        Me.lblInfants.TabIndex = 18
        Me.lblInfants.Text = "Infants"
        Me.lblInfants.Visible = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(24, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(110, 13)
        Me.label1.TabIndex = 17
        Me.label1.Text = "All Fields Mandantory:"
        '
        'checkBoxLessThan2
        '
        Me.checkBoxLessThan2.AutoSize = True
        Me.checkBoxLessThan2.Location = New System.Drawing.Point(313, 200)
        Me.checkBoxLessThan2.Name = "checkBoxLessThan2"
        Me.checkBoxLessThan2.Size = New System.Drawing.Size(69, 17)
        Me.checkBoxLessThan2.TabIndex = 6
        Me.checkBoxLessThan2.Text = "< 2 years"
        Me.checkBoxLessThan2.UseVisualStyleBackColor = True
        Me.checkBoxLessThan2.Visible = False
        '
        'dateOfJourney
        '
        Me.dateOfJourney.Location = New System.Drawing.Point(194, 137)
        Me.dateOfJourney.MinDate = New Date(2011, 12, 24, 0, 0, 0, 0)
        Me.dateOfJourney.Name = "dateOfJourney"
        Me.dateOfJourney.Size = New System.Drawing.Size(179, 20)
        Me.dateOfJourney.TabIndex = 3
        '
        'numericChildren
        '
        Me.numericChildren.Location = New System.Drawing.Point(246, 197)
        Me.numericChildren.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numericChildren.Name = "numericChildren"
        Me.numericChildren.Size = New System.Drawing.Size(43, 20)
        Me.numericChildren.TabIndex = 5
        '
        'numericAdults
        '
        Me.numericAdults.Location = New System.Drawing.Point(122, 197)
        Me.numericAdults.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numericAdults.Name = "numericAdults"
        Me.numericAdults.Size = New System.Drawing.Size(43, 20)
        Me.numericAdults.TabIndex = 4
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(182, 202)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(45, 13)
        Me.label10.TabIndex = 16
        Me.label10.Text = "Children"
        '
        'lblAdults
        '
        Me.lblAdults.AutoSize = True
        Me.lblAdults.Location = New System.Drawing.Point(69, 201)
        Me.lblAdults.Name = "lblAdults"
        Me.lblAdults.Size = New System.Drawing.Size(36, 13)
        Me.lblAdults.TabIndex = 15
        Me.lblAdults.Text = "Adults"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(194, 104)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(179, 21)
        Me.cmbCustomer.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(69, 107)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(82, 13)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Customer Name"
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.lblTotalTickets)
        Me.grpDetails.Controls.Add(Me.lblPrice)
        Me.grpDetails.Controls.Add(Me.lblReservationUpto)
        Me.grpDetails.Controls.Add(Me.lblCustomerPhone)
        Me.grpDetails.Controls.Add(Me.lblCustomerName)
        Me.grpDetails.Location = New System.Drawing.Point(85, 308)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(731, 135)
        Me.grpDetails.TabIndex = 12
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Reservation Details"
        '
        'lblTotalTickets
        '
        Me.lblTotalTickets.AutoSize = True
        Me.lblTotalTickets.Location = New System.Drawing.Point(473, 101)
        Me.lblTotalTickets.Name = "lblTotalTickets"
        Me.lblTotalTickets.Size = New System.Drawing.Size(75, 13)
        Me.lblTotalTickets.TabIndex = 4
        Me.lblTotalTickets.Text = "[Total Tickets]"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(39, 101)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(64, 13)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "[Total Price]"
        '
        'lblReservationUpto
        '
        Me.lblReservationUpto.AutoSize = True
        Me.lblReservationUpto.Location = New System.Drawing.Point(39, 65)
        Me.lblReservationUpto.Name = "lblReservationUpto"
        Me.lblReservationUpto.Size = New System.Drawing.Size(133, 13)
        Me.lblReservationUpto.TabIndex = 2
        Me.lblReservationUpto.Text = "[Reservation From and To]"
        '
        'lblCustomerPhone
        '
        Me.lblCustomerPhone.AutoSize = True
        Me.lblCustomerPhone.Location = New System.Drawing.Point(473, 34)
        Me.lblCustomerPhone.Name = "lblCustomerPhone"
        Me.lblCustomerPhone.Size = New System.Drawing.Size(91, 13)
        Me.lblCustomerPhone.TabIndex = 1
        Me.lblCustomerPhone.Text = "[Customer Phone]"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(39, 34)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(88, 13)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "[Customer Name]"
        '
        'pictureBox
        '
        Me.pictureBox.Image = Global.ORS.My.Resources.Resources.Flight
        Me.pictureBox.Location = New System.Drawing.Point(514, 26)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(284, 262)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox.TabIndex = 11
        Me.pictureBox.TabStop = False
        '
        'cmbTranportation
        '
        Me.cmbTranportation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTranportation.FormattingEnabled = True
        Me.cmbTranportation.Location = New System.Drawing.Point(274, 226)
        Me.cmbTranportation.Name = "cmbTranportation"
        Me.cmbTranportation.Size = New System.Drawing.Size(179, 21)
        Me.cmbTranportation.TabIndex = 7
        '
        'cmbTo
        '
        Me.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(194, 70)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(179, 21)
        Me.cmbTo.TabIndex = 1
        '
        'cmbFrom
        '
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(194, 36)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(179, 21)
        Me.cmbFrom.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(113, 265)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblTransportType
        '
        Me.lblTransportType.AutoSize = True
        Me.lblTransportType.Location = New System.Drawing.Point(69, 234)
        Me.lblTransportType.Name = "lblTransportType"
        Me.lblTransportType.Size = New System.Drawing.Size(169, 13)
        Me.lblTransportType.TabIndex = 4
        Me.lblTransportType.Text = "Select the means of Transportaion"
        '
        'lblPassengers
        '
        Me.lblPassengers.AutoSize = True
        Me.lblPassengers.Location = New System.Drawing.Point(69, 169)
        Me.lblPassengers.Name = "lblPassengers"
        Me.lblPassengers.Size = New System.Drawing.Size(96, 13)
        Me.lblPassengers.TabIndex = 3
        Me.lblPassengers.Text = "No. Of Passengers"
        '
        'lblJourneyDate
        '
        Me.lblJourneyDate.AutoSize = True
        Me.lblJourneyDate.Location = New System.Drawing.Point(69, 143)
        Me.lblJourneyDate.Name = "lblJourneyDate"
        Me.lblJourneyDate.Size = New System.Drawing.Size(82, 13)
        Me.lblJourneyDate.TabIndex = 2
        Me.lblJourneyDate.Text = "Date of Journey"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(69, 73)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "To"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(69, 36)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From"
        '
        'tabReservations
        '
        Me.tabReservations.Controls.Add(Me.label6)
        Me.tabReservations.Controls.Add(Me.lstReservations)
        Me.tabReservations.Location = New System.Drawing.Point(4, 22)
        Me.tabReservations.Name = "tabReservations"
        Me.tabReservations.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReservations.Size = New System.Drawing.Size(891, 461)
        Me.tabReservations.TabIndex = 1
        Me.tabReservations.Text = "Reservations"
        Me.tabReservations.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(15, 18)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 13)
        Me.label6.TabIndex = 1
        Me.label6.Text = "List of Reservations"
        '
        'lstReservations
        '
        Me.lstReservations.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.lstReservations.FormattingEnabled = True
        Me.lstReservations.ItemHeight = 14
        Me.lstReservations.Location = New System.Drawing.Point(15, 37)
        Me.lstReservations.Name = "lstReservations"
        Me.lstReservations.Size = New System.Drawing.Size(856, 382)
        Me.lstReservations.TabIndex = 0
        '
        'tabCustomer
        '
        Me.tabCustomer.Controls.Add(Me.label8)
        Me.tabCustomer.Controls.Add(Me.lstCustomers)
        Me.tabCustomer.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomer.Name = "tabCustomer"
        Me.tabCustomer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomer.Size = New System.Drawing.Size(891, 461)
        Me.tabCustomer.TabIndex = 2
        Me.tabCustomer.Text = "Customers"
        Me.tabCustomer.UseVisualStyleBackColor = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(7, 13)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(141, 13)
        Me.label8.TabIndex = 1
        Me.label8.Text = "List of Registered Customers"
        '
        'lstCustomers
        '
        Me.lstCustomers.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.ItemHeight = 14
        Me.lstCustomers.Location = New System.Drawing.Point(6, 32)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(869, 396)
        Me.lstCustomers.TabIndex = 0
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "Buss.gif")
        Me.imgList.Images.SetKeyName(1, "Train.gif")
        Me.imgList.Images.SetKeyName(2, "Flight.gif")
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.CheckFileExists = True
        Me.saveFileDialog1.DefaultExt = "txt"
        Me.saveFileDialog1.Filter = """txt files (*.txt)|*.txt|All files (*.*)|*.*"""
        Me.saveFileDialog1.RestoreDirectory = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(929, 527)
        Me.Controls.Add(Me.tabCustomers)
        Me.Controls.Add(Me.MainMenu)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Online Reservation System"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.tabCustomers.ResumeLayout(False)
        Me.tabMakeReservation.ResumeLayout(False)
        Me.tabMakeReservation.PerformLayout()
        CType(Me.numericInfants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericChildren, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericAdults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReservations.ResumeLayout(False)
        Me.tabReservations.PerformLayout()
        Me.tabCustomer.ResumeLayout(False)
        Me.tabCustomer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents saveCurrentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents saveResToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents exitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents customerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents addCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents updateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents deleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents transportaionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents trainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents bussToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents flightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents viewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tabCustomers As System.Windows.Forms.TabControl
    Private WithEvents tabMakeReservation As System.Windows.Forms.TabPage
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnConfirm As System.Windows.Forms.Button
    Private WithEvents numericInfants As System.Windows.Forms.NumericUpDown
    Private WithEvents lblInfants As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents checkBoxLessThan2 As System.Windows.Forms.CheckBox
    Private WithEvents dateOfJourney As System.Windows.Forms.DateTimePicker
    Private WithEvents numericChildren As System.Windows.Forms.NumericUpDown
    Private WithEvents numericAdults As System.Windows.Forms.NumericUpDown
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents lblAdults As System.Windows.Forms.Label
    Private WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents grpDetails As System.Windows.Forms.GroupBox
    Private WithEvents lblTotalTickets As System.Windows.Forms.Label
    Private WithEvents lblPrice As System.Windows.Forms.Label
    Private WithEvents lblReservationUpto As System.Windows.Forms.Label
    Private WithEvents lblCustomerPhone As System.Windows.Forms.Label
    Private WithEvents lblCustomerName As System.Windows.Forms.Label
    Private WithEvents pictureBox As System.Windows.Forms.PictureBox
    Private WithEvents cmbTranportation As System.Windows.Forms.ComboBox
    Private WithEvents cmbTo As System.Windows.Forms.ComboBox
    Private WithEvents cmbFrom As System.Windows.Forms.ComboBox
    Private WithEvents btnSubmit As System.Windows.Forms.Button
    Private WithEvents lblTransportType As System.Windows.Forms.Label
    Private WithEvents lblPassengers As System.Windows.Forms.Label
    Private WithEvents lblJourneyDate As System.Windows.Forms.Label
    Private WithEvents lblTo As System.Windows.Forms.Label
    Private WithEvents lblFrom As System.Windows.Forms.Label
    Private WithEvents tabReservations As System.Windows.Forms.TabPage
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents lstReservations As System.Windows.Forms.ListBox
    Private WithEvents tabCustomer As System.Windows.Forms.TabPage
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents lstCustomers As System.Windows.Forms.ListBox
    Private WithEvents imgList As System.Windows.Forms.ImageList
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
