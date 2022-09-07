'option statements
Option Infer Off
Option Strict On
Option Explicit On

' ***************************************************************** 
' Team Number: 1
' Team Member 1 Details: Surname, Initials (Student #) 
' Team Member 2 Details: Surname, Initials (Student #) 
' Team Member 3 Details: Surname, Initials (Student #) 
' Team Member 4 Details: e.g. Smith, J (202000001) 
' Practical: Team Project 
' Class name: Sustainability 
' *****************************************************************

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
        _SustainabilityLevel = Math.Round(_SustainabilityLevel)


        Return _SustainabilityLevel
    End Function




End Class
