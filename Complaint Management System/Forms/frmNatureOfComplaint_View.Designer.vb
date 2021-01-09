<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNatureOfComplaint_View
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNatureOfComplaint_View))
        Me.CMSNOC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComplaintsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstvwNOC = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSNOC.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMSNOC
        '
        Me.CMSNOC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintsListToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.CMSNOC.Name = "CMSComplaint"
        Me.CMSNOC.Size = New System.Drawing.Size(173, 104)
        '
        'ComplaintsListToolStripMenuItem
        '
        Me.ComplaintsListToolStripMenuItem.Name = "ComplaintsListToolStripMenuItem"
        Me.ComplaintsListToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ComplaintsListToolStripMenuItem.Text = "Nature Of Complaint"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.page_white_delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(169, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'lstvwNOC
        '
        Me.lstvwNOC.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Title})
        Me.lstvwNOC.ContextMenuStrip = Me.CMSNOC
        Me.lstvwNOC.FullRowSelect = True
        Me.lstvwNOC.GridLines = True
        Me.lstvwNOC.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwNOC.Location = New System.Drawing.Point(13, 13)
        Me.lstvwNOC.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvwNOC.Name = "lstvwNOC"
        Me.lstvwNOC.Size = New System.Drawing.Size(454, 332)
        Me.lstvwNOC.TabIndex = 3
        Me.lstvwNOC.UseCompatibleStateImageBehavior = False
        Me.lstvwNOC.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 300
        '
        'frmNatureOfComplaint_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(483, 368)
        Me.Controls.Add(Me.lstvwNOC)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNatureOfComplaint_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nature Of Complaint View"
        Me.CMSNOC.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMSNOC As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ComplaintsListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstvwNOC As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Title As System.Windows.Forms.ColumnHeader
End Class
