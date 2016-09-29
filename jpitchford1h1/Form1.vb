'Name:      Photo Project
'Purpose:   Displays the gross pay,FWT,FICA,State,and Net pay
'Programmer: Jarvier Pitchford on 9-23-2016


Option Strict On

Public Class Form1
    Private Sub Btncalc_Click(sender As Object, e As EventArgs) Handles Btncalc.Click
        'Calulate gross, witholdings and net pay
        Lblgross.Text = Format(Val(TxtHours.Text) * Val(TxtPayrate.Text), "fixed")
        LblFWT.Text = Format(Val(Lblgross.Text) * 0.2, "fixed")
        LblFICA.Text = Format(Val(Lblgross.Text) * 0.8, "fixed")
        LblState.Text = Format(Val(Lblgross.Text) * 0.3, "fixed")
        LblNet.Text = Format(Val(Lblgross.Text) + Val(LblFWT.Text) - Val(LblFICA.Text) - Val(LblState.Text), "fixed")
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        TxtHours.Text = String.Empty
        TxtPayrate.Text = String.Empty
        Lblgross.Text = String.Empty
        LblFWT.Text = String.Empty
        LblState.Text = String.Empty
        LblNet.Text = String.Empty
        LblFICA.Text = String.Empty
        Txtname.Focus()

    End Sub
End Class
