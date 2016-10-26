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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRAND_RATE = New System.Windows.Forms.Label()
        Me.lblPOUND_RATE = New System.Windows.Forms.Label()
        Me.lblEURO_RATE = New System.Windows.Forms.Label()
        Me.lblAmDollar = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.btnConvertNE = New System.Windows.Forms.Button()
        Me.btnConvertEq = New System.Windows.Forms.Button()
        Me.txtAmDollar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.txtPricelb = New System.Windows.Forms.TextBox()
        Me.btnCalcTea = New System.Windows.Forms.Button()
        Me.lblTotDue = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Lblp = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPrevious = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.btnCalElt = New System.Windows.Forms.Button()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.Txtnum2 = New System.Windows.Forms.TextBox()
        Me.btnCalcQuo = New System.Windows.Forms.Button()
        Me.lblQuo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRAND_RATE)
        Me.GroupBox1.Controls.Add(Me.lblPOUND_RATE)
        Me.GroupBox1.Controls.Add(Me.lblEURO_RATE)
        Me.GroupBox1.Controls.Add(Me.lblAmDollar)
        Me.GroupBox1.Controls.Add(Me.lblRand)
        Me.GroupBox1.Controls.Add(Me.lblPound)
        Me.GroupBox1.Controls.Add(Me.lblEuro)
        Me.GroupBox1.Controls.Add(Me.btnConvertNE)
        Me.GroupBox1.Controls.Add(Me.btnConvertEq)
        Me.GroupBox1.Controls.Add(Me.txtAmDollar)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Page 231 #1Currency Converter"
        '
        'lblRAND_RATE
        '
        Me.lblRAND_RATE.AutoSize = True
        Me.lblRAND_RATE.Location = New System.Drawing.Point(479, 27)
        Me.lblRAND_RATE.Name = "lblRAND_RATE"
        Me.lblRAND_RATE.Size = New System.Drawing.Size(114, 13)
        Me.lblRAND_RATE.TabIndex = 8
        Me.lblRAND_RATE.Text = "South American &Rand:"
        '
        'lblPOUND_RATE
        '
        Me.lblPOUND_RATE.Location = New System.Drawing.Point(341, 18)
        Me.lblPOUND_RATE.Name = "lblPOUND_RATE"
        Me.lblPOUND_RATE.Size = New System.Drawing.Size(100, 23)
        Me.lblPOUND_RATE.TabIndex = 7
        Me.lblPOUND_RATE.Text = "British poun&d:"
        Me.lblPOUND_RATE.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblEURO_RATE
        '
        Me.lblEURO_RATE.Location = New System.Drawing.Point(208, 16)
        Me.lblEURO_RATE.Name = "lblEURO_RATE"
        Me.lblEURO_RATE.Size = New System.Drawing.Size(100, 23)
        Me.lblEURO_RATE.TabIndex = 6
        Me.lblEURO_RATE.Text = "Eu&ros:"
        Me.lblEURO_RATE.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAmDollar
        '
        Me.lblAmDollar.AutoSize = True
        Me.lblAmDollar.Location = New System.Drawing.Point(12, 22)
        Me.lblAmDollar.Name = "lblAmDollar"
        Me.lblAmDollar.Size = New System.Drawing.Size(84, 13)
        Me.lblAmDollar.TabIndex = 1
        Me.lblAmDollar.Text = "American &Dollar:"
        '
        'lblRand
        '
        Me.lblRand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRand.Location = New System.Drawing.Point(479, 40)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(112, 36)
        Me.lblRand.TabIndex = 5
        '
        'lblPound
        '
        Me.lblPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPound.Location = New System.Drawing.Point(344, 41)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(112, 36)
        Me.lblPound.TabIndex = 4
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(211, 40)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(112, 36)
        Me.lblEuro.TabIndex = 3
        '
        'btnConvertNE
        '
        Me.btnConvertNE.Location = New System.Drawing.Point(113, 72)
        Me.btnConvertNE.Name = "btnConvertNE"
        Me.btnConvertNE.Size = New System.Drawing.Size(75, 28)
        Me.btnConvertNE.TabIndex = 2
        Me.btnConvertNE.Text = "Convert <>"
        Me.btnConvertNE.UseVisualStyleBackColor = True
        '
        'btnConvertEq
        '
        Me.btnConvertEq.Location = New System.Drawing.Point(113, 38)
        Me.btnConvertEq.Name = "btnConvertEq"
        Me.btnConvertEq.Size = New System.Drawing.Size(75, 28)
        Me.btnConvertEq.TabIndex = 1
        Me.btnConvertEq.Text = "Convert ="
        Me.btnConvertEq.UseVisualStyleBackColor = True
        '
        'txtAmDollar
        '
        Me.txtAmDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmDollar.Location = New System.Drawing.Point(13, 38)
        Me.txtAmDollar.Name = "txtAmDollar"
        Me.txtAmDollar.Size = New System.Drawing.Size(94, 24)
        Me.txtAmDollar.TabIndex = 0
        Me.txtAmDollar.Text = "100"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lblp)
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.lbltotal)
        Me.GroupBox2.Controls.Add(Me.lblTotDue)
        Me.GroupBox2.Controls.Add(Me.btnCalcTea)
        Me.GroupBox2.Controls.Add(Me.txtPricelb)
        Me.GroupBox2.Controls.Add(Me.txtPounds)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(494, 98)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "page 231#3 Tea Time"
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(15, 44)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(100, 22)
        Me.txtPounds.TabIndex = 0
        '
        'txtPricelb
        '
        Me.txtPricelb.Location = New System.Drawing.Point(140, 45)
        Me.txtPricelb.Name = "txtPricelb"
        Me.txtPricelb.Size = New System.Drawing.Size(100, 22)
        Me.txtPricelb.TabIndex = 1
        '
        'btnCalcTea
        '
        Me.btnCalcTea.Location = New System.Drawing.Point(260, 36)
        Me.btnCalcTea.Name = "btnCalcTea"
        Me.btnCalcTea.Size = New System.Drawing.Size(91, 30)
        Me.btnCalcTea.TabIndex = 2
        Me.btnCalcTea.Text = "Calculate"
        Me.btnCalcTea.UseVisualStyleBackColor = True
        '
        'lblTotDue
        '
        Me.lblTotDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotDue.Location = New System.Drawing.Point(377, 36)
        Me.lblTotDue.Name = "lblTotDue"
        Me.lblTotDue.Size = New System.Drawing.Size(111, 31)
        Me.lblTotDue.TabIndex = 3
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(374, 18)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(70, 16)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "Total Due:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(140, 20)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(57, 16)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Price/lb:"
        '
        'Lblp
        '
        Me.Lblp.AutoSize = True
        Me.Lblp.Location = New System.Drawing.Point(15, 20)
        Me.Lblp.Name = "Lblp"
        Me.Lblp.Size = New System.Drawing.Size(54, 16)
        Me.Lblp.TabIndex = 6
        Me.Lblp.Text = "Pounds"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblBill)
        Me.GroupBox3.Controls.Add(Me.btnCalElt)
        Me.GroupBox3.Controls.Add(Me.txtCurrent)
        Me.GroupBox3.Controls.Add(Me.txtPrevious)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(494, 78)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "pg 132Tri County Project electric"
        '
        'txtPrevious
        '
        Me.txtPrevious.Location = New System.Drawing.Point(7, 46)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(100, 22)
        Me.txtPrevious.TabIndex = 0
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(129, 46)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(100, 22)
        Me.txtCurrent.TabIndex = 1
        '
        'btnCalElt
        '
        Me.btnCalElt.Location = New System.Drawing.Point(246, 35)
        Me.btnCalElt.Name = "btnCalElt"
        Me.btnCalElt.Size = New System.Drawing.Size(105, 33)
        Me.btnCalElt.TabIndex = 2
        Me.btnCalElt.Text = "Calculate"
        Me.btnCalElt.UseVisualStyleBackColor = True
        '
        'lblBill
        '
        Me.lblBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBill.Location = New System.Drawing.Point(367, 35)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(97, 32)
        Me.lblBill.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Previous:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Current:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Monthly Bill:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lblQuo)
        Me.GroupBox4.Controls.Add(Me.btnCalcQuo)
        Me.GroupBox4.Controls.Add(Me.Txtnum2)
        Me.GroupBox4.Controls.Add(Me.txtnum1)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 296)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(494, 70)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(7, 39)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 0
        '
        'Txtnum2
        '
        Me.Txtnum2.Location = New System.Drawing.Point(129, 39)
        Me.Txtnum2.Name = "Txtnum2"
        Me.Txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.Txtnum2.TabIndex = 1
        '
        'btnCalcQuo
        '
        Me.btnCalcQuo.Location = New System.Drawing.Point(246, 28)
        Me.btnCalcQuo.Name = "btnCalcQuo"
        Me.btnCalcQuo.Size = New System.Drawing.Size(105, 34)
        Me.btnCalcQuo.TabIndex = 2
        Me.btnCalcQuo.Text = "Button1"
        Me.btnCalcQuo.UseVisualStyleBackColor = True
        '
        'lblQuo
        '
        Me.lblQuo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuo.Location = New System.Drawing.Point(370, 28)
        Me.lblQuo.Name = "lblQuo"
        Me.lblQuo.Size = New System.Drawing.Size(97, 32)
        Me.lblQuo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "First#"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Second#"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(370, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Quotient:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 422)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "If Else Statements"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPound As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents btnConvertNE As Button
    Friend WithEvents btnConvertEq As Button
    Friend WithEvents txtAmDollar As TextBox
    Friend WithEvents lblEURO_RATE As Label
    Friend WithEvents lblAmDollar As Label
    Friend WithEvents lblRand As Label
    Friend WithEvents lblRAND_RATE As Label
    Friend WithEvents lblPOUND_RATE As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lblp As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblTotDue As Label
    Friend WithEvents btnCalcTea As Button
    Friend WithEvents txtPricelb As TextBox
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBill As Label
    Friend WithEvents btnCalElt As Button
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblQuo As Label
    Friend WithEvents btnCalcQuo As Button
    Friend WithEvents Txtnum2 As TextBox
    Friend WithEvents txtnum1 As TextBox
End Class
