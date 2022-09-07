'option statements
Option Infer Off
Option Strict On
Option Explicit On

'222133448 , Marabele PS
Public Class Packaging
    'variable declaration 
    Private _type As String


    ' the constructor'
    Public Sub New()

    End Sub
    ' the property method '
    Public Property type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property

    ' the polymorphic function 


End Class
