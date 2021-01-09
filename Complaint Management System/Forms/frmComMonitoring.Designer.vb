<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComMonitoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComMonitoring))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lstvwComplaints = New System.Windows.Forms.ListView()
        Me.ServiceRequest = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NameOC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NatureOC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DTReceived = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReceivedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ActionTaken = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateTimeAction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ActionTakenBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Account = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Contact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Agency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateTimeTaken = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintMonitoringReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotalRecords = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbxDepartment = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbxRecievedBy = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UnAttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Black
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Global.Complaint_Management_System.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(511, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 23)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lstvwComplaints
        '
        Me.lstvwComplaints.AutoArrange = False
        Me.lstvwComplaints.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ServiceRequest, Me.NameOC, Me.NatureOC, Me.DTReceived, Me.ReceivedBy, Me.Type, Me.ActionTaken, Me.DateTimeAction, Me.ActionTakenBy, Me.Account, Me.Address, Me.Contact, Me.MR, Me.Agency, Me.DateTimeTaken})
        Me.lstvwComplaints.ContextMenuStrip = Me.CMS
        Me.lstvwComplaints.FullRowSelect = True
        Me.lstvwComplaints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwComplaints.Location = New System.Drawing.Point(12, 69)
        Me.lstvwComplaints.MultiSelect = False
        Me.lstvwComplaints.Name = "lstvwComplaints"
        Me.lstvwComplaints.Size = New System.Drawing.Size(1032, 367)
        Me.lstvwComplaints.TabIndex = 20
        Me.lstvwComplaints.UseCompatibleStateImageBehavior = False
        Me.lstvwComplaints.View = System.Windows.Forms.View.Details
        '
        'ServiceRequest
        '
        Me.ServiceRequest.Text = "SR #"
        Me.ServiceRequest.Width = 89
        '
        'NameOC
        '
        Me.NameOC.Text = "Name Of Complainant"
        Me.NameOC.Width = 150
        '
        'NatureOC
        '
        Me.NatureOC.Text = "Nature Of Complaint"
        Me.NatureOC.Width = 150
        '
        'DTReceived
        '
        Me.DTReceived.Text = "Date Received"
        Me.DTReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DTReceived.Width = 120
        '
        'ReceivedBy
        '
        Me.ReceivedBy.Text = "Received By"
        Me.ReceivedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ReceivedBy.Width = 100
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Type.Width = 100
        '
        'ActionTaken
        '
        Me.ActionTaken.Text = "Action Taken"
        Me.ActionTaken.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ActionTaken.Width = 100
        '
        'DateTimeAction
        '
        Me.DateTimeAction.Text = "Datetime Of Action"
        Me.DateTimeAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DateTimeAction.Width = 150
        '
        'ActionTakenBy
        '
        Me.ActionTakenBy.Text = "Dispatch to"
        Me.ActionTakenBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ActionTakenBy.Width = 150
        '
        'Account
        '
        Me.Account.Text = "Account"
        '
        'Address
        '
        Me.Address.Text = "Address"
        '
        'Contact
        '
        Me.Contact.Text = "Contact"
        '
        'MR
        '
        Me.MR.Text = "MR"
        '
        'Agency
        '
        Me.Agency.Text = "Agency"
        '
        'DateTimeTaken
        '
        Me.DateTimeTaken.Text = ""
        Me.DateTimeTaken.Width = 0
        '
        'CMS
        '
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ToolStripSeparator2, Me.UnAttToolStripMenuItem, Me.AttToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.CMS.Name = "CMSComplaint"
        Me.CMS.Size = New System.Drawing.Size(208, 148)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintMonitoringReportToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ComplaintMonitoringReportToolStripMenuItem
        '
        Me.ComplaintMonitoringReportToolStripMenuItem.Name = "ComplaintMonitoringReportToolStripMenuItem"
        Me.ComplaintMonitoringReportToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ComplaintMonitoringReportToolStripMenuItem.Text = "Complaint Monitoring Report"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(204, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalRecords.ForeColor = System.Drawing.Color.Black
        Me.lblTotalRecords.Location = New System.Drawing.Point(118, 443)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Size = New System.Drawing.Size(118, 20)
        Me.lblTotalRecords.TabIndex = 22
        Me.lblTotalRecords.Text = "0"
        Me.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Total record(s):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbxDepartment
        '
        Me.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDepartment.FormattingEnabled = True
        Me.cmbxDepartment.Location = New System.Drawing.Point(103, 18)
        Me.cmbxDepartment.Name = "cmbxDepartment"
        Me.cmbxDepartment.Size = New System.Drawing.Size(121, 24)
        Me.cmbxDepartment.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Department :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbxRecievedBy)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbxDepartment)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1032, 51)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'cmbxRecievedBy
        '
        Me.cmbxRecievedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxRecievedBy.FormattingEnabled = True
        Me.cmbxRecievedBy.Location = New System.Drawing.Point(341, 18)
        Me.cmbxRecievedBy.Name = "cmbxRecievedBy"
        Me.cmbxRecievedBy.Size = New System.Drawing.Size(164, 24)
        Me.cmbxRecievedBy.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(723, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(230, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Recieved By :"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(881, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "to"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEnd
        '
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(917, 18)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(107, 22)
        Me.dtpEnd.TabIndex = 28
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(768, 18)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(107, 22)
        Me.dtpStart.TabIndex = 27
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'AttToolStripMenuItem
        '
        Me.AttToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.AttToolStripMenuItem.Name = "AttToolStripMenuItem"
        Me.AttToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AttToolStripMenuItem.Text = "Attended Complaints"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(204, 6)
        '
        'UnAttToolStripMenuItem
        '
        Me.UnAttToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnAttToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UnAttToolStripMenuItem.Name = "UnAttToolStripMenuItem"
        Me.UnAttToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.UnAttToolStripMenuItem.Text = "Unattended Complaints"
        '
        'frmComMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1056, 468)
        Me.Controls.Add(Me.lblTotalRecords)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstvwComplaints)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComMonitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring"
        Me.CMS.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lstvwComplaints As System.Windows.Forms.ListView
    Friend WithEvents ServiceRequest As System.Windows.Forms.ColumnHeader
    Friend WithEvents NameOC As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalRecords As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxRecievedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents NatureOC As System.Windows.Forms.ColumnHeader
    Friend WithEvents DTReceived As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReceivedBy As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents ActionTaken As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTimeAction As System.Windows.Forms.ColumnHeader
    Friend WithEvents ActionTakenBy As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ComplaintMonitoringReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Account As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents Contact As System.Windows.Forms.ColumnHeader
    Friend WithEvents MR As System.Windows.Forms.ColumnHeader
    Friend WithEvents Agency As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTimeTaken As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UnAttToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
