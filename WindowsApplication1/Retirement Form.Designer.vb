<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRetirement
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
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblTot = New System.Windows.Forms.Label()
        Me.LblEmployer = New System.Windows.Forms.Label()
        Me.LblEmployee = New System.Windows.Forms.Label()
        Me.TxtEmployerRate = New System.Windows.Forms.TextBox()
        Me.TxtEmlpyeeRate = New System.Windows.Forms.TextBox()
        Me.TxtGross = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(218, 272)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(107, 44)
        Me.BtnCalc.TabIndex = 0
        Me.BtnCalc.Text = "&Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(342, 272)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(107, 44)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblTot
        '
        Me.LblTot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTot.Location = New System.Drawing.Point(342, 213)
        Me.LblTot.Name = "LblTot"
        Me.LblTot.Size = New System.Drawing.Size(118, 35)
        Me.LblTot.TabIndex = 6
        '
        'LblEmployer
        '
        Me.LblEmployer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmployer.Location = New System.Drawing.Point(342, 167)
        Me.LblEmployer.Name = "LblEmployer"
        Me.LblEmployer.Size = New System.Drawing.Size(118, 35)
        Me.LblEmployer.TabIndex = 5
        '
        'LblEmployee
        '
        Me.LblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmployee.Location = New System.Drawing.Point(342, 124)
        Me.LblEmployee.Name = "LblEmployee"
        Me.LblEmployee.Size = New System.Drawing.Size(118, 35)
        Me.LblEmployee.TabIndex = 4
        '
        'TxtEmployerRate
        '
        Me.TxtEmployerRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmployerRate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmployerRate.Location = New System.Drawing.Point(392, 85)
        Me.TxtEmployerRate.Name = "TxtEmployerRate"
        Me.TxtEmployerRate.Size = New System.Drawing.Size(68, 27)
        Me.TxtEmployerRate.TabIndex = 3
        Me.TxtEmployerRate.Text = "0.07"
        Me.TxtEmployerRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtEmlpyeeRate
        '
        Me.TxtEmlpyeeRate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmlpyeeRate.Location = New System.Drawing.Point(392, 46)
        Me.TxtEmlpyeeRate.Name = "TxtEmlpyeeRate"
        Me.TxtEmlpyeeRate.Size = New System.Drawing.Size(68, 27)
        Me.TxtEmlpyeeRate.TabIndex = 2
        Me.TxtEmlpyeeRate.Text = "0.05"
        Me.TxtEmlpyeeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGross
        '
        Me.TxtGross.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGross.Location = New System.Drawing.Point(310, 12)
        Me.TxtGross.Name = "TxtGross"
        Me.TxtGross.Size = New System.Drawing.Size(150, 27)
        Me.TxtGross.TabIndex = 1
        Me.TxtGross.Text = "1000"
        Me.TxtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total annual contribution"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Employer annual contribution"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Employee annual contribution"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(325, 27)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Employer contribution rate (decimal form):"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(325, 27)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "&Employee contribution rate (decimal form):"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 27)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "&Gross weekly pay"
        '
        'FrmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 331)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGross)
        Me.Controls.Add(Me.TxtEmlpyeeRate)
        Me.Controls.Add(Me.TxtEmployerRate)
        Me.Controls.Add(Me.LblEmployee)
        Me.Controls.Add(Me.LblEmployer)
        Me.Controls.Add(Me.LblTot)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmRetirement"
        Me.Text = "Retirement_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblTot As Label
    Friend WithEvents LblEmployer As Label
    Friend WithEvents LblEmployee As Label
    Friend WithEvents TxtEmployerRate As TextBox
    Friend WithEvents TxtEmlpyeeRate As TextBox
    Friend WithEvents TxtGross As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
