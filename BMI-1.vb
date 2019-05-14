Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Homework_04

    Public Class BMIForm
        Inherits Form

        Private components As IContainer

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label4"), CompilerGenerated>
        Private _Label4 As Label

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ClearButton"), CompilerGenerated>
        Private _ClearButton As Button

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CalculateButton"), CompilerGenerated>
        Private _CalculateButton As Button

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("HeightTextBox"), CompilerGenerated>
        Private _HeightTextBox As TextBox

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("WeightTextBox"), CompilerGenerated>
        Private _WeightTextBox As TextBox

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ExitButton"), CompilerGenerated>
        Private _ExitButton As Button

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label2"), CompilerGenerated>
        Private _Label2 As Label

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1"), CompilerGenerated>
        Private _GroupBox1 As GroupBox

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label3"), CompilerGenerated>
        Private _Label3 As Label

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CurrentTextBox"), CompilerGenerated>
        Private _CurrentTextBox As TextBox

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("HeightListBox"), CompilerGenerated>
        Private _HeightListBox As ComboBox

        <DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("WeightListBox"), CompilerGenerated>
        Private _WeightListBox As ComboBox

        Private TheCalculator As Calculator

        Friend Overridable Property CalculateButton As Button
            <CompilerGenerated>
            Get
                Return Me._CalculateButton
            End Get

            <CompilerGenerated>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As Button)
                Dim value2 As EventHandler = New EventHandler(AddressOf Me.CalculateButton_Click)
                Dim calculateButton As Button = Me._CalculateButton
                If calculateButton IsNot Nothing Then
                    calculateButton.Click -= value2
                End If

                Me._CalculateButton = value
                calculateButton = Me._CalculateButton
                If calculateButton IsNot Nothing Then
                    calculateButton.Click += value2
                End If
            End Set
        End Property

        Friend Overridable Property ClearButton As Button
            <CompilerGenerated>
            Get
                Return Me._ClearButton
            End Get

            <CompilerGenerated>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As Button)
                Dim value2 As EventHandler = New EventHandler(AddressOf Me.ClearButton_Click)
                Dim clearButton As Button = Me._ClearButton
                If clearButton IsNot Nothing Then
                    clearButton.Click -= value2
                End If

                Me._ClearButton = value
                clearButton = Me._ClearButton
                If clearButton IsNot Nothing Then
                    clearButton.Click += value2
                End If
            End Set
        End Property

        Friend Overridable Property CurrentTextBox As TextBox

        Friend Overridable Property ExitButton As Button
            <CompilerGenerated>
            Get
                Return Me._ExitButton
            End Get

            <CompilerGenerated>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As Button)
                Dim value2 As EventHandler = New EventHandler(AddressOf Me.ExitButton_Click)
                Dim exitButton As Button = Me._ExitButton
                If exitButton IsNot Nothing Then
                    exitButton.Click -= value2
                End If

                Me._ExitButton = value
                exitButton = Me._ExitButton
                If exitButton IsNot Nothing Then
                    exitButton.Click += value2
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox1 As GroupBox

        Friend Overridable Property HeightListBox As ComboBox

        Friend Overridable Property HeightTextBox As TextBox

        Friend Overridable Property Label2 As Label

        Friend Overridable Property Label3 As Label

        Friend Overridable Property Label4 As Label

        Friend Overridable Property WeightListBox As ComboBox

        Friend Overridable Property WeightTextBox As TextBox

        <DebuggerNonUserCode>
        Public Sub New()
            MyBase.Load += New EventHandler(AddressOf Me.BMIForm_Load)
            Me.InitializeComponent()
        End Sub

        Private Sub BMIForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.WeightListBox.SelectedIndex = 1
            Me.HeightListBox.SelectedIndex = 1
        End Sub

        Private Sub CalculateButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Me.TheCalculator = New Calculator(Double.Parse(Me.HeightTextBox.Text), Me.HeightListBox.Text, Double.Parse(Me.WeightTextBox.Text), Me.WeightListBox.Text)
                Me.CurrentTextBox.Text = Me.TheCalculator.BMI().ToString("n1")
            Catch expr_69 As FormatException
                ProjectData.SetProjectError(expr_69)
                MessageBox.Show("The weight and height must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ProjectData.ClearProjectError()
            Catch expr_8B As Exception
                ProjectData.SetProjectError(expr_8B)
                Dim ex As Exception = expr_8B
                MessageBox.Show("Error" & ex.Message)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.HeightTextBox.Clear()
            Me.CurrentTextBox.Clear()
            Dim weightTextBox As TextBox = Me.WeightTextBox
            weightTextBox.Clear()
            weightTextBox.Focus()
        End Sub

        <DebuggerNonUserCode>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
            If flag Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyBase.Close()
        End Sub

        <DebuggerStepThrough>
        Private Sub InitializeComponent()
            Me.Label4 = New Label()
            Me.ClearButton = New Button()
            Me.CalculateButton = New Button()
            Me.HeightTextBox = New TextBox()
            Me.WeightTextBox = New TextBox()
            Me.ExitButton = New Button()
            Me.Label2 = New Label()
            Me.GroupBox1 = New GroupBox()
            Me.HeightListBox = New ComboBox()
            Me.WeightListBox = New ComboBox()
            Me.Label3 = New Label()
            Me.CurrentTextBox = New TextBox()
            Me.GroupBox1.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Label4.Location = New Point(90, 122)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(132, 23)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Current BMI:"
            Me.Label4.TextAlign = ContentAlignment.MiddleRight
            Me.ClearButton.DialogResult = DialogResult.Cancel
            Me.ClearButton.Location = New Point(234, 49)
            Me.ClearButton.Name = "ClearButton"
            Me.ClearButton.Size = New Size(72, 24)
            Me.ClearButton.TabIndex = 2
            Me.ClearButton.Text = "C&lear"
            Me.CalculateButton.Location = New Point(234, 19)
            Me.CalculateButton.Name = "CalculateButton"
            Me.CalculateButton.Size = New Size(72, 24)
            Me.CalculateButton.TabIndex = 1
            Me.CalculateButton.Text = "&Calculate"
            Me.HeightTextBox.Location = New Point(80, 56)
            Me.HeightTextBox.Name = "HeightTextBox"
            Me.HeightTextBox.Size = New Size(64, 20)
            Me.HeightTextBox.TabIndex = 4
            Me.HeightTextBox.TextAlign = HorizontalAlignment.Center
            Me.WeightTextBox.Location = New Point(80, 24)
            Me.WeightTextBox.Name = "WeightTextBox"
            Me.WeightTextBox.Size = New Size(64, 20)
            Me.WeightTextBox.TabIndex = 1
            Me.WeightTextBox.TextAlign = HorizontalAlignment.Center
            Me.ExitButton.DialogResult = DialogResult.Cancel
            Me.ExitButton.Location = New Point(234, 79)
            Me.ExitButton.Name = "ExitButton"
            Me.ExitButton.Size = New Size(72, 24)
            Me.ExitButton.TabIndex = 3
            Me.ExitButton.Text = "E&xit"
            Me.Label2.Location = New Point(16, 64)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(48, 16)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Height:"
            Me.GroupBox1.Controls.Add(Me.HeightListBox)
            Me.GroupBox1.Controls.Add(Me.WeightListBox)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.WeightTextBox)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.HeightTextBox)
            Me.GroupBox1.Location = New Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New Size(210, 104)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Enter Weight and Height"
            Me.HeightListBox.DropDownStyle = ComboBoxStyle.DropDownList
            Me.HeightListBox.FormattingEnabled = True
            Me.HeightListBox.Items.AddRange(New Object() {"m", "in"})
            Me.HeightListBox.Location = New Point(150, 55)
            Me.HeightListBox.Name = "HeightListBox"
            Me.HeightListBox.Size = New Size(53, 21)
            Me.HeightListBox.TabIndex = 5
            Me.WeightListBox.DropDownStyle = ComboBoxStyle.DropDownList
            Me.WeightListBox.FormattingEnabled = True
            Me.WeightListBox.Items.AddRange(New Object() {"kg", "lbs"})
            Me.WeightListBox.Location = New Point(151, 22)
            Me.WeightListBox.Name = "WeightListBox"
            Me.WeightListBox.Size = New Size(53, 21)
            Me.WeightListBox.TabIndex = 2
            Me.Label3.Location = New Point(16, 32)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(48, 16)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Weight:"
            Me.CurrentTextBox.BackColor = SystemColors.Control
            Me.CurrentTextBox.Location = New Point(234, 124)
            Me.CurrentTextBox.Name = "CurrentTextBox"
            Me.CurrentTextBox.[ReadOnly] = True
            Me.CurrentTextBox.Size = New Size(66, 20)
            Me.CurrentTextBox.TabIndex = 5
            Me.CurrentTextBox.TabStop = False
            Me.CurrentTextBox.TextAlign = HorizontalAlignment.Right
            MyBase.AcceptButton = Me.CalculateButton
            MyBase.AutoScaleDimensions = New SizeF(6F, 13F)
            MyBase.AutoScaleMode = AutoScaleMode.Font
            MyBase.CancelButton = Me.ClearButton
            MyBase.ClientSize = New Size(319, 159)
            MyBase.Controls.Add(Me.CurrentTextBox)
            MyBase.Controls.Add(Me.Label4)
            MyBase.Controls.Add(Me.ClearButton)
            MyBase.Controls.Add(Me.CalculateButton)
            MyBase.Controls.Add(Me.ExitButton)
            MyBase.Controls.Add(Me.GroupBox1)
            MyBase.Name = "BMIForm"
            MyBase.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "BMI Calculator"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
