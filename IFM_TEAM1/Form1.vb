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

        Dim type As Integer = 0
        'setting up grid
        grdSustain.Rows = nBus + 1
        grdSustain.Cols = 8

        'labeling
        PlaceIG(0, 0, "Business")
        PlaceIG(0, 1, "Sustainability Level")
        PlaceIG(0, 2, "Rating")
        PlaceIG(0, 3, "Bio Waste")
        PlaceIG(0, 4, "Recycled Waste")

        For b As Integer = 1 To nBus
            Business(b) = New Business
            Business(b).Name = CStr(InputBox("What is business " & CStr(b) & " name?"))
            PlaceIG(b, 0, CStr(Business(b).Name))
            type = CInt(InputBox("What type of material is the packaging" & vbNewLine & "1) Biodegradable" & vbNewLine & "2) Recyclable"))
            Select Case type
                Case 1
                    Dim bio As Biodegradable = New Biodegradable
                    Business(b).Packaging = bio
                    Business(b).Packaging.type = "Biodegradable"
                    bio.NumBioPackages = CInt(InputBox("How many Biodegradable packages?"))
                    bio.BioMaterials = CInt(InputBox("How many overall Biodegradable materials?"))

                Case 2
                    Business(b).Packaging = New Recycled
            End Select
        Next b

    End Sub
End Class
