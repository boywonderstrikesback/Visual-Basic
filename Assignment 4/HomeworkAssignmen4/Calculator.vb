Public Class Calculator
    'assigned Values
    
    Private HeightDouble AS Double 
    Private WeightDouble AS Double 
    Private BMICalc As Double
    'assigned doubles
    
    Private _HeightUnit AS String 
    Private _WeightUnit As String
      'assigned Strings 
    
    

    Public Property Height As Double
        Get
            Return HeightDouble
        End Get
        Set(value As Double)
            If value <= 0 Then
                Throw New ArgumentOutOfRangeException(" Must Be Greater Than Zero")

            End If
            HeightDouble = value
        End Set
    End Property

    Public Property Weight As Double
        Get
            Return WeightDouble
        End Get
        Set(value As Double)
            If value <= 0 Then
                Throw New ArgumentOutOfRangeException("Must Be Greater Than Zero")
            End If
            WeightDouble = value
        End Set
    End Property

'Finds the Weight and returns as string
    Public Property WeightUnit As String
        Get
            Return _WeightUnit
        End Get
        Set(value As String)
            _WeightUnit = value
        End Set
    End Property

'Finds the Height and returns as string
    Public Property HeightUnit As String
        Get
            Return _HeightUnit
        End Get
        Set(value As String)
            _HeightUnit = value
        End Set
    End Property

'Does calculation for the Bmi
    Public Property BMI As Double
        Get
            Return BMICalc
        End Get
        Set(value As Double)
            BMICalc = value
        End Set
    End Property

'all values are iniated at zero or empty
    Sub New()
        HeightUnit = String.Empty
        WeightUnit = String.Empty
        Height = 0
        Weight = 0
        BMICalc = 0
    End Sub

'Each property is set basied on arguement 

    'overload the constructor
    Public Sub New(inWeightDouble As Double,inHeightDouble As Double,inHeight As String,
                   inWeight As String)
        
        
        'InH/w string
        HeightUnit = inHeight
        WeightUnit = inWeight

     'in W/H as double
        Height = inHeightDouble
        Weight = inWeightDouble
        

        Conv()
        'calculatation for BMI
        BMISUP()


    End Sub
    Sub Conv()
        If WeightUnit = "lbs" Then

            Weight = Weight * 0.45
        End If
        If HeightUnit = "in" Then
            Height = Height * 0.025
        End If

    End Sub
    Sub BMISUP()
        BMITotal = Weight / (Height) ^ 2
    End Sub

End Class



