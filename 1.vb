
Imports System
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Homework_04

    Public Class BMIForm
        Inherits Form

        Friend Overridable Property CalculateButton As Button
            <CompilerGenerated>
            Get
                Return Me._CalculateButton
            End Get

            <CompilerGenerated>
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As Button)
                Dim value2 As EventHandler = New EventHandler(Me.CalculateButton_Click)
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
                Dim value2 As EventHandler = New EventHandler(Me.ClearButton_Click)
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
                Dim value2 As EventHandler = New EventHandler(Me.ExitButton_Click)
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
            MyBase.Load += New EventHandler(Me.BMIForm_Load)
            Me.InitializeComponent()
        End Sub

        <DebuggerNonUserCode>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
            If flag Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
