﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvwComplaintSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmvwComplaintSummary))
        Me.crptvwComplaintSummary = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crptvwComplaintSummary
        '
        Me.crptvwComplaintSummary.ActiveViewIndex = -1
        Me.crptvwComplaintSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptvwComplaintSummary.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptvwComplaintSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptvwComplaintSummary.Location = New System.Drawing.Point(0, 0)
        Me.crptvwComplaintSummary.Name = "crptvwComplaintSummary"
        Me.crptvwComplaintSummary.Size = New System.Drawing.Size(592, 361)
        Me.crptvwComplaintSummary.TabIndex = 3
        '
        'frmvwComplaintSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 361)
        Me.Controls.Add(Me.crptvwComplaintSummary)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmvwComplaintSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complaint Summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crptvwComplaintSummary As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
