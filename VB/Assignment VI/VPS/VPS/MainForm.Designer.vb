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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lstCustomerDetails = New System.Windows.Forms.ListBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpReciever = New System.Windows.Forms.GroupBox()
        Me.lblRecStreetAdr = New System.Windows.Forms.Label()
        Me.lblRecPostCity = New System.Windows.Forms.Label()
        Me.lblReceiverCountry = New System.Windows.Forms.Label()
        Me.lblReceiverName = New System.Windows.Forms.Label()
        Me.grpPostage = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblSenderCountry = New System.Windows.Forms.Label()
        Me.lblSendPostCity = New System.Windows.Forms.Label()
        Me.lblSenderStreetAdr = New System.Windows.Forms.Label()
        Me.lblSenderName = New System.Windows.Forms.Label()
        Me.grpMailData = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpMailInfo = New System.Windows.Forms.GroupBox()
        Me.cmbMailType = New System.Windows.Forms.ComboBox()
        Me.cmbReceiver = New System.Windows.Forms.ComboBox()
        Me.cmbSender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtbDetails = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpReciever.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpMailData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpMailInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(957, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ChangeToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.DeleteToolStripMenuItem1})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CustomerToolStripMenuItem.Text = "C&ustomer"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ChangeToolStripMenuItem.Text = "Change"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(154, 6)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(933, 441)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnOK)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.grpMailData)
        Me.TabPage1.Controls.Add(Me.grpMailInfo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(925, 415)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mail Type"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rtbDetails)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(925, 415)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Info"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.label5)
        Me.TabPage3.Controls.Add(Me.label4)
        Me.TabPage3.Controls.Add(Me.label3)
        Me.TabPage3.Controls.Add(Me.label2)
        Me.TabPage3.Controls.Add(Me.label1)
        Me.TabPage3.Controls.Add(Me.lstCustomerDetails)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(925, 415)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Customer"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(170, 11)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(45, 13)
        Me.label5.TabIndex = 18
        Me.label5.Text = "Address"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(3, 11)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(18, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "ID"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(657, 11)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(37, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Emails"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(454, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(81, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Phone numbers"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(44, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Customer Name"
        '
        'lstCustomerDetails
        '
        Me.lstCustomerDetails.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCustomerDetails.FormattingEnabled = True
        Me.lstCustomerDetails.ItemHeight = 14
        Me.lstCustomerDetails.Location = New System.Drawing.Point(3, 27)
        Me.lstCustomerDetails.Name = "lstCustomerDetails"
        Me.lstCustomerDetails.Size = New System.Drawing.Size(913, 354)
        Me.lstCustomerDetails.TabIndex = 13
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(548, 335)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(124, 42)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grpReciever)
        Me.GroupBox2.Controls.Add(Me.grpPostage)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(350, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 272)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'grpReciever
        '
        Me.grpReciever.Controls.Add(Me.lblRecStreetAdr)
        Me.grpReciever.Controls.Add(Me.lblRecPostCity)
        Me.grpReciever.Controls.Add(Me.lblReceiverCountry)
        Me.grpReciever.Controls.Add(Me.lblReceiverName)
        Me.grpReciever.Location = New System.Drawing.Point(162, 132)
        Me.grpReciever.Name = "grpReciever"
        Me.grpReciever.Size = New System.Drawing.Size(273, 125)
        Me.grpReciever.TabIndex = 2
        Me.grpReciever.TabStop = False
        Me.grpReciever.Text = "To"
        '
        'lblRecStreetAdr
        '
        Me.lblRecStreetAdr.AutoSize = True
        Me.lblRecStreetAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecStreetAdr.Location = New System.Drawing.Point(20, 52)
        Me.lblRecStreetAdr.Name = "lblRecStreetAdr"
        Me.lblRecStreetAdr.Size = New System.Drawing.Size(52, 15)
        Me.lblRecStreetAdr.TabIndex = 10
        Me.lblRecStreetAdr.Text = "Label13"
        '
        'lblRecPostCity
        '
        Me.lblRecPostCity.AutoSize = True
        Me.lblRecPostCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecPostCity.Location = New System.Drawing.Point(20, 76)
        Me.lblRecPostCity.Name = "lblRecPostCity"
        Me.lblRecPostCity.Size = New System.Drawing.Size(52, 15)
        Me.lblRecPostCity.TabIndex = 9
        Me.lblRecPostCity.Text = "Label13"
        '
        'lblReceiverCountry
        '
        Me.lblReceiverCountry.AutoSize = True
        Me.lblReceiverCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiverCountry.Location = New System.Drawing.Point(20, 100)
        Me.lblReceiverCountry.Name = "lblReceiverCountry"
        Me.lblReceiverCountry.Size = New System.Drawing.Size(52, 15)
        Me.lblReceiverCountry.TabIndex = 8
        Me.lblReceiverCountry.Text = "Label13"
        '
        'lblReceiverName
        '
        Me.lblReceiverName.AutoSize = True
        Me.lblReceiverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiverName.Location = New System.Drawing.Point(20, 25)
        Me.lblReceiverName.Name = "lblReceiverName"
        Me.lblReceiverName.Size = New System.Drawing.Size(52, 15)
        Me.lblReceiverName.TabIndex = 7
        Me.lblReceiverName.Text = "Label13"
        '
        'grpPostage
        '
        Me.grpPostage.Location = New System.Drawing.Point(277, 38)
        Me.grpPostage.Name = "grpPostage"
        Me.grpPostage.Size = New System.Drawing.Size(200, 86)
        Me.grpPostage.TabIndex = 1
        Me.grpPostage.TabStop = False
        Me.grpPostage.Text = "Postage"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSenderCountry)
        Me.GroupBox3.Controls.Add(Me.lblSendPostCity)
        Me.GroupBox3.Controls.Add(Me.lblSenderStreetAdr)
        Me.GroupBox3.Controls.Add(Me.lblSenderName)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 86)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "From"
        '
        'lblSenderCountry
        '
        Me.lblSenderCountry.AutoSize = True
        Me.lblSenderCountry.Location = New System.Drawing.Point(6, 61)
        Me.lblSenderCountry.Name = "lblSenderCountry"
        Me.lblSenderCountry.Size = New System.Drawing.Size(45, 13)
        Me.lblSenderCountry.TabIndex = 9
        Me.lblSenderCountry.Text = "Label13"
        '
        'lblSendPostCity
        '
        Me.lblSendPostCity.AutoSize = True
        Me.lblSendPostCity.Location = New System.Drawing.Point(6, 48)
        Me.lblSendPostCity.Name = "lblSendPostCity"
        Me.lblSendPostCity.Size = New System.Drawing.Size(45, 13)
        Me.lblSendPostCity.TabIndex = 8
        Me.lblSendPostCity.Text = "Label13"
        '
        'lblSenderStreetAdr
        '
        Me.lblSenderStreetAdr.AutoSize = True
        Me.lblSenderStreetAdr.Location = New System.Drawing.Point(6, 31)
        Me.lblSenderStreetAdr.Name = "lblSenderStreetAdr"
        Me.lblSenderStreetAdr.Size = New System.Drawing.Size(45, 13)
        Me.lblSenderStreetAdr.TabIndex = 7
        Me.lblSenderStreetAdr.Text = "Label13"
        '
        'lblSenderName
        '
        Me.lblSenderName.AutoSize = True
        Me.lblSenderName.Location = New System.Drawing.Point(6, 16)
        Me.lblSenderName.Name = "lblSenderName"
        Me.lblSenderName.Size = New System.Drawing.Size(45, 13)
        Me.lblSenderName.TabIndex = 6
        Me.lblSenderName.Text = "Label13"
        '
        'grpMailData
        '
        Me.grpMailData.Controls.Add(Me.GroupBox1)
        Me.grpMailData.Controls.Add(Me.Label10)
        Me.grpMailData.Controls.Add(Me.Label9)
        Me.grpMailData.Location = New System.Drawing.Point(53, 195)
        Me.grpMailData.Name = "grpMailData"
        Me.grpMailData.Size = New System.Drawing.Size(249, 191)
        Me.grpMailData.TabIndex = 5
        Me.grpMailData.TabStop = False
        Me.grpMailData.Text = "Mail Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 82)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Thickness, mm"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Width, mm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Length (longest side, mm)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Weight (gr)"
        '
        'grpMailInfo
        '
        Me.grpMailInfo.Controls.Add(Me.cmbMailType)
        Me.grpMailInfo.Controls.Add(Me.cmbReceiver)
        Me.grpMailInfo.Controls.Add(Me.cmbSender)
        Me.grpMailInfo.Controls.Add(Me.Label8)
        Me.grpMailInfo.Controls.Add(Me.Label7)
        Me.grpMailInfo.Controls.Add(Me.Label6)
        Me.grpMailInfo.Location = New System.Drawing.Point(53, 36)
        Me.grpMailInfo.Name = "grpMailInfo"
        Me.grpMailInfo.Size = New System.Drawing.Size(249, 131)
        Me.grpMailInfo.TabIndex = 4
        Me.grpMailInfo.TabStop = False
        Me.grpMailInfo.Text = "Mail Info"
        '
        'cmbMailType
        '
        Me.cmbMailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMailType.FormattingEnabled = True
        Me.cmbMailType.Location = New System.Drawing.Point(99, 84)
        Me.cmbMailType.Name = "cmbMailType"
        Me.cmbMailType.Size = New System.Drawing.Size(144, 21)
        Me.cmbMailType.TabIndex = 5
        '
        'cmbReceiver
        '
        Me.cmbReceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReceiver.FormattingEnabled = True
        Me.cmbReceiver.Location = New System.Drawing.Point(99, 54)
        Me.cmbReceiver.Name = "cmbReceiver"
        Me.cmbReceiver.Size = New System.Drawing.Size(144, 21)
        Me.cmbReceiver.TabIndex = 4
        '
        'cmbSender
        '
        Me.cmbSender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSender.FormattingEnabled = True
        Me.cmbSender.Location = New System.Drawing.Point(99, 27)
        Me.cmbSender.Name = "cmbSender"
        Me.cmbSender.Size = New System.Drawing.Size(144, 21)
        Me.cmbSender.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "To"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Mail Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "From"
        '
        'rtbDetails
        '
        Me.rtbDetails.Location = New System.Drawing.Point(514, 60)
        Me.rtbDetails.Name = "rtbDetails"
        Me.rtbDetails.ReadOnly = True
        Me.rtbDetails.Size = New System.Drawing.Size(372, 295)
        Me.rtbDetails.TabIndex = 3
        Me.rtbDetails.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(39, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(418, 295)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 494)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.grpReciever.ResumeLayout(False)
        Me.grpReciever.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpMailData.ResumeLayout(False)
        Me.grpMailData.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpMailInfo.ResumeLayout(False)
        Me.grpMailInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lstCustomerDetails As System.Windows.Forms.ListBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpReciever As System.Windows.Forms.GroupBox
    Friend WithEvents lblRecStreetAdr As System.Windows.Forms.Label
    Friend WithEvents lblRecPostCity As System.Windows.Forms.Label
    Friend WithEvents lblReceiverCountry As System.Windows.Forms.Label
    Friend WithEvents lblReceiverName As System.Windows.Forms.Label
    Friend WithEvents grpPostage As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSenderCountry As System.Windows.Forms.Label
    Friend WithEvents lblSendPostCity As System.Windows.Forms.Label
    Friend WithEvents lblSenderStreetAdr As System.Windows.Forms.Label
    Friend WithEvents lblSenderName As System.Windows.Forms.Label
    Friend WithEvents grpMailData As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grpMailInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMailType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReceiver As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSender As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rtbDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
