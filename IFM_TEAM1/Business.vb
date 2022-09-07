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
' Class name: Business 
' *****************************************************************
Public Class Business

    Private _Name As String
    Private _Packaging As Packaging
    Private _SustainabilityRating As Integer

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''Constructors'''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub New(ByVal _SustainabilityLevel As Double)

        DetRating(_SustainabilityLevel)

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''Property Methods''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Packaging As Packaging
        Get
            Return _Packaging
        End Get
        Set(value As Packaging)
            _Packaging = value
        End Set
    End Property

    Public Property Rating As Integer
        Get
            Return _SustainabilityRating
        End Get
        Set(value As Integer)
            _SustainabilityRating = value
        End Set
    End Property


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''Methods'''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Function DetRating(ByVal _SustainabilityLevel As Double) As Integer

        If (_SustainabilityLevel < 20) Then

            _SustainabilityRating = 1

        ElseIf (_SustainabilityLevel >= 20 And _SustainabilityLevel < 40) Then

            _SustainabilityRating = 2

        ElseIf (_SustainabilityLevel >= 40 And _SustainabilityLevel < 60) Then

            _SustainabilityRating = 3

        ElseIf (_SustainabilityLevel >= 60 And _SustainabilityLevel < 80) Then

            _SustainabilityRating = 4

        ElseIf (_SustainabilityLevel >= 80 And _SustainabilityLevel < 100) Then

            _SustainabilityRating = 5

        End If

        Return _SustainabilityRating
    End Function


End Class
