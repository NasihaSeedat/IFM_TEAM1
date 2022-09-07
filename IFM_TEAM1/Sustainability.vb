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

    Private _Business As Business
    Private _SustainabilityLevel As Double



    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''Constructors'''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub New(ByVal NumSustainableMaterials As Integer, ByVal TotalSustainableMaterials As Integer)

        'Whe the Sustainability class is created, get the number of sustainable materials from user and
        'the total sustainable materials from user
        ' After that calculate the Sustainability level
        ' After calculating the sustainability level create the Business object and feed it the sustainability level

        CalcSustainabilityLevel(NumSustainableMaterials, TotalSustainableMaterials)

        _Business = New Business(_SustainabilityLevel)

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''Property Methods''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Property Business As Business
        Get
            Return _Business
        End Get
        Set(value As Business)
            _Business = value
        End Set
    End Property

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
