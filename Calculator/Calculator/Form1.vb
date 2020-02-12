﻿Public Class frmCalculator
    Dim firstNum, secondNum, result As Double

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        'Dim firstNum, secondNum, result As Double
        'first we create some variables for inputs that will hold the first/second numbers and the result
        'Double because we can use decimal numbers, and not just integers 
        'As we code the other events, we can see these local variables are being repeated for each event. In order to use them in all the click-events we declare them as "form-level" variables. So we can get rid of these in all three event operations and place them right after Public Class frmCalculator


        'first, we make sure the user entered something into the textboxes
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            'then we can assign values from txtbox into our variable
            'firstNum = txtFirst.Text
            'if user entered a valid number, there'd be no problem. it would be implicitly converted into a Double and assigned to firstNum; however, it is HIGHLY RECOMMENDED to do an explicit conversion to a string and make it a Double/Integer. We can do this here by wrapping txtFirst.Text in a Cdbl() conversion method
            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)

            'now we can get our variable result to hold the added values of firstNum and secondNum
            result = firstNum + secondNum
            'output the result
            txtResults.Text = "The result of " & firstNum & " + " & secondNum & " = " & result & "."
        End If

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        'Dim firstNum, secondNum, result As Double
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)

            result = firstNum - secondNum
            txtResults.Text = "The result of " & firstNum & " - " & secondNum & " = " & result & "."
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'Dim firstNum, secondNum, result As Double
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)

            result = firstNum * secondNum
            txtResults.Text = "The result of " & firstNum & " x " & secondNum & " = " & result & "."
        End If
    End Sub
End Class
