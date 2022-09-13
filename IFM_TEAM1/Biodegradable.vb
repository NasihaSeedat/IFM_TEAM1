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
    Private Const _BioConstVal As Integer = 100  'constant value used for percentage calculation

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

    'METHODS
    Public Overrides Function ZeroWaste() As Double
        _BioZeroRatio = (_NumBioPackages / _BioMaterials) * _BioConstVal
        Return _BioZeroRatio
    End Function


End Class
