'option statements
Option Infer Off
Option Strict On
Option Explicit On

'222002542, SEEDAT, N
Public Class BusSustainability
    Private Business() As Business
    Private Sustain As Sustainability
    Private Package As Packaging
    Private Bioable As Biodegradable
    Private Recycle As Recycled
    Private nBus As Integer

    'sub for placing stuff in grid 
    Public Sub PlaceIG(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdSustain.Row = r
        grdSustain.Col = c
        grdSustain.Text = t
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        nBus = CInt(InputBox("How many Businesses are there?"))
        ReDim Preserve Business(nBus)

        'setting up grid
        grdSustain.Rows = nBus + 1
        grdSustain.Cols = 8

        'labeling
        PlaceIG(0, 0, "Business")
        PlaceIG(0, 1, "Sustainability Level")
        PlaceIG(0, 2, "Rating")
        PlaceIG(0, 3, "Bio Waste")
        PlaceIG(0, 4, "Bio Efficiency")
        PlaceIG(0, 5, "Recycled Waste")
        PlaceIG(0, 6, "Recycled Efficiency")

        For b As Integer = 1 To nBus
            Business(b).Name = CStr("What is business " & CStr(b) & " name?")
        Next b

    End Sub
End Class
