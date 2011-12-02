<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.txtPersonalEmail = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtProfessionalEmail = New System.Windows.Forms.TextBox()
        Me.txtCellPhone = New System.Windows.Forms.TextBox()
        Me.txtHomePhone = New System.Windows.Forms.TextBox()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grpPhoneEmail = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.grpName = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpAddress.SuspendLayout()
        Me.grpPhoneEmail.SuspendLayout()
        Me.grpName.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPersonalEmail
        '
        Me.txtPersonalEmail.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonalEmail.Location = New System.Drawing.Point(170, 92)
        Me.txtPersonalEmail.Name = "txtPersonalEmail"
        Me.txtPersonalEmail.Size = New System.Drawing.Size(289, 20)
        Me.txtPersonalEmail.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(81, 53)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(0, 13)
        Me.label1.TabIndex = 15
        '
        'txtProfessionalEmail
        '
        Me.txtProfessionalEmail.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfessionalEmail.Location = New System.Drawing.Point(170, 66)
        Me.txtProfessionalEmail.Name = "txtProfessionalEmail"
        Me.txtProfessionalEmail.Size = New System.Drawing.Size(289, 20)
        Me.txtProfessionalEmail.TabIndex = 5
        '
        'txtCellPhone
        '
        Me.txtCellPhone.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCellPhone.Location = New System.Drawing.Point(170, 40)
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.Size = New System.Drawing.Size(289, 20)
        Me.txtCellPhone.TabIndex = 4
        '
        'txtHomePhone
        '
        Me.txtHomePhone.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomePhone.Location = New System.Drawing.Point(170, 14)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(289, 20)
        Me.txtHomePhone.TabIndex = 3
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(Me.txtZip)
        Me.grpAddress.Controls.Add(Me.txtCity)
        Me.grpAddress.Controls.Add(Me.txtStreet)
        Me.grpAddress.Controls.Add(Me.cmbCountry)
        Me.grpAddress.Controls.Add(Me.label12)
        Me.grpAddress.Controls.Add(Me.label10)
        Me.grpAddress.Controls.Add(Me.label13)
        Me.grpAddress.Controls.Add(Me.label11)
        Me.grpAddress.Location = New System.Drawing.Point(20, 262)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(492, 147)
        Me.grpAddress.TabIndex = 19
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(170, 83)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(289, 20)
        Me.txtZip.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(170, 57)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(289, 20)
        Me.txtCity.TabIndex = 8
        '
        'txtStreet
        '
        Me.txtStreet.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(170, 29)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(289, 20)
        Me.txtStreet.TabIndex = 7
        '
        'cmbCountry
        '
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Location = New System.Drawing.Point(170, 109)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(289, 22)
        Me.cmbCountry.TabIndex = 10
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(24, 85)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(50, 13)
        Me.label12.TabIndex = 11
        Me.label12.Text = "Zip Code"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(23, 32)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(35, 13)
        Me.label10.TabIndex = 9
        Me.label10.Text = "Street"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(23, 109)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(43, 13)
        Me.label13.TabIndex = 12
        Me.label13.Text = "Country"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(23, 57)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(24, 13)
        Me.label11.TabIndex = 10
        Me.label11.Text = "City"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(169, 425)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 31)
        Me.btnOK.TabIndex = 16
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'grpPhoneEmail
        '
        Me.grpPhoneEmail.Controls.Add(Me.txtPersonalEmail)
        Me.grpPhoneEmail.Controls.Add(Me.txtProfessionalEmail)
        Me.grpPhoneEmail.Controls.Add(Me.txtCellPhone)
        Me.grpPhoneEmail.Controls.Add(Me.txtHomePhone)
        Me.grpPhoneEmail.Controls.Add(Me.label6)
        Me.grpPhoneEmail.Controls.Add(Me.label5)
        Me.grpPhoneEmail.Controls.Add(Me.label7)
        Me.grpPhoneEmail.Controls.Add(Me.label8)
        Me.grpPhoneEmail.Location = New System.Drawing.Point(20, 125)
        Me.grpPhoneEmail.Name = "grpPhoneEmail"
        Me.grpPhoneEmail.Size = New System.Drawing.Size(492, 118)
        Me.grpPhoneEmail.TabIndex = 20
        Me.grpPhoneEmail.TabStop = False
        Me.grpPhoneEmail.Text = "Phone & E-mail"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(26, 45)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(58, 13)
        Me.label6.TabIndex = 5
        Me.label6.Text = "Cell Phone"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(26, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(69, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Home Phone"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(26, 69)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(63, 13)
        Me.label7.TabIndex = 6
        Me.label7.Text = "Office Email"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(26, 95)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(79, 13)
        Me.label8.TabIndex = 7
        Me.label8.Text = "Personal E-mail"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(170, 53)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(289, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(170, 21)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(289, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(28, 24)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(28, 56)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'grpName
        '
        Me.grpName.Controls.Add(Me.txtLastName)
        Me.grpName.Controls.Add(Me.txtFirstName)
        Me.grpName.Controls.Add(Me.lblFirstName)
        Me.grpName.Controls.Add(Me.lblLastName)
        Me.grpName.Location = New System.Drawing.Point(20, 32)
        Me.grpName.Name = "grpName"
        Me.grpName.Size = New System.Drawing.Size(492, 87)
        Me.grpName.TabIndex = 18
        Me.grpName.TabStop = False
        Me.grpName.Text = "Name"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(317, 425)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 31)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 489)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpPhoneEmail)
        Me.Controls.Add(Me.grpName)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "CustomerForm"
        Me.Text = "CustomerForm"
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        Me.grpPhoneEmail.ResumeLayout(False)
        Me.grpPhoneEmail.PerformLayout()
        Me.grpName.ResumeLayout(False)
        Me.grpName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtPersonalEmail As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtProfessionalEmail As System.Windows.Forms.TextBox
    Private WithEvents txtCellPhone As System.Windows.Forms.TextBox
    Private WithEvents txtHomePhone As System.Windows.Forms.TextBox
    Private WithEvents grpAddress As System.Windows.Forms.GroupBox
    Private WithEvents txtZip As System.Windows.Forms.TextBox
    Private WithEvents txtCity As System.Windows.Forms.TextBox
    Private WithEvents txtStreet As System.Windows.Forms.TextBox
    Private WithEvents cmbCountry As System.Windows.Forms.ComboBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents btnOK As System.Windows.Forms.Button
    Private WithEvents grpPhoneEmail As System.Windows.Forms.GroupBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents txtLastName As System.Windows.Forms.TextBox
    Private WithEvents txtFirstName As System.Windows.Forms.TextBox
    Private WithEvents lblFirstName As System.Windows.Forms.Label
    Private WithEvents lblLastName As System.Windows.Forms.Label
    Private WithEvents grpName As System.Windows.Forms.GroupBox
    Private WithEvents btnCancel As System.Windows.Forms.Button
End Class
