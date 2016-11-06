<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnNested = New System.Windows.Forms.Button()
        Me.btnElseif = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(170, 179)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(81, 27)
        Me.txtQuantity.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Discount:"
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(257, 177)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(81, 29)
        Me.lblDiscount.TabIndex = 7
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total due:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(344, 178)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(81, 29)
        Me.lblTotalDue.TabIndex = 9
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(24, 215)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(86, 32)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(219, 300)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 32)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 125)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount Rates"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = ">20:  3%"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "16-20   2.5%"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "11-15:   2%"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "1-10:   0%"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 125)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sample Results"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 20)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "$10,Qty 30:  $9"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 20)
        Me.Label13.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "$10, Qty 20:   $5"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "10,Qty 15:  $3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "$10,Qty 10:  $0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(85, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "&Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(80, 180)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(81, 27)
        Me.txtPrice.TabIndex = 1
        '
        'btnNested
        '
        Me.btnNested.Location = New System.Drawing.Point(116, 215)
        Me.btnNested.Name = "btnNested"
        Me.btnNested.Size = New System.Drawing.Size(144, 32)
        Me.btnNested.TabIndex = 11
        Me.btnNested.Text = "Calc Nested If"
        Me.btnNested.UseVisualStyleBackColor = True
        '
        'btnElseif
        '
        Me.btnElseif.Location = New System.Drawing.Point(266, 215)
        Me.btnElseif.Name = "btnElseif"
        Me.btnElseif.Size = New System.Drawing.Size(128, 32)
        Me.btnElseif.TabIndex = 12
        Me.btnElseif.Text = "Calc If- ElseIf"
        Me.btnElseif.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(400, 215)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(122, 32)
        Me.btnSelect.TabIndex = 13
        Me.btnSelect.Text = "Calc-Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 346)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnElseif)
        Me.Controls.Add(Me.btnNested)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label15)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jetters"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnNested As Button
    Friend WithEvents btnElseif As Button
    Friend WithEvents btnSelect As Button
End Class
