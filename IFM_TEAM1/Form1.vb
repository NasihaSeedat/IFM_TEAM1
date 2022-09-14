'option statements
Option Infer Off
Option Strict On
Option Explicit On

'222002542, SEEDAT, N
Public Class BusSustainability
    Private Business() As Business
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
        PlaceIG(0, 1, "Type:")
        PlaceIG(0, 2, "Sustainability Level")
        PlaceIG(0, 3, "Rating")
        PlaceIG(0, 4, "Bio Waste")
        PlaceIG(0, 5, "Bio Efficiency")
        PlaceIG(0, 6, "Recycled Waste")
        PlaceIG(0, 7, "Rec Efficiency")

        For b As Integer = 1 To nBus
            Business(b) = New Business
            Business(b).Name = CStr(InputBox("What is business " & CStr(b) & " name?"))
            PlaceIG(b, 0, CStr(Business(b).Name))
            type = CInt(InputBox("What type of material is the packaging" & vbNewLine & "1) Biodegradable" & vbNewLine & "2) Recyclable"))
            Select Case type
                'case for biodegradable
                Case 1
                    Dim bio As Biodegradable = New Biodegradable
                    bio.BioMaterials = CInt(InputBox("What is your total packages"))
                    bio.NumBioPackages = CInt(InputBox("How many Biodegradable packages?"))
                    bio.type = "Biodegradable"
                    PlaceIG(b, 1, bio.type)
                    Business(b).Packaging = bio
                'case for recycled
                Case 2
                    Dim rec As Recycled = New Recycled
                    rec.RecMaterials = CInt(InputBox("What is your total packages"))
                    rec.NumRecPackages = CInt(InputBox("How many Recycled packages?"))
                    rec.type = "Recycled"
                    PlaceIG(b, 1, rec.type)
                    Business(b).Packaging = rec
                Case Else
                    MsgBox("Please select an appropriate number:" & vbNewLine & "1) Biodegradable" & vbNewLine & "2) Recycled")
            End Select
        Next b

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        For b As Integer = 1 To nBus
            Select Case Business(b).Packaging.type
                Case "Biodegradable"
                    Dim bio As Biodegradable = TryCast(Business(b).Packaging, Biodegradable)
                    PlaceIG(b, 2, CStr(Business(b).Sustainability.CalcSustainabilityLevel(bio.NumBioPackages, bio.BioMaterials)))
                    PlaceIG(b, 3, CStr(Business(b).DetRating()))
                    PlaceIG(b, 4, CStr(bio.ZeroWaste()))
                    PlaceIG(b, 5, CStr(bio.DetermineEfficiency(bio.ZeroWaste())))
                    'N/A because it is biodegradable and not recycled
                    PlaceIG(b, 6, "N/A")
                    PlaceIG(b, 7, "N/A")
                Case "Recycled"
                    Dim rec As Recycled = TryCast(Business(b).Packaging, Recycled)
                    PlaceIG(b, 2, CStr(Business(b).Sustainability.CalcSustainabilityLevel(rec.NumRecPackages, rec.RecMaterials)))
                    PlaceIG(b, 3, CStr(Business(b).DetRating()))
                    'N/A because it is recycled and not biodegradable
                    PlaceIG(b, 4, "N/A")
                    PlaceIG(b, 5, "N/A")
                    PlaceIG(b, 6, CStr(rec.ZeroWaste()))
                    PlaceIG(b, 7, CStr(rec.DetermineEfficiency(rec.ZeroWaste())))
            End Select
        Next b
    End Sub

End Class
