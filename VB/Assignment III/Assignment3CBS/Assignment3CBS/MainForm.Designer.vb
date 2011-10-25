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
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtnCancel = New System.Windows.Forms.RadioButton()
        Me.rbtnReserved = New System.Windows.Forms.RadioButton()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.lblNumOfVacant = New System.Windows.Forms.Label()
        Me.lblNumOfReserved = New System.Windows.Forms.Label()
        Me.lblNumOfSeats = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpReservations = New System.Windows.Forms.GroupBox()
        Me.lstReservations = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpInput.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.grpReservations.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.btnOK)
        Me.grpInput.Controls.Add(Me.txtPrice)
        Me.grpInput.Controls.Add(Me.txtName)
        Me.grpInput.Controls.Add(Me.Label2)
        Me.grpInput.Controls.Add(Me.Label1)
        Me.grpInput.Controls.Add(Me.rbtnCancel)
        Me.grpInput.Controls.Add(Me.rbtnReserved)
        Me.grpInput.Location = New System.Drawing.Point(37, 41)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(244, 171)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Booking Input"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(19, 124)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(191, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "Reserve / Cancel"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(174, 81)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrice.Size = New System.Drawing.Size(47, 20)
        Me.txtPrice.TabIndex = 1
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(10, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(125, 20)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'rbtnCancel
        '
        Me.rbtnCancel.AutoSize = True
        Me.rbtnCancel.Location = New System.Drawing.Point(121, 20)
        Me.rbtnCancel.Name = "rbtnCancel"
        Me.rbtnCancel.Size = New System.Drawing.Size(118, 17)
        Me.rbtnCancel.TabIndex = 5
        Me.rbtnCancel.TabStop = True
        Me.rbtnCancel.Text = "Cancel Reservation"
        Me.rbtnCancel.UseVisualStyleBackColor = True
        '
        'rbtnReserved
        '
        Me.rbtnReserved.AutoSize = True
        Me.rbtnReserved.Location = New System.Drawing.Point(19, 20)
        Me.rbtnReserved.Name = "rbtnReserved"
        Me.rbtnReserved.Size = New System.Drawing.Size(65, 17)
        Me.rbtnReserved.TabIndex = 3
        Me.rbtnReserved.TabStop = True
        Me.rbtnReserved.Text = "Reserve"
        Me.rbtnReserved.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblTotalRevenue)
        Me.grpOutput.Controls.Add(Me.lblNumOfVacant)
        Me.grpOutput.Controls.Add(Me.lblNumOfReserved)
        Me.grpOutput.Controls.Add(Me.lblNumOfSeats)
        Me.grpOutput.Controls.Add(Me.Label6)
        Me.grpOutput.Controls.Add(Me.Label5)
        Me.grpOutput.Controls.Add(Me.Label4)
        Me.grpOutput.Controls.Add(Me.Label3)
        Me.grpOutput.Location = New System.Drawing.Point(37, 257)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(244, 174)
        Me.grpOutput.TabIndex = 1
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output Data"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.BackColor = System.Drawing.Color.White
        Me.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRevenue.Location = New System.Drawing.Point(118, 130)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(84, 17)
        Me.lblTotalRevenue.TabIndex = 7
        Me.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumOfVacant
        '
        Me.lblNumOfVacant.BackColor = System.Drawing.Color.White
        Me.lblNumOfVacant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumOfVacant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfVacant.Location = New System.Drawing.Point(150, 90)
        Me.lblNumOfVacant.Name = "lblNumOfVacant"
        Me.lblNumOfVacant.Size = New System.Drawing.Size(45, 13)
        Me.lblNumOfVacant.TabIndex = 6
        Me.lblNumOfVacant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumOfReserved
        '
        Me.lblNumOfReserved.BackColor = System.Drawing.Color.White
        Me.lblNumOfReserved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumOfReserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfReserved.Location = New System.Drawing.Point(150, 60)
        Me.lblNumOfReserved.Name = "lblNumOfReserved"
        Me.lblNumOfReserved.Size = New System.Drawing.Size(45, 13)
        Me.lblNumOfReserved.TabIndex = 5
        Me.lblNumOfReserved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumOfSeats
        '
        Me.lblNumOfSeats.BackColor = System.Drawing.Color.White
        Me.lblNumOfSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumOfSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfSeats.Location = New System.Drawing.Point(150, 32)
        Me.lblNumOfSeats.Name = "lblNumOfSeats"
        Me.lblNumOfSeats.Size = New System.Drawing.Size(45, 13)
        Me.lblNumOfSeats.TabIndex = 4
        Me.lblNumOfSeats.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total Revenue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Number of Vacant:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Number of Reserved:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Number of Seats:"
        '
        'grpReservations
        '
        Me.grpReservations.Controls.Add(Me.lstReservations)
        Me.grpReservations.Controls.Add(Me.Label10)
        Me.grpReservations.Controls.Add(Me.Label9)
        Me.grpReservations.Controls.Add(Me.Label8)
        Me.grpReservations.Controls.Add(Me.Label7)
        Me.grpReservations.Location = New System.Drawing.Point(358, 41)
        Me.grpReservations.Name = "grpReservations"
        Me.grpReservations.Size = New System.Drawing.Size(433, 390)
        Me.grpReservations.TabIndex = 2
        Me.grpReservations.TabStop = False
        Me.grpReservations.Text = "Reservations"
        '
        'lstReservations
        '
        Me.lstReservations.FormattingEnabled = True
        Me.lstReservations.Location = New System.Drawing.Point(19, 53)
        Me.lstReservations.Name = "lstReservations"
        Me.lstReservations.Size = New System.Drawing.Size(396, 316)
        Me.lstReservations.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(191, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Seat"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 471)
        Me.Controls.Add(Me.grpReservations)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Name = "MainForm"
        Me.Text = "CBS Cinema Booking System"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.grpReservations.ResumeLayout(False)
        Me.grpReservations.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtnCancel As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnReserved As System.Windows.Forms.RadioButton
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumOfSeats As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpReservations As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents lblNumOfVacant As System.Windows.Forms.Label
    Friend WithEvents lblNumOfReserved As System.Windows.Forms.Label
    Friend WithEvents lstReservations As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
