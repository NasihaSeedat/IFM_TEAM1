'option statements
Option Infer Off
Option Strict On
Option Explicit On

'Ragedi MLL ,222053186
Public Class Biodegradable
    Inherits Packaging
    Private _NumBioPackages As Integer  'Number of packages for this class
    Private _BioMaterials As Double 'Percentage of biodegradable materials
    Private _BioZeroRatio As Double 'Zero waste ratio
    Private _BioEfficiency As String 'based on the zerowaste ratio
    Private Const _BioConstVal As Integer = 3  'constant value used for polymorphic calculation // it takes 3 months to biodegrade

    'CONSTRUCTORS
    Public Sub New()
        MyBase.New()
    End Sub

    'PROPERTIES
    Public Property NumBioPackages() As Integer
        Get
            Return _NumBioPackages
        End Get
        Set(value As Integer)
            _NumBioPackages = value
        End Set
    End Property

    Public Property BioMaterials() As Double
        Get
            Return _BioMaterials
        End Get
        Set(value As Double)
            _BioMaterials = value
        End Set
    End Property

    Public Property BioZeroRatio() As Double
        Get
            Return _BioZeroRatio
        End Get
        Set(value As Double)
            _BioZeroRatio = value
        End Set
    End Property
    Public Property BioEfficiency() As String
        Get
            Return _BioEfficiency
        End Get
        Set(value As String)
            _BioEfficiency = value
        End Set
    End Property

    'METHODS
    Public Overrides Function ZeroWaste() As Double
        _BioZeroRatio = ((_NumBioPackages / _BioMaterials) * _BioConstVal) * 100
        Return _BioZeroRatio
    End Function

    Public Function DetermineEfficiency(BioZeroRatio As Double) As String
        If _BioZeroRatio < 49 Then
            _BioEfficiency = "Low"
        Else
            If _BioZeroRatio >= 50 And _BioZeroRatio < 99 Then
                _BioEfficiency = "Moderate"
            Else
                If _BioZeroRatio >= 100 Then
                    _BioEfficiency = "High"
                End If
            End If
        End If
        Return _BioEfficiency

    End Function


End Class
