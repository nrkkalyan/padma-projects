<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectTimeForm
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lstSelectedTime = New System.Windows.Forms.ListBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(267, 358)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(437, 358)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lstSelectedTime
        '
        Me.lstSelectedTime.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelectedTime.FormattingEnabled = True
        Me.lstSelectedTime.ItemHeight = 14
        Me.lstSelectedTime.Location = New System.Drawing.Point(66, 80)
        Me.lstSelectedTime.Name = "lstSelectedTime"
        Me.lstSelectedTime.Size = New System.Drawing.Size(658, 256)
        Me.lstSelectedTime.TabIndex = 5
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(63, 37)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(323, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Please select the time which is suitable for your travel requirements:"
        '
        'SelectTimeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 418)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lstSelectedTime)
        Me.Controls.Add(Me.label1)
        Me.Name = "SelectTimeForm"
        Me.Text = "SelectTimeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnBack As System.Windows.Forms.Button
    Private WithEvents btnContinue As System.Windows.Forms.Button
    Private WithEvents lstSelectedTime As System.Windows.Forms.ListBox
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
