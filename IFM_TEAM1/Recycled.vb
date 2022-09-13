'option statements
Option Infer Off
Option Strict On
Option Explicit On

'Ragedi MLL ,222053186
Public Class Recycled
    Inherits Packaging

    Private _NumRecPackages As Integer  'Number of packages for this class
    Private _RecMaterials As Double 'Percentage of recycled materials
    Private _RecZeroRatio As Double 'Zero waste ratio
    Private Const _RecConstVal As Integer = 100  'constant value used for percentage calculation

    'CONSTRUCTORS
    Public Sub New()
        MyBase.New()
    End Sub

    'PROPERTIES
    Public Property NumRecPackages() As Integer
        Get
            Return _NumRecPackages
        End Get
        Set(value As Integer)
            _NumRecPackages = value
        End Set
    End Property

    Public Property RecMaterials() As Double
        Get
            Return _RecMaterials
        End Get
        Set(value As Double)
            _RecMaterials = value
        End Set
    End Property

    Public Property RecZeroRatio() As Double
        Get
            Return _RecZeroRatio
        End Get
        Set(value As Double)
            _RecZeroRatio = value
        End Set
    End Property


    'METHODS
    Public Overrides Function ZeroWaste() As Double                      'Method that calculates the ratio of waste
        _RecZeroRatio = (_NumRecPackages / _RecMaterials) * _RecConstVal 'A ratio that is used to determine the efficiency
        Return _RecZeroRatio
    End Function



End Class
