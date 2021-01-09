<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowDrawing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowDrawing))
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCanvas.Location = New System.Drawing.Point(0, 0)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(602, 436)
        Me.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCanvas.TabIndex = 9
        Me.picCanvas.TabStop = False
        '
        'frmShowDrawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 436)
        Me.Controls.Add(Me.picCanvas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmShowDrawing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Drawing"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
End Class
