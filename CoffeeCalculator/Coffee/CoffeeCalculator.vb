'Mike Ross 
'visual Basic
' 02/24/2018
'Calculator that caluclates total coffee order 

Public Class CoffeCalculator 
    Const Takeout_Rate_Decimal As Decimal = 0.08 
    Const Cappuccino_Decimal As Decimal = 3.0
    Const Espresso_RATE_Decimal As Decimal = 2.5
    Const Latte_RATE_Decimal As Decimal = 2.25
    Const Iced_Latte_RATE_Decimal As Decimal = 3.5
    Const Iced_Cappuccino_RATE_Decimal As Decimal = 3.5
   'all variables defined for each of the type of coffees 
    
    
    Private Sub calculateButton_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton.Click
        ' Calculate the bill amount
        Dim TotalDecimal As Decimal = 0
        ' Total  of the order
        Dim QuanofCoffee As Decimal=0
        'specifiy qunaity of coffee needed

        Try
            QuanofCoffee = Decimal.Parse(QuanTextBox.Text)

                ' calls Display total Function
                DisplayTotal(QuanofCoffee)

            Catch QuanException As FormatException
                MessageBox.Show("Must Enter Valid Quanitiy.",
                "Data Entry Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)

                QuanTextBox.Focus()
                QuanTextBox.SelectAll()
'error display 
            End Try

        Catch Quantitiy_Exception As FormatException
            MessageBox.Show("Enter Quantity.",
                "Data Entry Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)

            hoursTextBox.Focus()
            hoursTextBox.SelectAll()
       'shows a display error message if quanity is not entered 
        End Try

        End If
       Sub DisplayTotal(inHoursDecimal As Decimal)
        Dim TotalDecimal As Decimal ' stores the total earnings

        ' determine wage amount
        TotalDecimal = inQuantityDecimal 

        resultLabel.Text = EarningsDecimal.ToString("C")
    End Sub ' Display Total



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles Coffee_Selections.Enter

    End Sub

    Private Sub Cap_RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
         If Cap_RadioButton1_IsChecked = True Then 
            TotalDecimal=inQuantityDecimal*Cappuccino_Decimal
    End Sub

    Private Sub Espresso_RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
           If RadioButton2_IsChecked = True Then 
            TotalDecimal=inQuantityDecimal*Espresso_RATE_Decimal
    End Sub

    Private Sub Latte_RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
             If RadioButton3_CheckedChanged.IsChecked = True Then 
            TotalDecimal=inQuantityDecimal* Latte_RATE_Decimal
    End Sub

    Private Sub Iced_Latte_RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
                     If RadioButton3_CheckedChanged.IsChecked = True Then 
                    TotalDecimal=inQuantityDecimal* Iced_Latte_RATE_Decimal
    End Sub

    Private Sub Iced_Cap_RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
                           If RadioButton5_CheckedChanged.IsChecked = True Then 
                          TotalDecimal=(inQuantityDecimal*Iced_Cappuccino_RATE_Decimal
    End Sub
'each radio button is equivalnet to a coffee. when a certain coffee is selected it mulitplies that coffee by the requested 
'amount of quantities 
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Takeout_Button.CheckedChanged
      If CheckBox1.Checked Then
            TotalDecimal= TotalDecimal*Takeout_Rate_Decimal
            'if checked total is mulitplied by Take out rate
        
        Else
           TotalDecimal= TotalDecimal*1  'if not checked no chrage is applied
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Application.Exit()
    'button to exit program
    
    
    End Sub
End Class ' Coffee Calculator

