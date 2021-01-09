<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvwComMonitoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmvwComMonitoring))
        Me.crptvwComMonitoring = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crptvwComMonitoring
        '
        Me.crptvwComMonitoring.ActiveViewIndex = -1
        Me.crptvwComMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptvwComMonitoring.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptvwComMonitoring.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptvwComMonitoring.Location = New System.Drawing.Point(0, 0)
        Me.crptvwComMonitoring.Name = "crptvwComMonitoring"
        Me.crptvwComMonitoring.Size = New System.Drawing.Size(675, 396)
        Me.crptvwComMonitoring.TabIndex = 4
        '
        'frmvwComMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 396)
        Me.Controls.Add(Me.crptvwComMonitoring)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmvwComMonitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complaint Monitoring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crptvwComMonitoring As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
