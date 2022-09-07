'option statements
Option Infer Off
Option Strict On
Option Explicit On

'222118746 , Tumisho

Public Class Sustainability

    Private _SustainabilityLevel As Double



    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''Constructors'''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub New()

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''Property Methods''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Property SustainabilityLevel As Double
        Get
            Return _SustainabilityLevel
        End Get
        Set(value As Double)
            _SustainabilityLevel = value
        End Set
    End Property


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''Methods'''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Function CalcSustainabilityLevel(ByVal NumSustainableMaterials As Integer, ByVal TotalSustainableMaterials As Integer) As Double

        _SustainabilityLevel = (NumSustainableMaterials / TotalSustainableMaterials) * 100

        ' Math.Round rounds off to the nearest integer
        _SustainabilityLevel = Math.Round(_SustainabilityLevel)


        Return _SustainabilityLevel
    End Function




End Class
