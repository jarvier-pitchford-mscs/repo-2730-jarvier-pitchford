﻿Public Class Frmpro

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FrmStarWars.Show()
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Frmtucan.Show()
        Timer2.Enabled = False

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Close()

    End Sub
End Class
