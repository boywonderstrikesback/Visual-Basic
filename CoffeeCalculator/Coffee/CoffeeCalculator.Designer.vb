<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoffeeCalculator
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Coffee_Selections = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Takeout_Button = New System.Windows.Forms.CheckBox()
        Me.Coffee_Selections.SuspendLayout()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(175, 11)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 24)
        Me.calculateButton.TabIndex = 19
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(0, 115)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(37, 15)
        Me.totalLabel.TabIndex = 18
        Me.totalLabel.Text = "Total:"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalCostLabel
        '
        Me.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalCostLabel.Location = New System.Drawing.Point(43, 115)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(60, 21)
        Me.totalCostLabel.TabIndex = 17
        Me.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(53, 6)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.nameTextBox.TabIndex = 13
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(0, 9)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(37, 15)
        Me.nameLabel.TabIndex = 12
        Me.nameLabel.Text = "Order"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Coffee_Selections
        '
        Me.Coffee_Selections.Controls.Add(Me.RadioButton5)
        Me.Coffee_Selections.Controls.Add(Me.RadioButton4)
        Me.Coffee_Selections.Controls.Add(Me.RadioButton3)
        Me.Coffee_Selections.Controls.Add(Me.RadioButton2)
        Me.Coffee_Selections.Controls.Add(Me.RadioButton1)
        Me.Coffee_Selections.Location = New System.Drawing.Point(136, 68)
        Me.Coffee_Selections.Name = "Coffee_Selections"
        Me.Coffee_Selections.Size = New System.Drawing.Size(129, 175)
        Me.Coffee_Selections.TabIndex = 23
        Me.Coffee_Selections.TabStop = False
        Me.Coffee_Selections.Text = "Coffee Selections"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 24)
        Me.RadioButton1.Name = "Cappuccino"
        Me.RadioButton1.Size = New System.Drawing.Size(97, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cappuccino"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 49)
        Me.RadioButton2.Name = "Espresso"
        Me.RadioButton2.Size = New System.Drawing.Size(97, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Espresso"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 79)
        Me.RadioButton3.Name = "Latte"
        Me.RadioButton3.Size = New System.Drawing.Size(97, 19)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Latte"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 104)
        Me.RadioButton4.Name = "Iced_Latte"
        Me.RadioButton4.Size = New System.Drawing.Size(97, 19)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Iced_Latte"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 129)
        Me.RadioButton5.Name = "Iced_Cappuccino"
        Me.RadioButton5.Size = New System.Drawing.Size(97, 19)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Iced_Cappuccino"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(175, 39)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Button.TabIndex = 24
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Takeout_Button
        '
        Me.Takeout_Button.AutoSize = True
        Me.Takeout_Button.Location = New System.Drawing.Point(13, 56)
        Me.Takeout_Button.Name = "Takeout_Button"
        Me.Takeout_Button.Size = New System.Drawing.Size(98, 19)
        Me.Takeout_Button.TabIndex = 25
        Me.Takeout_Button.Text = "Is it Take out?"
        Me.Takeout_Button.UseVisualStyleBackColor = True
        '
        'DentalPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 325)
        Me.Controls.Add(Me.Takeout_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Coffee_Selections)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.totalCostLabel)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DentalPayment"
        Me.Text = "Coffee"
        Me.Coffee_Selections.ResumeLayout(False)
        Me.Coffee_Selections.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents totalCostLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents Coffee_Selections As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Exit_Button As System.Windows.Forms.Button
    Friend WithEvents Takeout_Button As System.Windows.Forms.CheckBox

End Class
