'Name :      CH4 Lesson B, If statements, message boxes
'Purpose :   Currency, Tea Electric, Quotient
'Programmer:  <Jarvier Pitchford> on 10/16/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblPound.Click

    End Sub

    Private Sub btnConvertEq_Click(sender As Object, e As EventArgs) Handles btnConvertEq.Click
        'Convert American dollars to the Euro, 
        'the British Pound, And South African Rand


        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double


        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        Double.TryParse(txtAmDollar.Text, dblAmDollar)



        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show("Please enter number of American dollars.", "Currency Converter",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else


            'calulate dollar amount

            dblEuro = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE

            lblPound.Text = dblPOUND_RATE.ToString("c2")
            lblEuro.Text = dblEURO_RATE.ToString("c2")
            lblRand.Text = dblRAND_RATE.ToString("c2")

        End If

    End Sub

    Private Sub btnConvertNE_Click(sender As Object, e As EventArgs) Handles btnConvertNE.Click

        'Convert American dollars to the Euro, 
        'the British Pound, And South African Rand


        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double


        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        Double.TryParse(txtAmDollar.Text, dblAmDollar)


        If txtAmDollar.Text <> String.Empty Then
            MessageBox.Show("Please enter number of American dollars.", "Currency Converter",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dblEuro = dblEURO_RATE * dblAmDollar
            dblPound = dblPOUND_RATE * dblAmDollar
            dblRand = dblRAND_RATE * dblAmDollar

            lblPound.Text = dblPOUND_RATE.ToString("c2")
            lblEuro.Text = dblEURO_RATE.ToString("c2")
            lblRand.Text = dblRAND_RATE.ToString("c2")
        End If
    End Sub

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click
        Dim intPounds As Integer
        Dim intPricelb As Integer
        Dim dblTotDue As Double

        'txtPounds.Text = String.Empty
        'txtPricelb.Text = String.Empty
        'lblTotDue.Text = String.Empty

        Integer.TryParse(txtPounds.Text, intPounds)
        Integer.TryParse(txtPricelb.Text, intPricelb)

        'calculate total amount
        dblTotDue = intPounds * intPricelb

        If MessageBox.Show("Charge for shipping", "Shipping",
           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) =
           DialogResult.Yes Then
            dblTotDue = intPounds * intPricelb + 15

            lblTotDue.Text = dblTotDue.ToString("c2")

        Else  'No Button
            dblTotDue = intPounds * intPricelb

            lblTotDue.Text = dblTotDue.ToString("c2")


        End If

    End Sub

    Private Sub btnCalElt_Click(sender As Object, e As EventArgs) Handles btnCalElt.Click
        Const decMONTHLY_RATE As Decimal = 0.13D
        Dim dblPrevious As Double
        Dim dblCurrent As Double
        Dim dblBill As Double

        Double.TryParse(txtPrevious.Text, dblPrevious)
        Double.TryParse(txtCurrent.Text, dblCurrent)
        Double.TryParse(lblBill.Text, dblBill)

        'txtCurrent.Text = String.Empty
        'txtPrevious.Text = String.Empty
        'lblBill.Text = String.Empty



        If dblCurrent >= dblPrevious Or txtCurrent.Text = String.Empty Then

            'calculate the total monthly bill

            dblBill = dblCurrent - dblPrevious * decMONTHLY_RATE


            lblBill.Text = dblBill.ToString("c2")

        Else
            'Display Message

            MessageBox.Show("The current reading must be greater or equal to the
                            previous reading", "Triple County", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)


            lblBill.Text = dblBill.ToString("c2")

        End If


    End Sub

    Private Sub btnCalcQuo_Click(sender As Object, e As EventArgs) Handles btnCalcQuo.Click
        Dim intnum1 As Integer
        Dim intnum2 As Integer
        Dim dblQuo As Double

        Integer.TryParse(txtnum1.Text, intnum1)
        Integer.TryParse(Txtnum2.Text, intnum2)
        Double.TryParse(lblQuo.Text, dblQuo)

        'txtnum1.Text = String.Empty
        'Txtnum2.Text = String.Empty
        'lblQuo.Text = String.Empty

        dblQuo = intnum1 / intnum2

        If intnum1 >= intnum2 Then
            Dim intTemp As Integer
            intTemp = intnum1
            intnum1 = intnum2
            intnum2 = intTemp

            lblQuo.Text = dblQuo.ToString("n2")
        End If

        If intnum2 >= intnum1 Then
            Dim intTemp As Integer
            intTemp = intnum2
            intnum2 = intnum1
            intnum1 = intTemp

            lblQuo.Text = dblQuo.ToString("n2")
        End If


    End Sub
End Class
