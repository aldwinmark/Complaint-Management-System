<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvwComplaintListERC
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
        Me.crptvwComplaintListERC = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crptvwComplaintListERC
        '
        Me.crptvwComplaintListERC.ActiveViewIndex = -1
        Me.crptvwComplaintListERC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptvwComplaintListERC.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptvwComplaintListERC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptvwComplaintListERC.Location = New System.Drawing.Point(0, 0)
        Me.crptvwComplaintListERC.Name = "crptvwComplaintListERC"
        Me.crptvwComplaintListERC.Size = New System.Drawing.Size(858, 410)
        Me.crptvwComplaintListERC.TabIndex = 1
        '
        'frmvwComplaintListERC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 410)
        Me.Controls.Add(Me.crptvwComplaintListERC)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmvwComplaintListERC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complaint List to ERC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crptvwComplaintListERC As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
