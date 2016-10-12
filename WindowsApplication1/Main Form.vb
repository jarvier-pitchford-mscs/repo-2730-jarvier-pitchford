'Name:Cranston Berries
'Purpose:Calulate Prperty Tax
'Programmer:Jarvier Pitchford on 9/14/2017

Option Explicit On
Option Strict On
Option Infer Off

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
        'Calulate to get Projected Sales

        Const decProj_Increase As Decimal = 0.05D
        Dim decStraw As Decimal
        Dim decBlue As Decimal
        Dim decRasp As Decimal
        Dim decProj_Straw As Decimal
        Dim decProj_Blue As Decimal
        Dim decProj_Rasp As Decimal

        'Calculate the Strawberries Projected Sales

        Decimal.TryParse(txtStraw.Text, decStraw)
        Decimal.TryParse(txtProjincrease.Text, decProj_Increase)
        Decimal.TryParse(lblProjStraw.Text, decProj_Straw)
        decProj_Straw = decProj_Increase * decStraw
        lblProjStraw.Text = decProj_Straw.ToString("C2")

        'Calculate the BlueBerries Projected Sales
        Decimal.TryParse(txtBlue.Text, decBlue)
        Decimal.TryParse(lblProjBlue.Text, decProj_Blue)
        decProj_Blue = decProj_Increase * decBlue
        lblProjBlue.Text = decProj_Blue.ToString("C2")

        'Calculate the Raspberries Projected Sales
        Decimal.TryParse(txtRasp.Text, decRasp)
        Decimal.TryParse(lblProjRasp.Text, decProj_Rasp)
        decProj_Rasp = decProj_Increase * decRasp
        lblProjRasp.Text = decProj_Rasp.ToString("C2")
    End Sub

    Private Sub txtProjincrease_TextChanged(sender As Object, e As EventArgs) _
        Handles txtProjincrease.TextChanged

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmRetirement.Show()
    End Sub
End Class
