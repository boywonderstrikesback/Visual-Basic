Public Class CoffeCalculator 
    Const Takeout_Rate_Decimal As Decimal=
    ' calculate and display the employee's pay
    Private Sub calculateButton_Click(sender As Object,
       e As EventArgs) Handles calculateButton.Click

        ' get hours worked and hourly wage
        Dim QuanofCoffee As Decimal
        Dim HourlyWageDecimal As Decimal

        Try
            QuanofCoffee = Decimal.Parse(QuanTextBox.Text)

            Try
                HourlyWageDecimal = Decimal.Parse(wageTextBox.Text)

                ' calls DisplayPay Function
                DisplayPay(QuanofCoffee, HourlyWageDecimal)

            Catch QuanException As FormatException
                MessageBox.Show("Must Enter Valid Quanitiy.",
                "Data Entry Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)

                QuanTextBox.Focus()
                QuanTextBox.SelectAll()

            End Try

        Catch HoursWorkedException As FormatException
            MessageBox.Show("You must enter the hours worked as a number.",
                "Data Entry Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)

            hoursTextBox.Focus()
            hoursTextBox.SelectAll()


        End Try

Private Sub Check1_Click()
   If TakeOut.Value = vbChecked Then
      Takeout_Rate_Decimal*TotalDecimal
   ElseIf TakeOut.Value = vbUnchecked Then
      Check1.Caption = "Unchecked"
   End If
End Sub


    End Sub ' calculateButton_Click

    ' calculate and display wages
    Sub DisplayPay(inHoursDecimal As Decimal, inWagesDecimal As Decimal)
        Dim TotalDecimal As Decimal ' stores the total earnings

        ' determine wage amount
        TotalDecimal = inHoursDecimal * inWagesDecimal

        resultLabel.Text = EarningsDecimal.ToString("C")
    End Sub ' DisplayPay


  Private Sub ApplyJoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyJoin.Click
        Dim g As Graphics = Me.CreateGraphics()
        g.Clear(Me.BackColor)
        If BevelRadBtn.Checked Then
            DrawJoinedLines(g, LineJoin.Bevel)
        End If
        If MiterRadBtn.Checked Then
            DrawJoinedLines(g, LineJoin.Miter)
        End If
        If MiterClippedRadBtn.Checked Then
            DrawJoinedLines(g, LineJoin.MiterClipped)
        End If
        If RoundRadBtn.Checked Then
            DrawJoinedLines(g, LineJoin.Round)
        End If
        g.Dispose()

    End Sub

    End Class 'End calculator coffee