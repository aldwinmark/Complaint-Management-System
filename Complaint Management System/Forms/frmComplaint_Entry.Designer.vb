<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComplaint_Entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComplaint_Entry))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstvwSearch = New System.Windows.Forms.ListView()
        Me.colmnAccountNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colmnName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colmnMeterSN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colmnAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSFollowUp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnMeterNo = New System.Windows.Forms.RadioButton()
        Me.rbtnName = New System.Windows.Forms.RadioButton()
        Me.rbtnAcct = New System.Windows.Forms.RadioButton()
        Me.cmbxAction_Desired = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.txtServiceNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbxComplaintType = New System.Windows.Forms.ComboBox()
        Me.cmbxPriority = New System.Windows.Forms.ComboBox()
        Me.cmbxSendTo = New System.Windows.Forms.ComboBox()
        Me.cmbxNatureOfComplaint = New System.Windows.Forms.ComboBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpReceipt = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtMeter = New System.Windows.Forms.TextBox()
        Me.grpbxFollowUp = New System.Windows.Forms.GroupBox()
        Me.lstvwFollowUp = New System.Windows.Forms.ListView()
        Me.FUID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FUDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FURemarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.imlToolbarButtons = New System.Windows.Forms.ImageList(Me.components)
        Me.dlgBackColor = New System.Windows.Forms.ColorDialog()
        Me.dlgOpenPicture = New System.Windows.Forms.OpenFileDialog()
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.CMSFollowUp.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpbxFollowUp.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.Image = Global.Complaint_Management_System.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(567, 398)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 37)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lstvwSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmbxAction_Desired)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dtpTime)
        Me.GroupBox1.Controls.Add(Me.txtServiceNo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmbxComplaintType)
        Me.GroupBox1.Controls.Add(Me.cmbxPriority)
        Me.GroupBox1.Controls.Add(Me.cmbxSendTo)
        Me.GroupBox1.Controls.Add(Me.cmbxNatureOfComplaint)
        Me.GroupBox1.Controls.Add(Me.txtContactNo)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpReceipt)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(13, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(637, 387)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Complaint Details"
        '
        'lstvwSearch
        '
        Me.lstvwSearch.AutoArrange = False
        Me.lstvwSearch.BackColor = System.Drawing.Color.GhostWhite
        Me.lstvwSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwSearch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colmnAccountNo, Me.colmnName, Me.colmnMeterSN, Me.colmnAddress})
        Me.lstvwSearch.ContextMenuStrip = Me.CMSFollowUp
        Me.lstvwSearch.FullRowSelect = True
        Me.lstvwSearch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstvwSearch.Location = New System.Drawing.Point(15, 42)
        Me.lstvwSearch.MultiSelect = False
        Me.lstvwSearch.Name = "lstvwSearch"
        Me.lstvwSearch.Size = New System.Drawing.Size(490, 31)
        Me.lstvwSearch.TabIndex = 30
        Me.lstvwSearch.UseCompatibleStateImageBehavior = False
        Me.lstvwSearch.View = System.Windows.Forms.View.Details
        Me.lstvwSearch.Visible = False
        '
        'colmnAccountNo
        '
        Me.colmnAccountNo.Text = ""
        Me.colmnAccountNo.Width = 80
        '
        'colmnName
        '
        Me.colmnName.Text = "Search"
        Me.colmnName.Width = 258
        '
        'colmnMeterSN
        '
        Me.colmnMeterSN.Text = ""
        Me.colmnMeterSN.Width = 110
        '
        'colmnAddress
        '
        Me.colmnAddress.Text = ""
        Me.colmnAddress.Width = 0
        '
        'CMSFollowUp
        '
        Me.CMSFollowUp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.CMSFollowUp.Name = "CMSComplaint"
        Me.CMSFollowUp.Size = New System.Drawing.Size(180, 120)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AddToolStripMenuItem.Text = "Add follow-up"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EditToolStripMenuItem.Text = "Edit follow-up"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.page_white_delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete follow-up"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(176, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh follow-up"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(15, 21)
        Me.txtSearch.MaxLength = 15
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(246, 22)
        Me.txtSearch.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnMeterNo)
        Me.GroupBox2.Controls.Add(Me.rbtnName)
        Me.GroupBox2.Controls.Add(Me.rbtnAcct)
        Me.GroupBox2.Location = New System.Drawing.Point(267, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 46)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search by"
        '
        'rbtnMeterNo
        '
        Me.rbtnMeterNo.AutoSize = True
        Me.rbtnMeterNo.Location = New System.Drawing.Point(153, 17)
        Me.rbtnMeterNo.Name = "rbtnMeterNo"
        Me.rbtnMeterNo.Size = New System.Drawing.Size(59, 17)
        Me.rbtnMeterNo.TabIndex = 2
        Me.rbtnMeterNo.Text = "Meter#"
        Me.rbtnMeterNo.UseVisualStyleBackColor = True
        '
        'rbtnName
        '
        Me.rbtnName.AutoSize = True
        Me.rbtnName.Location = New System.Drawing.Point(74, 17)
        Me.rbtnName.Name = "rbtnName"
        Me.rbtnName.Size = New System.Drawing.Size(53, 17)
        Me.rbtnName.TabIndex = 1
        Me.rbtnName.Text = "Name"
        Me.rbtnName.UseVisualStyleBackColor = True
        '
        'rbtnAcct
        '
        Me.rbtnAcct.AutoSize = True
        Me.rbtnAcct.Checked = True
        Me.rbtnAcct.Location = New System.Drawing.Point(6, 17)
        Me.rbtnAcct.Name = "rbtnAcct"
        Me.rbtnAcct.Size = New System.Drawing.Size(54, 17)
        Me.rbtnAcct.TabIndex = 0
        Me.rbtnAcct.TabStop = True
        Me.rbtnAcct.Text = "Acct#"
        Me.rbtnAcct.UseVisualStyleBackColor = True
        '
        'cmbxAction_Desired
        '
        Me.cmbxAction_Desired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxAction_Desired.FormattingEnabled = True
        Me.cmbxAction_Desired.Items.AddRange(New Object() {"<select>", "3", "2", "1"})
        Me.cmbxAction_Desired.Location = New System.Drawing.Point(179, 355)
        Me.cmbxAction_Desired.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbxAction_Desired.Name = "cmbxAction_Desired"
        Me.cmbxAction_Desired.Size = New System.Drawing.Size(438, 24)
        Me.cmbxAction_Desired.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(176, 186)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(217, 16)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Lastname, Firstname MI."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(505, 327)
        Me.dtpTime.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(112, 22)
        Me.dtpTime.TabIndex = 26
        '
        'txtServiceNo
        '
        Me.txtServiceNo.Enabled = False
        Me.txtServiceNo.Location = New System.Drawing.Point(511, 47)
        Me.txtServiceNo.Name = "txtServiceNo"
        Me.txtServiceNo.Size = New System.Drawing.Size(116, 22)
        Me.txtServiceNo.TabIndex = 3
        Me.txtServiceNo.Text = "Auto Generated"
        Me.txtServiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(396, 270)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 16)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Complaint Type:"
        '
        'cmbxComplaintType
        '
        Me.cmbxComplaintType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxComplaintType.FormattingEnabled = True
        Me.cmbxComplaintType.Items.AddRange(New Object() {"<select>", "3", "2", "1"})
        Me.cmbxComplaintType.Location = New System.Drawing.Point(502, 265)
        Me.cmbxComplaintType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbxComplaintType.Name = "cmbxComplaintType"
        Me.cmbxComplaintType.Size = New System.Drawing.Size(115, 24)
        Me.cmbxComplaintType.TabIndex = 24
        '
        'cmbxPriority
        '
        Me.cmbxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxPriority.FormattingEnabled = True
        Me.cmbxPriority.Items.AddRange(New Object() {"<select>", "3", "2", "1"})
        Me.cmbxPriority.Location = New System.Drawing.Point(519, 203)
        Me.cmbxPriority.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbxPriority.Name = "cmbxPriority"
        Me.cmbxPriority.Size = New System.Drawing.Size(98, 24)
        Me.cmbxPriority.TabIndex = 6
        '
        'cmbxSendTo
        '
        Me.cmbxSendTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSendTo.FormattingEnabled = True
        Me.cmbxSendTo.Location = New System.Drawing.Point(460, 233)
        Me.cmbxSendTo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbxSendTo.Name = "cmbxSendTo"
        Me.cmbxSendTo.Size = New System.Drawing.Size(157, 24)
        Me.cmbxSendTo.TabIndex = 5
        '
        'cmbxNatureOfComplaint
        '
        Me.cmbxNatureOfComplaint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxNatureOfComplaint.FormattingEnabled = True
        Me.cmbxNatureOfComplaint.Location = New System.Drawing.Point(179, 295)
        Me.cmbxNatureOfComplaint.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbxNatureOfComplaint.Name = "cmbxNatureOfComplaint"
        Me.cmbxNatureOfComplaint.Size = New System.Drawing.Size(438, 24)
        Me.cmbxNatureOfComplaint.TabIndex = 7
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(180, 267)
        Me.txtContactNo.MaxLength = 15
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(214, 22)
        Me.txtContactNo.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Location = New System.Drawing.Point(179, 235)
        Me.txtAddress.MaxLength = 20
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(214, 22)
        Me.txtAddress.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(179, 203)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(280, 22)
        Me.txtName.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(467, 206)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Priority:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(396, 238)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Send To:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(532, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Service #:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(72, 358)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Action Desired:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(47, 328)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Date/Time Receipt:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(41, 298)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nature Of Complaint:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 270)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contact # Of Complainant:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 238)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Address Of Complainant:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(30, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Name Of Complainant:"
        '
        'dtpReceipt
        '
        Me.dtpReceipt.Location = New System.Drawing.Point(179, 327)
        Me.dtpReceipt.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpReceipt.Name = "dtpReceipt"
        Me.dtpReceipt.Size = New System.Drawing.Size(318, 22)
        Me.dtpReceipt.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAccountName)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtAccount)
        Me.GroupBox3.Controls.Add(Me.txtMeter)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(612, 101)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Optional entries"
        '
        'txtAccountName
        '
        Me.txtAccountName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccountName.Location = New System.Drawing.Point(164, 43)
        Me.txtAccountName.MaxLength = 50
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(438, 22)
        Me.txtAccountName.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(59, 46)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 16)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Account Name:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(164, 70)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(438, 22)
        Me.txtEmail.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(384, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Meter #     :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(59, 73)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Email address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(88, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Account #:"
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(164, 15)
        Me.txtAccount.MaxLength = 15
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(214, 22)
        Me.txtAccount.TabIndex = 0
        '
        'txtMeter
        '
        Me.txtMeter.Location = New System.Drawing.Point(461, 15)
        Me.txtMeter.MaxLength = 20
        Me.txtMeter.Name = "txtMeter"
        Me.txtMeter.Size = New System.Drawing.Size(141, 22)
        Me.txtMeter.TabIndex = 1
        '
        'grpbxFollowUp
        '
        Me.grpbxFollowUp.BackColor = System.Drawing.Color.Transparent
        Me.grpbxFollowUp.Controls.Add(Me.lstvwFollowUp)
        Me.grpbxFollowUp.ForeColor = System.Drawing.Color.Black
        Me.grpbxFollowUp.Location = New System.Drawing.Point(657, 13)
        Me.grpbxFollowUp.Name = "grpbxFollowUp"
        Me.grpbxFollowUp.Size = New System.Drawing.Size(271, 371)
        Me.grpbxFollowUp.TabIndex = 3
        Me.grpbxFollowUp.TabStop = False
        Me.grpbxFollowUp.Text = "Follow-up"
        '
        'lstvwFollowUp
        '
        Me.lstvwFollowUp.AutoArrange = False
        Me.lstvwFollowUp.BackColor = System.Drawing.Color.GhostWhite
        Me.lstvwFollowUp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FUID, Me.SR, Me.FUDate, Me.FURemarks})
        Me.lstvwFollowUp.ContextMenuStrip = Me.CMSFollowUp
        Me.lstvwFollowUp.FullRowSelect = True
        Me.lstvwFollowUp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwFollowUp.Location = New System.Drawing.Point(6, 21)
        Me.lstvwFollowUp.MultiSelect = False
        Me.lstvwFollowUp.Name = "lstvwFollowUp"
        Me.lstvwFollowUp.Size = New System.Drawing.Size(255, 344)
        Me.lstvwFollowUp.TabIndex = 4
        Me.lstvwFollowUp.UseCompatibleStateImageBehavior = False
        Me.lstvwFollowUp.View = System.Windows.Forms.View.Details
        '
        'FUID
        '
        Me.FUID.Text = ""
        Me.FUID.Width = 0
        '
        'SR
        '
        Me.SR.Text = "SR"
        Me.SR.Width = 0
        '
        'FUDate
        '
        Me.FUDate.Text = "Date"
        Me.FUDate.Width = 100
        '
        'FURemarks
        '
        Me.FURemarks.Text = "Remarks"
        Me.FURemarks.Width = 142
        '
        'btnEntry
        '
        Me.btnEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEntry.Image = CType(resources.GetObject("btnEntry.Image"), System.Drawing.Image)
        Me.btnEntry.Location = New System.Drawing.Point(476, 398)
        Me.btnEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(83, 37)
        Me.btnEntry.TabIndex = 1
        Me.btnEntry.Text = "Save"
        Me.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "OpenFileDialog1"
        Me.ofdImage.Filter = "Graphics Files|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tif;*.tiff|All Files|*.*"
        '
        'imlToolbarButtons
        '
        Me.imlToolbarButtons.ImageStream = CType(resources.GetObject("imlToolbarButtons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlToolbarButtons.TransparentColor = System.Drawing.Color.Transparent
        Me.imlToolbarButtons.Images.SetKeyName(0, "")
        Me.imlToolbarButtons.Images.SetKeyName(1, "")
        Me.imlToolbarButtons.Images.SetKeyName(2, "")
        Me.imlToolbarButtons.Images.SetKeyName(3, "")
        Me.imlToolbarButtons.Images.SetKeyName(4, "")
        Me.imlToolbarButtons.Images.SetKeyName(5, "")
        Me.imlToolbarButtons.Images.SetKeyName(6, "")
        Me.imlToolbarButtons.Images.SetKeyName(7, "")
        Me.imlToolbarButtons.Images.SetKeyName(8, "tbtnImage.bmp")
        '
        'dlgOpenPicture
        '
        Me.dlgOpenPicture.Filter = "Picture Files (*.pic)|*.pic|All FIles (*.*)|*.*"
        '
        'sfdImage
        '
        Me.sfdImage.Filter = "Graphics Files|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tif;*.tiff|All Files|*.*"
        '
        'frmComplaint_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(935, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxFollowUp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEntry)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComplaint_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complaint"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.CMSFollowUp.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpbxFollowUp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEntry As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpReceipt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMeter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents cmbxNatureOfComplaint As System.Windows.Forms.ComboBox
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbxPriority As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxSendTo As System.Windows.Forms.ComboBox
    Friend WithEvents txtServiceNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAccountName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbxComplaintType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbxAction_Desired As System.Windows.Forms.ComboBox
    Friend WithEvents grpbxFollowUp As System.Windows.Forms.GroupBox
    Friend WithEvents lstvwFollowUp As System.Windows.Forms.ListView
    Friend WithEvents FUDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMSFollowUp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FURemarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents FUID As System.Windows.Forms.ColumnHeader
    Friend WithEvents SR As System.Windows.Forms.ColumnHeader
    Friend WithEvents imlToolbarButtons As System.Windows.Forms.ImageList
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgBackColor As System.Windows.Forms.ColorDialog
    Friend WithEvents dlgOpenPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdImage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnName As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAcct As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMeterNo As System.Windows.Forms.RadioButton
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstvwSearch As System.Windows.Forms.ListView
    Friend WithEvents colmnAccountNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnMeterSN As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnAddress As System.Windows.Forms.ColumnHeader
End Class
