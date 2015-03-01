Public Class Form1

    'Used to keep track of the last number we entered into the calculator
    Dim FirstNumber As Long
    Dim Operation As String
    Private Sub n1_Click(sender As Object, e As EventArgs) Handles n1.Click
        'FOR THE PRIVATE SUB CALL:
        'Private Sub = defines a subroutine.
        'n1_click = is the name of the subroutine.
        '(sender As Object, e As EventArgs) = arguments.
        'Handles n1.click = defines when the n1 is actually clicked
        '<======================================>

        'When "1" which has the 'name: "n1" is clicked. The textbox named "LCD" inserts "1" into the box
        If LCD.Text = "0" Then
            LCD.Text = "1"
        Else
            LCD.Text = LCD.Text & "1"
        End If
    End Sub

    Private Sub n2_Click(sender As Object, e As EventArgs) Handles n2.Click
        If LCD.Text = "0" Then
            LCD.Text = "2"
        Else
            LCD.Text = LCD.Text & "2"
        End If
    End Sub

    Private Sub n3_Click(sender As Object, e As EventArgs) Handles n3.Click
        If LCD.Text = "0" Then
            LCD.Text = "3"
        Else
            LCD.Text = LCD.Text & "3"
        End If
    End Sub

    Private Sub n4_Click(sender As Object, e As EventArgs) Handles n4.Click
        If LCD.Text = "0" Then
            LCD.Text = "4"
        Else
            LCD.Text = LCD.Text & "4"
        End If
    End Sub

    Private Sub n5_Click(sender As Object, e As EventArgs) Handles n5.Click
        If LCD.Text = "0" Then
            LCD.Text = "5"
        Else
            LCD.Text = LCD.Text & "5"
        End If
    End Sub

    Private Sub n6_Click(sender As Object, e As EventArgs) Handles n6.Click
        If LCD.Text = "0" Then
            LCD.Text = "6"
        Else
            LCD.Text = LCD.Text & "6"
        End If
    End Sub

    Private Sub n7_Click(sender As Object, e As EventArgs) Handles n7.Click
        If LCD.Text = "0" Then
            LCD.Text = "7"
        Else
            LCD.Text = LCD.Text & "7"
        End If
    End Sub

    Private Sub n8_Click(sender As Object, e As EventArgs) Handles n8.Click
        If LCD.Text = "0" Then
            LCD.Text = "8"
        Else
            LCD.Text = LCD.Text & "8"
        End If
    End Sub

    Private Sub n9_Click(sender As Object, e As EventArgs) Handles n9.Click
        If LCD.Text = "0" Then
            LCD.Text = "9"
        Else
            LCD.Text = LCD.Text & "9"
        End If
    End Sub

    Private Sub n0_Click(sender As Object, e As EventArgs) Handles n0.Click
        If LCD.Text = "0" Then
            LCD.Text = "0"
        Else
            LCD.Text = LCD.Text & "0"
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        LCD.Text = "0"
    End Sub

    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click
        Dim SecondNumber As Long
        Dim Result As Long

        SecondNumber = LCD.Text

        If Operation = "+" Then
            Result = FirstNumber + SecondNumber
        ElseIf Operation = "-" Then
            Result = FirstNumber - SecondNumber
        ElseIf Operation = "*" Then
            Result = FirstNumber * SecondNumber
        ElseIf Operation = "/" Then
            Result = FirstNumber / SecondNumber
        End If

        FirstNumber = Result
        LCD.Text = Result

    End Sub
    Private Sub addition_Click(sender As Object, e As EventArgs) Handles addition.Click       
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "+"
    End Sub
    Private Sub subtraction_Click(sender As Object, e As EventArgs) Handles subtraction.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "-"
    End Sub
    Private Sub multiplication_Click(sender As Object, e As EventArgs) Handles multiplication.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "*"
    End Sub
    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "/"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles credits.Click
        MessageBox.Show("Created by Cortland Walker" & vbNewLine & "Resources Used:" & vbNewLine & "VB.NET PRogramming by: mkaatr (2010) ")
    End Sub
End Class


