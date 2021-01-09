<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivedCompl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceivedCompl))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSendTo = New System.Windows.Forms.Label()
        Me.lblDateCreated = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbxRoutingSlip = New System.Windows.Forms.ComboBox()
        Me.cmbxFilter = New System.Windows.Forms.ComboBox()
        Me.chkbxAll = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
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
        Me.Transferred = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecieveComplaintsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.lblSendTo)
        Me.GroupBox1.Controls.Add(Me.lblDateCreated)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbxRoutingSlip)
        Me.GroupBox1.Controls.Add(Me.cmbxFilter)
        Me.GroupBox1.Controls.Add(Me.chkbxAll)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.lstvwComplaints)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1026, 465)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Complaint Details"
        '
        'lblSendTo
        '
        Me.lblSendTo.AutoSize = True
        Me.lblSendTo.ForeColor = System.Drawing.Color.Black
        Me.lblSendTo.Location = New System.Drawing.Point(502, 45)
        Me.lblSendTo.Name = "lblSendTo"
        Me.lblSendTo.Size = New System.Drawing.Size(64, 16)
        Me.lblSendTo.TabIndex = 20
        Me.lblSendTo.Text = "--------------"
        Me.lblSendTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateCreated
        '
        Me.lblDateCreated.AutoSize = True
        Me.lblDateCreated.ForeColor = System.Drawing.Color.Black
        Me.lblDateCreated.Location = New System.Drawing.Point(502, 23)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.Size = New System.Drawing.Size(64, 16)
        Me.lblDateCreated.TabIndex = 19
        Me.lblDateCreated.Text = "--------------"
        Me.lblDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(442, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(442, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Send to:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbxRoutingSlip
        '
        Me.cmbxRoutingSlip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxRoutingSlip.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxRoutingSlip.FormattingEnabled = True
        Me.cmbxRoutingSlip.Location = New System.Drawing.Point(312, 19)
        Me.cmbxRoutingSlip.Name = "cmbxRoutingSlip"
        Me.cmbxRoutingSlip.Size = New System.Drawing.Size(124, 24)
        Me.cmbxRoutingSlip.TabIndex = 15
        '
        'cmbxFilter
        '
        Me.cmbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxFilter.FormattingEnabled = True
        Me.cmbxFilter.Items.AddRange(New Object() {"SR#", "Priority", "Department", "Name", "Address", "Contact#", "Nature", "Received by", "Type"})
        Me.cmbxFilter.Location = New System.Drawing.Point(99, 43)
        Me.cmbxFilter.Name = "cmbxFilter"
        Me.cmbxFilter.Size = New System.Drawing.Size(126, 24)
        Me.cmbxFilter.TabIndex = 14
        '
        'chkbxAll
        '
        Me.chkbxAll.AutoSize = True
        Me.chkbxAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkbxAll.ForeColor = System.Drawing.Color.Black
        Me.chkbxAll.Location = New System.Drawing.Point(6, 47)
        Me.chkbxAll.Name = "chkbxAll"
        Me.chkbxAll.Size = New System.Drawing.Size(69, 17)
        Me.chkbxAll.TabIndex = 13
        Me.chkbxAll.Text = "Check All"
        Me.chkbxAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(865, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(911, 19)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(109, 22)
        Me.dtpDate.TabIndex = 9
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(231, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(6, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(219, 22)
        Me.txtSearch.TabIndex = 7
        '
        'lstvwComplaints
        '
        Me.lstvwComplaints.AutoArrange = False
        Me.lstvwComplaints.CheckBoxes = True
        Me.lstvwComplaints.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ServiceRequest, Me.Priority, Me.Department, Me.ComplainantName, Me.Address, Me.ContactNo, Me.NatureOfComplaint, Me.DateReceipt, Me.ReceivedBy, Me.Type, Me.Transferred})
        Me.lstvwComplaints.ContextMenuStrip = Me.CMS
        Me.lstvwComplaints.FullRowSelect = True
        Me.lstvwComplaints.GridLines = True
        Me.lstvwComplaints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwComplaints.Location = New System.Drawing.Point(6, 72)
        Me.lstvwComplaints.MultiSelect = False
        Me.lstvwComplaints.Name = "lstvwComplaints"
        Me.lstvwComplaints.Size = New System.Drawing.Size(1014, 387)
        Me.lstvwComplaints.TabIndex = 1
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
        'Transferred
        '
        Me.Transferred.Text = "Transferred"
        Me.Transferred.Width = 0
        '
        'CMS
        '
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecieveComplaintsToolStripMenuItem})
        Me.CMS.Name = "CMSComplaint"
        Me.CMS.Size = New System.Drawing.Size(168, 26)
        '
        'RecieveComplaintsToolStripMenuItem
        '
        Me.RecieveComplaintsToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.page_save
        Me.RecieveComplaintsToolStripMenuItem.Name = "RecieveComplaintsToolStripMenuItem"
        Me.RecieveComplaintsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RecieveComplaintsToolStripMenuItem.Text = "Recieve Complaints"
        '
        'frmReceivedCompl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 486)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReceivedCompl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Received Complaint"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxFilter As System.Windows.Forms.ComboBox
    Friend WithEvents chkbxAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstvwComplaints As System.Windows.Forms.ListView
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
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RecieveComplaintsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Transferred As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbxRoutingSlip As System.Windows.Forms.ComboBox
    Friend WithEvents lblSendTo As System.Windows.Forms.Label
    Friend WithEvents lblDateCreated As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
