'Name:Richardson Solution
'Purpose:Calulate Prperty Tax
'Programmer:Jarvier Pitchford


Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtAssessed.TextChanged

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Lbltax.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TxtAssessed.Text = String.Empty
        Lbltax.Text = String.Empty
        TxtAssessed.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Lbltax.Text = 150 / Val(TxtAssessed.Text)
        Lbltax.Text = Format(Lbltax.Text, "currency")

    End Sub
End Class
