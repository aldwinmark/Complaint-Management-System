<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubCompDesk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubCompDesk))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbxFilter = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbctrlMain = New System.Windows.Forms.TabControl()
        Me.tbpageEmergency = New System.Windows.Forms.TabPage()
        Me.lstvwEmergency = New System.Windows.Forms.ListView()
        Me.DispatchTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.ComplaintsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DispatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionComplaintReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbpageSurvey = New System.Windows.Forms.TabPage()
        Me.lstvwSurvey = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbpageRequest = New System.Windows.Forms.TabPage()
        Me.lstvwRequest = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.tbctrlMain.SuspendLayout()
        Me.tbpageEmergency.SuspendLayout()
        Me.CMSComplaint.SuspendLayout()
        Me.tbpageSurvey.SuspendLayout()
        Me.tbpageRequest.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbxFilter)
        Me.GroupBox1.Controls.Add(Me.lblArea)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbctrlMain)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 468)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbxFilter
        '
        Me.cmbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxFilter.FormattingEnabled = True
        Me.cmbxFilter.Items.AddRange(New Object() {"SR#", "Priority", "Department", "Name", "Address", "Contact#", "Nature", "Received by", "Type"})
        Me.cmbxFilter.Location = New System.Drawing.Point(277, 41)
        Me.cmbxFilter.Name = "cmbxFilter"
        Me.cmbxFilter.Size = New System.Drawing.Size(131, 24)
        Me.cmbxFilter.TabIndex = 1
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.Black
        Me.lblArea.Location = New System.Drawing.Point(170, 19)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(71, 16)
        Me.lblArea.TabIndex = 9
        Me.lblArea.Text = "- - - - - - - "
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Area/Office/Department:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbctrlMain
        '
        Me.tbctrlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tbctrlMain.Controls.Add(Me.tbpageEmergency)
        Me.tbctrlMain.Controls.Add(Me.tbpageSurvey)
        Me.tbctrlMain.Controls.Add(Me.tbpageRequest)
        Me.tbctrlMain.Location = New System.Drawing.Point(8, 69)
        Me.tbctrlMain.Multiline = True
        Me.tbctrlMain.Name = "tbctrlMain"
        Me.tbctrlMain.SelectedIndex = 0
        Me.tbctrlMain.Size = New System.Drawing.Size(985, 392)
        Me.tbctrlMain.TabIndex = 7
        '
        'tbpageEmergency
        '
        Me.tbpageEmergency.BackColor = System.Drawing.Color.Red
        Me.tbpageEmergency.Controls.Add(Me.lstvwEmergency)
        Me.tbpageEmergency.Location = New System.Drawing.Point(4, 4)
        Me.tbpageEmergency.Name = "tbpageEmergency"
        Me.tbpageEmergency.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpageEmergency.Size = New System.Drawing.Size(977, 363)
        Me.tbpageEmergency.TabIndex = 0
        Me.tbpageEmergency.Text = "Emergency"
        '
        'lstvwEmergency
        '
        Me.lstvwEmergency.AutoArrange = False
        Me.lstvwEmergency.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DispatchTo, Me.ServiceRequest, Me.Priority, Me.Department, Me.ComplainantName, Me.Address, Me.ContactNo, Me.NatureOfComplaint, Me.DateReceipt, Me.ReceivedBy, Me.Type})
        Me.lstvwEmergency.ContextMenuStrip = Me.CMSComplaint
        Me.lstvwEmergency.FullRowSelect = True
        Me.lstvwEmergency.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwEmergency.Location = New System.Drawing.Point(3, 3)
        Me.lstvwEmergency.MultiSelect = False
        Me.lstvwEmergency.Name = "lstvwEmergency"
        Me.lstvwEmergency.Size = New System.Drawing.Size(971, 357)
        Me.lstvwEmergency.TabIndex = 0
        Me.lstvwEmergency.UseCompatibleStateImageBehavior = False
        Me.lstvwEmergency.View = System.Windows.Forms.View.Details
        '
        'DispatchTo
        '
        Me.DispatchTo.Text = "<Dispatch to>"
        Me.DispatchTo.Width = 200
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
        Me.CMSComplaint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintsListToolStripMenuItem, Me.ToolStripSeparator1, Me.DispatchToolStripMenuItem, Me.ActionComplaintReceiptToolStripMenuItem})
        Me.CMSComplaint.Name = "CMSComplaint"
        Me.CMSComplaint.Size = New System.Drawing.Size(194, 76)
        '
        'ComplaintsListToolStripMenuItem
        '
        Me.ComplaintsListToolStripMenuItem.Enabled = False
        Me.ComplaintsListToolStripMenuItem.Name = "ComplaintsListToolStripMenuItem"
        Me.ComplaintsListToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComplaintsListToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ComplaintsListToolStripMenuItem.Text = "Action to Complaints"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'DispatchToolStripMenuItem
        '
        Me.DispatchToolStripMenuItem.Image = CType(resources.GetObject("DispatchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DispatchToolStripMenuItem.Name = "DispatchToolStripMenuItem"
        Me.DispatchToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.DispatchToolStripMenuItem.Text = "&Dispatch"
        '
        'ActionComplaintReceiptToolStripMenuItem
        '
        Me.ActionComplaintReceiptToolStripMenuItem.Image = CType(resources.GetObject("ActionComplaintReceiptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActionComplaintReceiptToolStripMenuItem.Name = "ActionComplaintReceiptToolStripMenuItem"
        Me.ActionComplaintReceiptToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ActionComplaintReceiptToolStripMenuItem.Text = "&Action Complaint Receipt"
        Me.ActionComplaintReceiptToolStripMenuItem.Visible = False
        '
        'tbpageSurvey
        '
        Me.tbpageSurvey.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbpageSurvey.Controls.Add(Me.lstvwSurvey)
        Me.tbpageSurvey.Location = New System.Drawing.Point(4, 4)
        Me.tbpageSurvey.Name = "tbpageSurvey"
        Me.tbpageSurvey.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpageSurvey.Size = New System.Drawing.Size(977, 363)
        Me.tbpageSurvey.TabIndex = 1
        Me.tbpageSurvey.Text = "Survey/Check-up"
        '
        'lstvwSurvey
        '
        Me.lstvwSurvey.AutoArrange = False
        Me.lstvwSurvey.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lstvwSurvey.ContextMenuStrip = Me.CMSComplaint
        Me.lstvwSurvey.FullRowSelect = True
        Me.lstvwSurvey.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwSurvey.Location = New System.Drawing.Point(3, 3)
        Me.lstvwSurvey.MultiSelect = False
        Me.lstvwSurvey.Name = "lstvwSurvey"
        Me.lstvwSurvey.Size = New System.Drawing.Size(971, 357)
        Me.lstvwSurvey.TabIndex = 1
        Me.lstvwSurvey.UseCompatibleStateImageBehavior = False
        Me.lstvwSurvey.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SR #"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Priority"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 54
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Department"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name Of Complainant"
        Me.ColumnHeader4.Width = 178
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Address Of Complainant"
        Me.ColumnHeader5.Width = 238
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Contact #"
        Me.ColumnHeader6.Width = 102
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nature Of Complaint"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date/Time Receipt"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Received By"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 99
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Type"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbpageRequest
        '
        Me.tbpageRequest.BackColor = System.Drawing.Color.Gray
        Me.tbpageRequest.Controls.Add(Me.lstvwRequest)
        Me.tbpageRequest.Location = New System.Drawing.Point(4, 4)
        Me.tbpageRequest.Name = "tbpageRequest"
        Me.tbpageRequest.Size = New System.Drawing.Size(977, 363)
        Me.tbpageRequest.TabIndex = 2
        Me.tbpageRequest.Text = "Request/Appointment"
        '
        'lstvwRequest
        '
        Me.lstvwRequest.AutoArrange = False
        Me.lstvwRequest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.lstvwRequest.ContextMenuStrip = Me.CMSComplaint
        Me.lstvwRequest.FullRowSelect = True
        Me.lstvwRequest.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwRequest.Location = New System.Drawing.Point(3, 3)
        Me.lstvwRequest.MultiSelect = False
        Me.lstvwRequest.Name = "lstvwRequest"
        Me.lstvwRequest.Size = New System.Drawing.Size(971, 357)
        Me.lstvwRequest.TabIndex = 1
        Me.lstvwRequest.UseCompatibleStateImageBehavior = False
        Me.lstvwRequest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "SR #"
        Me.ColumnHeader11.Width = 89
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Priority"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 54
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Department"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Name Of Complainant"
        Me.ColumnHeader14.Width = 178
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Address Of Complainant"
        Me.ColumnHeader15.Width = 238
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Contact #"
        Me.ColumnHeader16.Width = 102
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Nature Of Complaint"
        Me.ColumnHeader17.Width = 150
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Date/Time Receipt"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader18.Width = 150
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Received By"
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader19.Width = 99
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Type"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(692, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(850, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "to"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEnd
        '
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(886, 41)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(107, 22)
        Me.dtpEnd.TabIndex = 4
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(737, 41)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(107, 22)
        Me.dtpStart.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Black
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.Complaint_Management_System.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(414, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 26)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(7, 42)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(263, 22)
        Me.txtSearch.TabIndex = 0
        '
        'frmSubCompDesk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 490)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubCompDesk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub-Complaint Desk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbctrlMain.ResumeLayout(False)
        Me.tbpageEmergency.ResumeLayout(False)
        Me.CMSComplaint.ResumeLayout(False)
        Me.tbpageSurvey.ResumeLayout(False)
        Me.tbpageRequest.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstvwEmergency As System.Windows.Forms.ListView
    Friend WithEvents ServiceRequest As System.Windows.Forms.ColumnHeader
    Friend WithEvents Priority As System.Windows.Forms.ColumnHeader
    Friend WithEvents Department As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComplainantName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContactNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents NatureOfComplaint As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateReceipt As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReceivedBy As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbctrlMain As System.Windows.Forms.TabControl
    Friend WithEvents tbpageEmergency As System.Windows.Forms.TabPage
    Friend WithEvents tbpageSurvey As System.Windows.Forms.TabPage
    Friend WithEvents tbpageRequest As System.Windows.Forms.TabPage
    Friend WithEvents lstvwSurvey As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvwRequest As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CMSComplaint As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ComplaintsListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DispatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DispatchTo As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbxFilter As System.Windows.Forms.ComboBox
    Friend WithEvents ActionComplaintReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
