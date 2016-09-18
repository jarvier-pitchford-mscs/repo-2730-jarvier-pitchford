'Name:Average Test Score
'Purpose:Calulate Test Score
'Programmer:Jarvier Pitchford on 9/14/2017

Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtscore1.Text = String.Empty
        txtscore2.Text = String.Empty
        txtscore3.Text = String.Empty
        lblAvg.Text = String.Empty
        txtscore1.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblAvg.Text = Format(Val(CDbl(((txtscore1.Text))) + Val(txtscore2.Text) + Val(txtscore3.Text)) / 3),"fixed"
    End Sub
End Class
