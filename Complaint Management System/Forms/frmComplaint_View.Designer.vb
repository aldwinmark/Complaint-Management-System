<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComplaint_View
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComplaint_View))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.cmbxFilter = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstvwComplaints = New System.Windows.Forms.ListView()
        Me.ServiceRequest = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Priority = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Department = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComplainantName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContactNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NatureOfComplaint = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateReceipt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReceivedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSComplaint = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddLocationDrawingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLocationDrawingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FollowUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalRecords = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSComplaint.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.picCanvas)
        Me.GroupBox1.Controls.Add(Me.cmbxFilter)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.lstvwComplaints)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(930, 468)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'picCanvas
        '
        Me.picCanvas.Location = New System.Drawing.Point(722, 177)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(181, 130)
        Me.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCanvas.TabIndex = 8
        Me.picCanvas.TabStop = False
        Me.picCanvas.Visible = False
        '
        'cmbxFilter
        '
        Me.cmbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxFilter.FormattingEnabled = True
        Me.cmbxFilter.Items.AddRange(New Object() {"SR#", "Priority", "Department", "Name", "Address", "Contact#", "Nature", "Received by", "Type"})
        Me.cmbxFilter.Location = New System.Drawing.Point(222, 15)
        Me.cmbxFilter.Name = "cmbxFilter"
        Me.cmbxFilter.Size = New System.Drawing.Size(153, 24)
        Me.cmbxFilter.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(622, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(780, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "to"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEnd
        '
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(816, 14)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(107, 22)
        Me.dtpEnd.TabIndex = 4
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(667, 14)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(107, 22)
        Me.dtpStart.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Black
        Me.btnSearch.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.btnSearch.Image = Global.Complaint_Management_System.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(381, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(8, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(207, 22)
        Me.txtSearch.TabIndex = 1
        '
        'lstvwComplaints
        '
        Me.lstvwComplaints.AutoArrange = False
        Me.lstvwComplaints.BackColor = System.Drawing.Color.GhostWhite
        Me.lstvwComplaints.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ServiceRequest, Me.Priority, Me.Department, Me.ComplainantName, Me.Address, Me.ContactNo, Me.NatureOfComplaint, Me.DateReceipt, Me.ReceivedBy, Me.Type})
        Me.lstvwComplaints.ContextMenuStrip = Me.CMSComplaint
        Me.lstvwComplaints.FullRowSelect = True
        Me.lstvwComplaints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwComplaints.Location = New System.Drawing.Point(7, 42)
        Me.lstvwComplaints.MultiSelect = False
        Me.lstvwComplaints.Name = "lstvwComplaints"
        Me.lstvwComplaints.Size = New System.Drawing.Size(916, 419)
        Me.lstvwComplaints.TabIndex = 0
        Me.lstvwComplaints.UseCompatibleStateImageBehavior = False
        Me.lstvwComplaints.View = System.Windows.Forms.View.Details
        '
        'ServiceRequest
        '
        Me.ServiceRequest.Text = "SR #"
        Me.ServiceRequest.Width = 89
        '
        'Priority
        '
        Me.Priority.Text = "Priority"
        Me.Priority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Priority.Width = 54
        '
        'Department
        '
        Me.Department.Text = "Department"
        Me.Department.Width = 100
        '
        'ComplainantName
        '
        Me.ComplainantName.Text = "Name Of Complainant"
        Me.ComplainantName.Width = 178
        '
        'Address
        '
        Me.Address.Text = "Address Of Complainant"
        Me.Address.Width = 238
        '
        'ContactNo
        '
        Me.ContactNo.Text = "Contact #"
        Me.ContactNo.Width = 102
        '
        'NatureOfComplaint
        '
        Me.NatureOfComplaint.Text = "Nature Of Complaint"
        Me.NatureOfComplaint.Width = 150
        '
        'DateReceipt
        '
        Me.DateReceipt.Text = "Date/Time Receipt"
        Me.DateReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DateReceipt.Width = 150
        '
        'ReceivedBy
        '
        Me.ReceivedBy.Text = "Received By"
        Me.ReceivedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ReceivedBy.Width = 99
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMSComplaint
        '
        Me.CMSComplaint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocationToolStripMenuItem, Me.FollowUpToolStripMenuItem, Me.ToolStripSeparator3, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator1, Me.PrintToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.CMSComplaint.Name = "CMSComplaint"
        Me.CMSComplaint.Size = New System.Drawing.Size(153, 220)
        '
        'LocationToolStripMenuItem
        '
        Me.LocationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddLocationDrawingToolStripMenuItem, Me.ViewLocationDrawingToolStripMenuItem})
        Me.LocationToolStripMenuItem.Image = CType(resources.GetObject("LocationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LocationToolStripMenuItem.Name = "LocationToolStripMenuItem"
        Me.LocationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LocationToolStripMenuItem.Text = "Location"
        '
        'AddLocationDrawingToolStripMenuItem
        '
        Me.AddLocationDrawingToolStripMenuItem.Image = CType(resources.GetObject("AddLocationDrawingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddLocationDrawingToolStripMenuItem.Name = "AddLocationDrawingToolStripMenuItem"
        Me.AddLocationDrawingToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AddLocationDrawingToolStripMenuItem.Text = "Add location drawing"
        '
        'ViewLocationDrawingToolStripMenuItem
        '
        Me.ViewLocationDrawingToolStripMenuItem.Image = CType(resources.GetObject("ViewLocationDrawingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewLocationDrawingToolStripMenuItem.Name = "ViewLocationDrawingToolStripMenuItem"
        Me.ViewLocationDrawingToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ViewLocationDrawingToolStripMenuItem.Text = "View location drawing"
        '
        'FollowUpToolStripMenuItem
        '
        Me.FollowUpToolStripMenuItem.Image = CType(resources.GetObject("FollowUpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FollowUpToolStripMenuItem.Name = "FollowUpToolStripMenuItem"
        Me.FollowUpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FollowUpToolStripMenuItem.Text = "Add Follow-up"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.page_white_delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.printer
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total record(s):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalRecords.ForeColor = System.Drawing.Color.Black
        Me.lblTotalRecords.Location = New System.Drawing.Point(119, 473)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Size = New System.Drawing.Size(118, 20)
        Me.lblTotalRecords.TabIndex = 8
        Me.lblTotalRecords.Text = "0"
        Me.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmComplaint_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(956, 502)
        Me.Controls.Add(Me.lblTotalRecords)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComplaint_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complaints"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSComplaint.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstvwComplaints As System.Windows.Forms.ListView
    Friend WithEvents ServiceRequest As System.Windows.Forms.ColumnHeader
    Friend WithEvents Priority As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComplainantName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContactNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateReceipt As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReceivedBy As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMSComplaint As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NatureOfComplaint As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents Department As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbxFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRecords As System.Windows.Forms.Label
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FollowUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddLocationDrawingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewLocationDrawingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
End Class
