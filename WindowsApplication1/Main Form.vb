'Name:Cranston Berries
'Purpose:Calulate Prperty Tax
'Programmer:Jarvier Pitchford on 9/14/2017

Option Strict On


Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRasp.Text = String.Empty
        txtProjincrease.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblProjStraw.Text = Format((1 + Val(txtProjincrease.Text)) * Val(txtStraw.Text), "currency")
        lblProjBlue.Text = Format((1 + Val(txtProjincrease.Text)) * Val(txtBlue.Text), "currency")
        lblProjRasp.Text = Format((1 + Val(txtProjincrease.Text)) * Val(txtRasp.Text), "currency")
    End Sub
End Class
