﻿' Name:         Bakery Project
' Purpose:      Calculates the total number of
'               items sold and the total sales
' Programmer:   <Jarvier Pitchford> on <9-28-2016>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    'class-level variable for storing salesclerk's name
    ' Private strClerk As String

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        Const strPrompt As String = "Salesclerk's name:"
        Const strTITLE As String = "Name Entry"
        Const decITEM_PRICE As Decimal = 0.5D
        Const decTAX_RATE As Decimal = 0.02D
        Dim intDounts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal
        Static strClerk As String

        'assign name to class-level variable
        strClerk = InputBox(strPrompt, strTITLE, strClerk)

        Integer.TryParse(txtDonuts.Text, intDounts)
        Integer.TryParse(txtMuffins.Text, intMuffins)

        intTotalItems = intDounts + intMuffins

        'calculate the subtotal
        decSubtotal = intTotalItems * decITEM_PRICE

        'calculate the sales tax
        decSalesTax = decSubtotal * decTAX_RATE

        'calculate the total sales
        decTotalSales = decSubtotal + decSalesTax

        'display total amounts
        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = decTotalSales.ToString("C2")

        'display tax and salesclerk's name
        lblMsg.Text = "The Sales tax was" &
            decSalesTax.ToString("C2") & "." &
            ControlChars.NewLine & strClerk

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'get the salesclerk's name

        ' Const strPrompt As String = "Salesclerk's name:"
        ' Const strTITLE As String = "Name Entry"
        'assign name to class-level variable
        'strClerk = InputBox(strPrompt, strTITLE)

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtDonuts.TextChanged, txtMuffins.TextChanged
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
    End Sub
End Class
