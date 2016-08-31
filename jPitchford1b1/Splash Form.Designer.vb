<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.lblNmae = New System.Windows.Forms.Label()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picStorks = New System.Windows.Forms.PictureBox()
        Me.piclguanas = New System.Windows.Forms.PictureBox()
        Me.tmrExit = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picStorks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclguanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNmae
        '
        Me.lblNmae.AutoSize = True
        Me.lblNmae.BackColor = System.Drawing.Color.ForestGreen
        Me.lblNmae.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNmae.Location = New System.Drawing.Point(180, 70)
        Me.lblNmae.Name = "lblNmae"
        Me.lblNmae.Size = New System.Drawing.Size(111, 21)
        Me.lblNmae.TabIndex = 0
        Me.lblNmae.Text = "Crighton Zoo"
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.BackColor = System.Drawing.Color.ForestGreen
        Me.lblmsg.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.Red
        Me.lblmsg.Location = New System.Drawing.Point(180, 115)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(183, 21)
        Me.lblmsg.TabIndex = 1
        Me.lblmsg.Text = "Come visit our residents"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 282)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 4
        '
        'picStorks
        '
        Me.picStorks.Image = Global.jPitchford1b1.My.Resources.Resources.Storks
        Me.picStorks.Location = New System.Drawing.Point(192, 139)
        Me.picStorks.Name = "picStorks"
        Me.picStorks.Size = New System.Drawing.Size(171, 152)
        Me.picStorks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStorks.TabIndex = 5
        Me.picStorks.TabStop = False
        '
        'piclguanas
        '
        Me.piclguanas.Image = Global.jPitchford1b1.My.Resources.Resources.Iguanas
        Me.piclguanas.Location = New System.Drawing.Point(3, 9)
        Me.piclguanas.Name = "piclguanas"
        Me.piclguanas.Size = New System.Drawing.Size(171, 152)
        Me.piclguanas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclguanas.TabIndex = 3
        Me.piclguanas.TabStop = False
        '
        'tmrExit
        '
        Me.tmrExit.Enabled = True
        Me.tmrExit.Interval = 4000
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.picStorks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.piclguanas)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.lblNmae)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picStorks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclguanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNmae As Label
    Friend WithEvents lblmsg As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents piclguanas As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picStorks As PictureBox
    Friend WithEvents tmrExit As Timer
End Class
