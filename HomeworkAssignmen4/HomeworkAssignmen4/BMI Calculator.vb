
Option Strict On
Public Class Form1
    'Declare the new object
    Private BMICalculator As Calculator
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles HeightLabel.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        Try
            'instantiate the object
            BMICalculator = New Calculator
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        WeightTextBox.Clear()
        HeightTextBox.Clear()
        BMITextBox.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'exit the program
        Me.Close()
    End Sub
End Class
