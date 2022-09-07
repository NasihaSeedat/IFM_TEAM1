'option statements
Option Infer Off
Option Strict On
Option Explicit On
'222053186
'Ragedi, MLL
Public Class Recycled
    Private _NumRecPackages As Integer  'Number of packages for this class
    Private _RecMaterials As Double 'Percentage of recycled materials
    Private _RecZeroRatio As Double 'Zero waste ratio
    Private _RecType As String 'material the pgaackaging is recycled from e.g glass,paper or plastic

    Public Sub New()
        MyBase.New()
    End Sub

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

    Public Property RecType() As String
        Get
            Return _RecType
        End Get
        Set(value As String)
            _RecType = value
        End Set
    End Property

    'Public Overrides Function ZeroWaste() As Double
    '    _RecZeroRatio = _NumRecPackages / _RecMaterials
    '    Return _RecZeroRatio
    'End Function
End Class
