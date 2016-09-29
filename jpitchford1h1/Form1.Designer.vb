<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Lblpayrate = New System.Windows.Forms.Label()
        Me.Lblhour = New System.Windows.Forms.Label()
        Me.Lblname = New System.Windows.Forms.Label()
        Me.TxtPayrate = New System.Windows.Forms.TextBox()
        Me.TxtHours = New System.Windows.Forms.TextBox()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.LblNet = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.LblState = New System.Windows.Forms.Label()
        Me.LblFICA = New System.Windows.Forms.Label()
        Me.LblFWT = New System.Windows.Forms.Label()
        Me.Lblgross = New System.Windows.Forms.Label()
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btncalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lblpayrate
        '
        Me.Lblpayrate.AutoSize = True
        Me.Lblpayrate.Location = New System.Drawing.Point(485, 28)
        Me.Lblpayrate.Name = "Lblpayrate"
        Me.Lblpayrate.Size = New System.Drawing.Size(49, 13)
        Me.Lblpayrate.TabIndex = 37
        Me.Lblpayrate.Text = "Pay &rate:"
        '
        'Lblhour
        '
        Me.Lblhour.AutoSize = True
        Me.Lblhour.Location = New System.Drawing.Point(374, 28)
        Me.Lblhour.Name = "Lblhour"
        Me.Lblhour.Size = New System.Drawing.Size(38, 13)
        Me.Lblhour.TabIndex = 36
        Me.Lblhour.Text = "&Hours:"
        '
        'Lblname
        '
        Me.Lblname.AutoSize = True
        Me.Lblname.Location = New System.Drawing.Point(91, 28)
        Me.Lblname.Name = "Lblname"
        Me.Lblname.Size = New System.Drawing.Size(38, 13)
        Me.Lblname.TabIndex = 35
        Me.Lblname.Text = "&Name:"
        '
        'TxtPayrate
        '
        Me.TxtPayrate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPayrate.Location = New System.Drawing.Point(488, 55)
        Me.TxtPayrate.Name = "TxtPayrate"
        Me.TxtPayrate.Size = New System.Drawing.Size(70, 27)
        Me.TxtPayrate.TabIndex = 3
        '
        'TxtHours
        '
        Me.TxtHours.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHours.Location = New System.Drawing.Point(377, 54)
        Me.TxtHours.Name = "TxtHours"
        Me.TxtHours.Size = New System.Drawing.Size(70, 27)
        Me.TxtHours.TabIndex = 2
        '
        'Txtname
        '
        Me.Txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtname.Location = New System.Drawing.Point(94, 55)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(251, 27)
        Me.Txtname.TabIndex = 1
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Location = New System.Drawing.Point(485, 100)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(27, 13)
        Me.Lbl5.TabIndex = 34
        Me.Lbl5.Text = "Net:"
        '
        'LblNet
        '
        Me.LblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNet.Location = New System.Drawing.Point(488, 131)
        Me.LblNet.Name = "LblNet"
        Me.LblNet.Size = New System.Drawing.Size(86, 31)
        Me.LblNet.TabIndex = 33
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Location = New System.Drawing.Point(358, 100)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(35, 13)
        Me.Lbl4.TabIndex = 32
        Me.Lbl4.Text = "State:"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Location = New System.Drawing.Point(237, 100)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(33, 13)
        Me.Lbl3.TabIndex = 30
        Me.Lbl3.Text = "FICA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "FWT:"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(7, 100)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(37, 13)
        Me.Lbl.TabIndex = 26
        Me.Lbl.Text = "Gross:"
        '
        'LblState
        '
        Me.LblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblState.Location = New System.Drawing.Point(361, 131)
        Me.LblState.Name = "LblState"
        Me.LblState.Size = New System.Drawing.Size(86, 31)
        Me.LblState.TabIndex = 31
        '
        'LblFICA
        '
        Me.LblFICA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFICA.Location = New System.Drawing.Point(240, 131)
        Me.LblFICA.Name = "LblFICA"
        Me.LblFICA.Size = New System.Drawing.Size(86, 31)
        Me.LblFICA.TabIndex = 29
        '
        'LblFWT
        '
        Me.LblFWT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFWT.Location = New System.Drawing.Point(124, 131)
        Me.LblFWT.Name = "LblFWT"
        Me.LblFWT.Size = New System.Drawing.Size(86, 31)
        Me.LblFWT.TabIndex = 27
        '
        'Lblgross
        '
        Me.Lblgross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblgross.Location = New System.Drawing.Point(10, 131)
        Me.Lblgross.Name = "Lblgross"
        Me.Lblgross.Size = New System.Drawing.Size(81, 31)
        Me.Lblgross.TabIndex = 25
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(403, 183)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(119, 40)
        Me.Btnexit.TabIndex = 6
        Me.Btnexit.Text = "E&xit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(240, 183)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(119, 40)
        Me.Btnclear.TabIndex = 5
        Me.Btnclear.Text = "C&lear"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Btncalc
        '
        Me.Btncalc.Location = New System.Drawing.Point(75, 183)
        Me.Btncalc.Name = "Btncalc"
        Me.Btncalc.Size = New System.Drawing.Size(119, 40)
        Me.Btncalc.TabIndex = 4
        Me.Btncalc.Text = "&Calculate"
        Me.Btncalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 251)
        Me.Controls.Add(Me.Lblpayrate)
        Me.Controls.Add(Me.Lblhour)
        Me.Controls.Add(Me.Lblname)
        Me.Controls.Add(Me.TxtPayrate)
        Me.Controls.Add(Me.TxtHours)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.LblNet)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.LblState)
        Me.Controls.Add(Me.LblFICA)
        Me.Controls.Add(Me.LblFWT)
        Me.Controls.Add(Me.Lblgross)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btncalc)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblpayrate As Label
    Friend WithEvents Lblhour As Label
    Friend WithEvents Lblname As Label
    Friend WithEvents TxtPayrate As TextBox
    Friend WithEvents TxtHours As TextBox
    Friend WithEvents Txtname As TextBox
    Friend WithEvents Lbl5 As Label
    Friend WithEvents LblNet As Label
    Friend WithEvents Lbl4 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents LblState As Label
    Friend WithEvents LblFICA As Label
    Friend WithEvents LblFWT As Label
    Friend WithEvents Lblgross As Label
    Friend WithEvents Btnexit As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btncalc As Button
End Class
