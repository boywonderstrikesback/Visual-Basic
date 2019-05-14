<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BMITextBox = New System.Windows.Forms.TextBox()
        Me.CurrentBMILabel = New System.Windows.Forms.Label()
        Me.WeightAndHeightGroupBox = New System.Windows.Forms.GroupBox()
        Me.HeightComboBox = New System.Windows.Forms.ComboBox()
        Me.WeightComboBox = New System.Windows.Forms.ComboBox()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.WeightLabel = New System.Windows.Forms.Label()
        Me.WeightAndHeightGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(320, 32)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(320, 88)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 1
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(320, 144)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'BMITextBox
        '
        Me.BMITextBox.Location = New System.Drawing.Point(320, 210)
        Me.BMITextBox.Name = "BMITextBox"
        Me.BMITextBox.Size = New System.Drawing.Size(74, 20)
        Me.BMITextBox.TabIndex = 3
        '
        'CurrentBMILabel
        '
        Me.CurrentBMILabel.AutoSize = True
        Me.CurrentBMILabel.Location = New System.Drawing.Point(241, 217)
        Me.CurrentBMILabel.Name = "CurrentBMILabel"
        Me.CurrentBMILabel.Size = New System.Drawing.Size(66, 13)
        Me.CurrentBMILabel.TabIndex = 4
        Me.CurrentBMILabel.Text = "Current BMI:"
        '
        'WeightAndHeightGroupBox
        '
        Me.WeightAndHeightGroupBox.AutoSize = True
        Me.WeightAndHeightGroupBox.Controls.Add(Me.HeightComboBox)
        Me.WeightAndHeightGroupBox.Controls.Add(Me.WeightComboBox)
        Me.WeightAndHeightGroupBox.Controls.Add(Me.HeightTextBox)
        Me.WeightAndHeightGroupBox.Controls.Add(Me.WeightTextBox)
        Me.WeightAndHeightGroupBox.Controls.Add(Me.HeightLabel)
        Me.WeightAndHeightGroupBox.Controls.Add(Me.WeightLabel)
        Me.WeightAndHeightGroupBox.Location = New System.Drawing.Point(36, 51)
        Me.WeightAndHeightGroupBox.Name = "WeightAndHeightGroupBox"
        Me.WeightAndHeightGroupBox.Size = New System.Drawing.Size(262, 141)
        Me.WeightAndHeightGroupBox.TabIndex = 5
        Me.WeightAndHeightGroupBox.TabStop = False
        Me.WeightAndHeightGroupBox.Text = "Enter Weight/Height"
        '
        'HeightComboBox
        '
        Me.HeightComboBox.FormattingEnabled = True
        Me.HeightComboBox.Items.AddRange(New Object() {"in", "m"})
        Me.HeightComboBox.Location = New System.Drawing.Point(156, 69)
        Me.HeightComboBox.Name = "HeightComboBox"
        Me.HeightComboBox.Size = New System.Drawing.Size(41, 21)
        Me.HeightComboBox.TabIndex = 5
        '
        'WeightComboBox
        '
        Me.WeightComboBox.FormattingEnabled = True
        Me.WeightComboBox.Items.AddRange(New Object() {"lbs", "kg"})
        Me.WeightComboBox.Location = New System.Drawing.Point(156, 35)
        Me.WeightComboBox.Name = "WeightComboBox"
        Me.WeightComboBox.Size = New System.Drawing.Size(41, 21)
        Me.WeightComboBox.TabIndex = 4
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(65, 71)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(54, 20)
        Me.HeightTextBox.TabIndex = 3
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Location = New System.Drawing.Point(67, 37)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(52, 20)
        Me.WeightTextBox.TabIndex = 2
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(17, 71)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(41, 13)
        Me.HeightLabel.TabIndex = 1
        Me.HeightLabel.Text = "Height:"
        '
        'WeightLabel
        '
        Me.WeightLabel.AutoSize = True
        Me.WeightLabel.Location = New System.Drawing.Point(17, 37)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(44, 13)
        Me.WeightLabel.TabIndex = 0
        Me.WeightLabel.Text = "Weight:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 261)
        Me.Controls.Add(Me.WeightAndHeightGroupBox)
        Me.Controls.Add(Me.CurrentBMILabel)
        Me.Controls.Add(Me.BMITextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WeightAndHeightGroupBox.ResumeLayout(False)
        Me.WeightAndHeightGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalculateButton As Button
    Friend WithEvents Clear As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents BMITextBox As TextBox
    Friend WithEvents CurrentBMILabel As Label
    Friend WithEvents WeightAndHeightGroupBox As GroupBox
    Friend WithEvents HeightLabel As Label
    Friend WithEvents WeightLabel As Label
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents HeightComboBox As ComboBox
    Friend WithEvents WeightComboBox As ComboBox
End Class
