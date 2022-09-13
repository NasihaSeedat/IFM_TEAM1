<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusSustainability
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grdSustain = New UJGrid.UJGrid()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdSustain
        '
        Me.grdSustain.FixedCols = 1
        Me.grdSustain.FixedRows = 1
        Me.grdSustain.Location = New System.Drawing.Point(145, 12)
        Me.grdSustain.Name = "grdSustain"
        Me.grdSustain.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdSustain.Size = New System.Drawing.Size(706, 155)
        Me.grdSustain.TabIndex = 0
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 21)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(102, 36)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'BusSustainability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 459)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.grdSustain)
        Me.Name = "BusSustainability"
        Me.Text = "Business Sustainability"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdSustain As UJGrid.UJGrid
    Friend WithEvents btnInput As Button
End Class
