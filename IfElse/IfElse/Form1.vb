﻿Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largernum As Double
        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)
        If num1 < num2 Then largernum = num2 Else largernum = num1
        txtResult.Text = "the larger number is " & largernum
    End Sub

End Class
