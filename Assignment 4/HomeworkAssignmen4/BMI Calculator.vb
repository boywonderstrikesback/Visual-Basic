'Mike Ross
'BMI converter 
'4/09/2018


Public Class BMIForm
    'Declare the new object
    Private BMI As Calculator

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        WeightTextBox.Clear()
        HeightTextBox.Clear()
        BMITextBox.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'closes program 
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the boxs for height and weight
        HeightComboBox.SelectedIndex = 0
        WeightComboBox.SelectedIndex = 0
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim BMI As Double
        Dim HeightString As String 
        Dim WeightString As String


        'prints the height and weight
        HeightString = HeightComboBox.SelectedItem.ToString
        WeightString = WeightComboBox.SelectedItem.ToString
       
        Try

            'instantiate the object
    THeBMICalculator = New Calculator(Double.Parse(WeightTextBox.Text),
        Double.Parse(HeightTextBox.Text),HeightString, WeightString)

            BMI = THeBMICalculator.BMITotal
            '
    BMITextBox.Text = BMI.ToString("f1")
             'prints resultss 
        Catch ex As FormatException
            MessageBox.Show("Enter Valid Number")
        
        Catch ex1 As ArgumentOutOfRangeException

        End Try
    End Sub
End Class
