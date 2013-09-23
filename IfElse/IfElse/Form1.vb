Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double
        ' if user did the wrong thing, then MsgBox eliminate them
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: Please type a number!", "Error")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        ' if user did the wrong thing, then MsgBox eliminate them
        If num1 < 0 And num2 < 0 Then
            MessageBox.Show("Error: Please type a  POSITIVE number!", "Error")
            Return
        End If

        'sterile area
        If (num1 > num2) Then
            txtResult.Text = "The larger number is " & num1
        ElseIf (num2 > num1) Then
            txtResult.Text = "The larger number is " & num2
        Else : txtResult.Text = "The two are equal."
        End If


    End Sub

 
End Class
