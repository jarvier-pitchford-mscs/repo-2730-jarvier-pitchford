' Nmae:      Bakery Project
' Purpose:   Calulate the total number of
'            items sold and the total sales
' Programmer: <Jarvier Pitchford> on < 9/7/2016>

Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        '  prepare Screen for the next sale 
        txtDonuts.Text = String.Empty
        Txtmuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty

        '   send the focus to the Doughnuts box
        txtDonuts.Focus()


    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        lblTotalItems.Text = Format(Val(txtDonuts.Text) + Val(Txtmuffins.Text), "0")
        lblTotalSales.Text = Format(Val(lblTotalItems.Text) * 0.5, "currency")
        'lblTotalSales.Text = Format(lblTotalSales.Text, "currency")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
