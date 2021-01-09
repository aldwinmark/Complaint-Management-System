<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccounts_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccounts_View))
        Me.lstvwUserAccount = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Emp_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Designation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Level = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSUserAccount = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComplaintsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSUserAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwUserAccount
        '
        Me.lstvwUserAccount.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Username, Me.Emp_Name, Me.Designation, Me.Level, Me.Password})
        Me.lstvwUserAccount.ContextMenuStrip = Me.CMSUserAccount
        Me.lstvwUserAccount.FullRowSelect = True
        Me.lstvwUserAccount.GridLines = True
        Me.lstvwUserAccount.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwUserAccount.Location = New System.Drawing.Point(13, 13)
        Me.lstvwUserAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvwUserAccount.MultiSelect = False
        Me.lstvwUserAccount.Name = "lstvwUserAccount"
        Me.lstvwUserAccount.Size = New System.Drawing.Size(541, 469)
        Me.lstvwUserAccount.TabIndex = 1
        Me.lstvwUserAccount.UseCompatibleStateImageBehavior = False
        Me.lstvwUserAccount.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 100
        '
        'Emp_Name
        '
        Me.Emp_Name.Text = "Employee Name"
        Me.Emp_Name.Width = 220
        '
        'Designation
        '
        Me.Designation.Text = "Designation"
        Me.Designation.Width = 150
        '
        'Level
        '
        Me.Level.Text = "Level"
        Me.Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.Width = 0
        '
        'CMSUserAccount
        '
        Me.CMSUserAccount.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintsListToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.CMSUserAccount.Name = "CMSComplaint"
        Me.CMSUserAccount.Size = New System.Drawing.Size(171, 126)
        '
        'ComplaintsListToolStripMenuItem
        '
        Me.ComplaintsListToolStripMenuItem.Enabled = False
        Me.ComplaintsListToolStripMenuItem.Name = "ComplaintsListToolStripMenuItem"
        Me.ComplaintsListToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComplaintsListToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ComplaintsListToolStripMenuItem.Text = "User Account"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AddToolStripMenuItem.Text = "Add user account"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EditToolStripMenuItem.Text = "Edit user account"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete user account"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh user list"
        '
        'frmUserAccounts_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 495)
        Me.Controls.Add(Me.lstvwUserAccount)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserAccounts_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Account"
        Me.CMSUserAccount.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstvwUserAccount As System.Windows.Forms.ListView
    Friend WithEvents CMSUserAccount As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ComplaintsListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Emp_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Designation As System.Windows.Forms.ColumnHeader
    Friend WithEvents Level As System.Windows.Forms.ColumnHeader
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
End Class
