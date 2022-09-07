'option statements
Option Infer Off
Option Strict On
Option Explicit On
'222053186
'Ragedi, MLL
Public Class Biodegradable
    'Inherits Package
    Private _NumBioPackages As Integer  'Number of packages for this class
    Private _BioMaterials As Double 'Percentage of biodegradable materials
    Private _BioZeroRatio As Double 'Zero waste ratio
    Private _BioType As String '???
    Public Sub New()
        MyBase.New()
    End Sub

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

    Public Property BioType() As String
        Get
            Return _BioType
        End Get
        Set(value As String)
            _BioType = value
        End Set
    End Property
    'Public Overrides Function ZeroWaste() As Double
    '    _BioZeroRatio = _NumBioPackages / _BioMaterials
    '    Return _BioZeroRatio
    'End Function
End Class
