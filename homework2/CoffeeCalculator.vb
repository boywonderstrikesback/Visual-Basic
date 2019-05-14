Public Class CoffeCalculator 
    Const Takeout_Rate_Decimal As Decimal=
    Const CLEANING_RATE_Decimal As Decimal = 135
    Const FILLING_RATE_Decimal As Decimal = 195
    Const XRAY_RATE_Decimal As Decimal = 150
   
   
   
   
    ' calculate and display the employee's pay
    Private Sub calculateButton_Click(sender As Object,
       e As EventArgs) Handles calculateButton.Click

        ' get hours worked and hourly wage
        Dim HoursWorkedDecimal As Decimal
        Dim HourlyWageDecimal As Decimal

        Try
            HoursWorkedDecimal = Decimal.Parse(hoursTextBox.Text)

            Try
                HourlyWageDecimal = Decimal.Parse(wageTextBox.Text)

                ' calls DisplayPay Function
                DisplayPay(HoursWorkedDecimal, HourlyWageDecimal)

            Catch WageException As FormatException
                MessageBox.Show("You must enter the hourly wage as a number.",
                "Data Entry Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)

                wageTextBox.Focus()
                wageTextBox.SelectAll()

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
   If Check1.Value = vbChecked Then
      Check1.Caption = "Checked"
   ElseIf Check1.Value = vbUnchecked Then
      Check1.Caption = "Unchecked"
   End If
End Sub
    If Takeout_Rate_Decimal



    End Sub ' calculateButton_Click

    ' calculate and display wages
    Sub DisplayPay(inHoursDecimal As Decimal, inWagesDecimal As Decimal)
        Dim EarningsDecimal As Decimal ' stores the total earnings

        ' determine wage amount
        EarningsDecimal = inHoursDecimal * inWagesDecimal

        resultLabel.Text = EarningsDecimal.ToString("C")
    End Sub ' DisplayPay


   'End If
            If CleaningCheckBox.Checked = True Or
                FillingCheckBox.Checked = True Or
                XRayCheckBox.Checked = True Then
                ' the patient had at least one service
                ' total the amount of the bill
                'Dim TotalDecimal As Decimal = 0

                ' if the patient had a cleaning
                'If CleaningCheckBox.Checked Then
                If CleaningCheckBox.Checked = True Then
                    TotalDecimal += CLEANING_RATE_Decimal
                    'TotalDecimal = TotalDecimal + CLEANING_RATE_Decimal
                End If

                ' if patient had a cavity filled
                If FillingCheckBox.Checked = True Then
                    TotalDecimal += FILLING_RATE_Decimal
                End If

                ' if patient had an xray
                If XRayCheckBox.Checked Then
                    TotalDecimal += XRAY_RATE_Decimal
                End If

                ' display the total
                totalCostLabel.Text = TotalDecimal.ToString("C")


            Else
                ' no services were selected
                MessageBox.Show("Please select at least one service.")

            End If
        End If
       End Sub
    End Class 'End calculator coffee