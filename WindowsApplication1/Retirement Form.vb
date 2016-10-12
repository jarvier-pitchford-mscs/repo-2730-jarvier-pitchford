'Name: Retirement Form
'Purpose: Calculate Total Annual Contribution
'Programmer: <Jarvier Pitchford> On <10-1-2016>

Option Explicit On
Option Infer Off
Option Strict On

Public Class FrmRetirement
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblEmployer.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtGross.TextChanged

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click

        'Find Out Total Annual Contribution

        Dim decEmployeeRate As Decimal
        Dim decEmployerRate As Decimal
        Dim decGross As Decimal
        Dim decEmployee As Decimal
        Dim decEmployer As Decimal
        Dim decTotal As Decimal

        'Calculate employee annual contribution

        Decimal.TryParse(TxtGross.Text, decGross)
        Decimal.TryParse(TxtEmlpyeeRate.Text, decEmployeeRate)
        Decimal.TryParse(LblEmployee.Text, decEmployee)
        decEmployee = decEmployeeRate * 52 * decGross
        LblEmployee.Text = decEmployee.ToString("C2")

        'Calulate employee employer annual contriution

        Decimal.TryParse(TxtEmployerRate.Text, decEmployeeRate)
        Decimal.TryParse(LblEmployer.Text, decEmployer)
        decEmployer = decEmployeeRate * 52 * decGross
        LblEmployer.Text = decEmployer.ToString("C2")


        'Calculate the total Contribution

        Decimal.TryParse(LblTot.Text, decTotal)
        decTotal = decEmployer + decEmployee
        LblTot.Text = decTotal.ToString("C2")







    End Sub
End Class