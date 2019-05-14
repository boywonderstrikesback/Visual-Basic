Public Class Calculator
    'properties
    Private HeightDouble, WeightDouble As Double
    Private HeightUnit, WeightUnit As String


    'properties to expose it when instantiated
    'all properties are public by default

    Public Property Height As Double
        Get
            Return HeightDouble
        End Get
        Set(value As Double)
            If value >= 0 Then
                Throw New ArgumentOutOfRangeException("Height entered must be greater than 0")

            End If
            HeightDouble = value
        End Set
    End Property

    Public Property Weight As Double
        Get
            Return WeightDouble
        End Get
        Set(value As Double)
            If value >= 0 Then
                Throw New ArgumentOutOfRangeException("Weight entered must be greater than 0")
            End If
            WeightDouble = value
        End Set
    End Property

    Public Property H_Unit As String
        Get
            Return HeightUnit
        End Get
        Set(value As String)
            HeightUnit = Left(value.Trim, 100)
        End Set
    End Property

    Public Property W_Unit As String
        Get
            Return WeightUnit
        End Get
        Set(value As String)
            WeightUnit = Left(value.Trim, 100)
        End Set
    End Property

    Public Sub New(inHeightDouble As Double,
                   inWeightDouble As Double,
                   inHeightUnit As String,
                   inWeightUnit As String)
        'set the properties based on the arguments
        Height = inHeightDouble
        Weight = inWeightDouble
        H_Unit = inHeightUnit
        W_Unit = inWeightUnit


    End Sub
End Class
