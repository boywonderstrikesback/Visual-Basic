
Imports Microsoft.VisualBasic.CompilerServices
Imports System

Namespace Homework_04

    Public Class Calculator

        Public Property Height As Double
            Get
                Return Me._HeightDouble
            End Get

            Set(ByVal value As Double)
                Me._HeightDouble = value
            End Set
        End Property

        Public Property HeightUnit As String
            Get
                Return Me._HeightUnit
            End Get

            Set(ByVal value As String)
                Me._HeightUnit = value.Trim().ToLower()
            End Set
        End Property

        Public Property Weight As Double
            Get
                Return Me._WeightDouble
            End Get

            Set(ByVal value As Double)
                Me._WeightDouble = value
            End Set
        End Property

        Public Property WeightUnit As String
            Get
                Return Me._WeightUnit
            End Get

            Set(ByVal value As String)
                Me._WeightUnit = value.ToLower()
            End Set
        End Property

        Public Sub New(ByVal HeightDouble As Double, ByVal HeightUnitString As String, ByVal WeightDouble As Double, ByVal WeightUnitString As String)
            Me.Height = HeightDouble
            Me.HeightUnit = HeightUnitString
            Me.Weight = WeightDouble
            Me.WeightUnit = WeightUnitString
            Me.BMI()
        End Sub

        Public Function BMI() As Double
            Dim flag As Boolean = Operators.CompareString(Me.WeightUnit, "kg", False) = 0
            Dim num As Double
            If flag Then
                num = Me.Weight
            Else
                num = Me.Weight * 0.44999998807907104
            End If

            Dim flag2 As Boolean = Operators.CompareString(Me.HeightUnit, "m", False) = 0
            Dim x As Double
            If flag2 Then
                x = Me.Height
            Else
                x = Me.Height * 0.02500000037252903
            End If

            Return num / Math.Pow(x, 2)
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
