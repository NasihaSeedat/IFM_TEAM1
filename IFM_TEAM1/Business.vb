'option statements
Option Infer Off
Option Strict On
Option Explicit On

'222118746 , Tumisho
Public Class Business

    Private _Name As String
    Private _Packaging As Packaging
    Private _SustainabilityRating As Integer
    Private _Sustainability As Sustainability

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''Constructors'''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub New()

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

    Public Property Sustainability As Sustainability
        Get
            Return _Sustainability
        End Get
        Set(value As Sustainability)
            _Sustainability = value
        End Set
    End Property

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''Methods'''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Function DetRating() As Integer

        Dim SustainabilityLevel As Double = _Sustainability.SustainabilityLevel

        If (SustainabilityLevel < 20) Then

            _SustainabilityRating = 1

        ElseIf (SustainabilityLevel >= 20 And SustainabilityLevel < 40) Then

            _SustainabilityRating = 2

        ElseIf (SustainabilityLevel >= 40 And SustainabilityLevel < 60) Then

            _SustainabilityRating = 3

        ElseIf (SustainabilityLevel >= 60 And SustainabilityLevel < 80) Then

            _SustainabilityRating = 4

        ElseIf (SustainabilityLevel >= 80 And SustainabilityLevel < 100) Then

            _SustainabilityRating = 5

        End If

        Return _SustainabilityRating
    End Function


End Class
