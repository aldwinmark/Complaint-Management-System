﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvwComplaintByNature
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmvwComplaintByNature))
        Me.crptvwByNOC = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crptvwByNOC
        '
        Me.crptvwByNOC.ActiveViewIndex = -1
        Me.crptvwByNOC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptvwByNOC.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptvwByNOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptvwByNOC.Location = New System.Drawing.Point(0, 0)
        Me.crptvwByNOC.Name = "crptvwByNOC"
        Me.crptvwByNOC.Size = New System.Drawing.Size(746, 397)
        Me.crptvwByNOC.TabIndex = 3
        '
        'frmComplaintByNature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 397)
        Me.Controls.Add(Me.crptvwByNOC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComplaintByNature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "By Nature of Complaint"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crptvwByNOC As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
