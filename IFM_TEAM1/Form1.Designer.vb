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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusSustainability))
        Me.grdSustain = New UJGrid.UJGrid()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdSustain
        '
        Me.grdSustain.FixedCols = 1
        Me.grdSustain.FixedRows = 1
        Me.grdSustain.Location = New System.Drawing.Point(120, 134)
        Me.grdSustain.Name = "grdSustain"
        Me.grdSustain.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdSustain.Size = New System.Drawing.Size(783, 167)
        Me.grdSustain.TabIndex = 0
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 171)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(102, 36)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 228)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(102, 36)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Business Sustainability"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(891, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BusSustainability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 320)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.grdSustain)
        Me.Name = "BusSustainability"
        Me.Text = "Business Sustainability"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdSustain As UJGrid.UJGrid
    Friend WithEvents btnInput As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
