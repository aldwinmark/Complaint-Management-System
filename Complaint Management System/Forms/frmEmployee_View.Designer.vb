<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee_View))
        Me.CMSEmployee = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComplaintsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstvwEmployee = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Employee_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Department = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListingCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMSEmployee
        '
        Me.CMSEmployee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintsListToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.CMSEmployee.Name = "CMSComplaint"
        Me.CMSEmployee.Size = New System.Drawing.Size(178, 126)
        '
        'ComplaintsListToolStripMenuItem
        '
        Me.ComplaintsListToolStripMenuItem.Enabled = False
        Me.ComplaintsListToolStripMenuItem.Name = "ComplaintsListToolStripMenuItem"
        Me.ComplaintsListToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComplaintsListToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ComplaintsListToolStripMenuItem.Text = "Employee List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(174, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AddToolStripMenuItem.Text = "Add employee"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.EditToolStripMenuItem.Text = "Edit employee"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.page_white_delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete employee"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(174, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh employee list"
        '
        'lstvwEmployee
        '
        Me.lstvwEmployee.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Employee_Name, Me.Position, Me.Department, Me.ListingCode})
        Me.lstvwEmployee.ContextMenuStrip = Me.CMSEmployee
        Me.lstvwEmployee.FullRowSelect = True
        Me.lstvwEmployee.GridLines = True
        Me.lstvwEmployee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwEmployee.Location = New System.Drawing.Point(13, 13)
        Me.lstvwEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvwEmployee.MultiSelect = False
        Me.lstvwEmployee.Name = "lstvwEmployee"
        Me.lstvwEmployee.Size = New System.Drawing.Size(570, 367)
        Me.lstvwEmployee.TabIndex = 2
        Me.lstvwEmployee.UseCompatibleStateImageBehavior = False
        Me.lstvwEmployee.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'Employee_Name
        '
        Me.Employee_Name.Text = "Employee Name"
        Me.Employee_Name.Width = 250
        '
        'Position
        '
        Me.Position.Text = "Position"
        Me.Position.Width = 150
        '
        'Department
        '
        Me.Department.Text = "Department"
        Me.Department.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Department.Width = 100
        '
        'ListingCode
        '
        Me.ListingCode.Text = ""
        Me.ListingCode.Width = 50
        '
        'frmEmployee_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 395)
        Me.Controls.Add(Me.lstvwEmployee)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployee_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.CMSEmployee.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMSEmployee As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ComplaintsListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstvwEmployee As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Employee_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Position As System.Windows.Forms.ColumnHeader
    Friend WithEvents Department As System.Windows.Forms.ColumnHeader
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListingCode As System.Windows.Forms.ColumnHeader
End Class
