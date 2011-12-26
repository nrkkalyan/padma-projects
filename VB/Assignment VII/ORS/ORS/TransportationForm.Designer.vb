<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransportationForm
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnTransportation = New System.Windows.Forms.Button()
        Me.cmbTo = New System.Windows.Forms.ComboBox()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.timeTransportation = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(46, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(128, 13)
        Me.label1.TabIndex = 25
        Me.label1.Text = "All Fields are Mandantory:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(182, 197)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(83, 20)
        Me.txtPrice.TabIndex = 24
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(94, 200)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(82, 13)
        Me.lblPrice.TabIndex = 23
        Me.lblPrice.Text = "Price (per Adult)"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(236, 239)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnTransportation
        '
        Me.btnTransportation.Location = New System.Drawing.Point(115, 239)
        Me.btnTransportation.Name = "btnTransportation"
        Me.btnTransportation.Size = New System.Drawing.Size(75, 23)
        Me.btnTransportation.TabIndex = 21
        Me.btnTransportation.Text = "OK"
        Me.btnTransportation.UseVisualStyleBackColor = True
        '
        'cmbTo
        '
        Me.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(182, 128)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTo.TabIndex = 20
        '
        'cmbFrom
        '
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(182, 82)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(121, 21)
        Me.cmbFrom.TabIndex = 19
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(182, 47)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(83, 20)
        Me.txtNumber.TabIndex = 18
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(91, 167)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(30, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Time"
        '
        'timeTransportation
        '
        Me.timeTransportation.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeTransportation.Location = New System.Drawing.Point(182, 167)
        Me.timeTransportation.Name = "timeTransportation"
        Me.timeTransportation.ShowUpDown = True
        Me.timeTransportation.Size = New System.Drawing.Size(200, 20)
        Me.timeTransportation.TabIndex = 16
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(91, 131)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 15
        Me.lblTo.Text = "To"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(91, 90)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 14
        Me.lblFrom.Text = "From"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(88, 47)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(44, 13)
        Me.lblNumber.TabIndex = 13
        Me.lblNumber.Text = "Number"
        '
        'TransportationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(428, 282)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTransportation)
        Me.Controls.Add(Me.cmbTo)
        Me.Controls.Add(Me.cmbFrom)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.timeTransportation)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "TransportationForm"
        Me.Text = "TransportationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtPrice As System.Windows.Forms.TextBox
    Private WithEvents lblPrice As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnTransportation As System.Windows.Forms.Button
    Private WithEvents cmbTo As System.Windows.Forms.ComboBox
    Private WithEvents cmbFrom As System.Windows.Forms.ComboBox
    Private WithEvents txtNumber As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents timeTransportation As System.Windows.Forms.DateTimePicker
    Private WithEvents lblTo As System.Windows.Forms.Label
    Private WithEvents lblFrom As System.Windows.Forms.Label
    Private WithEvents lblNumber As System.Windows.Forms.Label
End Class
