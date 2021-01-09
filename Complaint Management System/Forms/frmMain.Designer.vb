<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MSComplaint = New System.Windows.Forms.MenuStrip()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoutingSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaComplaintListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComplaintActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivedComplaintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowerInterruptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonPowerInterruptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintListToERCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintByNOCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroubleshooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NatureOfComplaintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionDesiredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeederNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionTakenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SSComplaint = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUserLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblArea = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEmployeeName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.WeeklySummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSComplaint.SuspendLayout()
        Me.SSComplaint.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSComplaint
        '
        Me.MSComplaint.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MSComplaint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSComplaint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemToolStripMenuItem, Me.DataToolStripMenuItem, Me.MonitoringToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.MaintenanceToolStripMenuItem})
        Me.MSComplaint.Location = New System.Drawing.Point(0, 0)
        Me.MSComplaint.Name = "MSComplaint"
        Me.MSComplaint.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MSComplaint.Size = New System.Drawing.Size(1006, 24)
        Me.MSComplaint.TabIndex = 0
        Me.MSComplaint.Text = "MenuStrip1"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SystemToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.SystemToolStripMenuItem.Image = CType(resources.GetObject("SystemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogoutToolStripMenuItem.Text = "Log-out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintListToolStripMenuItem, Me.RoutingSlipToolStripMenuItem, Me.AreaComplaintListToolStripMenuItem, Me.ToolStripSeparator1, Me.ComplaintActionToolStripMenuItem, Me.ReceivedComplaintToolStripMenuItem, Me.PowerInterruptionToolStripMenuItem})
        Me.DataToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.DataToolStripMenuItem.Image = CType(resources.GetObject("DataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'ComplaintListToolStripMenuItem
        '
        Me.ComplaintListToolStripMenuItem.Image = CType(resources.GetObject("ComplaintListToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComplaintListToolStripMenuItem.Name = "ComplaintListToolStripMenuItem"
        Me.ComplaintListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComplaintListToolStripMenuItem.Text = "&Complaint List"
        '
        'RoutingSlipToolStripMenuItem
        '
        Me.RoutingSlipToolStripMenuItem.Image = CType(resources.GetObject("RoutingSlipToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RoutingSlipToolStripMenuItem.Name = "RoutingSlipToolStripMenuItem"
        Me.RoutingSlipToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RoutingSlipToolStripMenuItem.Text = "&Routing Slip"
        '
        'AreaComplaintListToolStripMenuItem
        '
        Me.AreaComplaintListToolStripMenuItem.Image = CType(resources.GetObject("AreaComplaintListToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AreaComplaintListToolStripMenuItem.Name = "AreaComplaintListToolStripMenuItem"
        Me.AreaComplaintListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AreaComplaintListToolStripMenuItem.Text = "&Area Complaint List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ComplaintActionToolStripMenuItem
        '
        Me.ComplaintActionToolStripMenuItem.Image = CType(resources.GetObject("ComplaintActionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComplaintActionToolStripMenuItem.Name = "ComplaintActionToolStripMenuItem"
        Me.ComplaintActionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComplaintActionToolStripMenuItem.Text = "C&omplaint Action"
        '
        'ReceivedComplaintToolStripMenuItem
        '
        Me.ReceivedComplaintToolStripMenuItem.Name = "ReceivedComplaintToolStripMenuItem"
        Me.ReceivedComplaintToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReceivedComplaintToolStripMenuItem.Text = "R&eceived Complaint"
        '
        'PowerInterruptionToolStripMenuItem
        '
        Me.PowerInterruptionToolStripMenuItem.Name = "PowerInterruptionToolStripMenuItem"
        Me.PowerInterruptionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PowerInterruptionToolStripMenuItem.Text = "&Power Interruption"
        Me.PowerInterruptionToolStripMenuItem.Visible = False
        '
        'MonitoringToolStripMenuItem
        '
        Me.MonitoringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintsToolStripMenuItem, Me.MonPowerInterruptionToolStripMenuItem})
        Me.MonitoringToolStripMenuItem.Image = CType(resources.GetObject("MonitoringToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MonitoringToolStripMenuItem.Name = "MonitoringToolStripMenuItem"
        Me.MonitoringToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.MonitoringToolStripMenuItem.Text = "Monitoring"
        '
        'ComplaintsToolStripMenuItem
        '
        Me.ComplaintsToolStripMenuItem.Image = CType(resources.GetObject("ComplaintsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComplaintsToolStripMenuItem.Name = "ComplaintsToolStripMenuItem"
        Me.ComplaintsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ComplaintsToolStripMenuItem.Text = "Complaints"
        '
        'MonPowerInterruptionToolStripMenuItem
        '
        Me.MonPowerInterruptionToolStripMenuItem.Image = CType(resources.GetObject("MonPowerInterruptionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MonPowerInterruptionToolStripMenuItem.Name = "MonPowerInterruptionToolStripMenuItem"
        Me.MonPowerInterruptionToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.MonPowerInterruptionToolStripMenuItem.Text = "Power Interruption"
        Me.MonPowerInterruptionToolStripMenuItem.Visible = False
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintListToERCToolStripMenuItem, Me.ComplaintSummaryToolStripMenuItem, Me.ComplaintByNOCToolStripMenuItem, Me.WeeklySummaryToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Image = CType(resources.GetObject("ReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ComplaintListToERCToolStripMenuItem
        '
        Me.ComplaintListToERCToolStripMenuItem.Image = CType(resources.GetObject("ComplaintListToERCToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComplaintListToERCToolStripMenuItem.Name = "ComplaintListToERCToolStripMenuItem"
        Me.ComplaintListToERCToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ComplaintListToERCToolStripMenuItem.Text = "Complaint List to ERC"
        '
        'ComplaintSummaryToolStripMenuItem
        '
        Me.ComplaintSummaryToolStripMenuItem.Image = CType(resources.GetObject("ComplaintSummaryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComplaintSummaryToolStripMenuItem.Name = "ComplaintSummaryToolStripMenuItem"
        Me.ComplaintSummaryToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ComplaintSummaryToolStripMenuItem.Text = "Complaint Summary"
        '
        'ComplaintByNOCToolStripMenuItem
        '
        Me.ComplaintByNOCToolStripMenuItem.Image = Global.Complaint_Management_System.My.Resources.Resources.bricks
        Me.ComplaintByNOCToolStripMenuItem.Name = "ComplaintByNOCToolStripMenuItem"
        Me.ComplaintByNOCToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ComplaintByNOCToolStripMenuItem.Text = "Complaint By NOC"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAccountToolStripMenuItem, Me.DepartmentsToolStripMenuItem, Me.TroubleshooterToolStripMenuItem, Me.NatureOfComplaintToolStripMenuItem, Me.DesignationToolStripMenuItem, Me.ComplaintTypeToolStripMenuItem, Me.ActionDesiredToolStripMenuItem, Me.FeederNameToolStripMenuItem, Me.ActionTakenToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.MaintenanceToolStripMenuItem.Image = CType(resources.GetObject("MaintenanceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'UserAccountToolStripMenuItem
        '
        Me.UserAccountToolStripMenuItem.Image = CType(resources.GetObject("UserAccountToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserAccountToolStripMenuItem.Name = "UserAccountToolStripMenuItem"
        Me.UserAccountToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.UserAccountToolStripMenuItem.Text = "User Account"
        '
        'DepartmentsToolStripMenuItem
        '
        Me.DepartmentsToolStripMenuItem.Image = CType(resources.GetObject("DepartmentsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        Me.DepartmentsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DepartmentsToolStripMenuItem.Text = "Area/Office/Departments"
        '
        'TroubleshooterToolStripMenuItem
        '
        Me.TroubleshooterToolStripMenuItem.Image = CType(resources.GetObject("TroubleshooterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TroubleshooterToolStripMenuItem.Name = "TroubleshooterToolStripMenuItem"
        Me.TroubleshooterToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.TroubleshooterToolStripMenuItem.Text = "Employee"
        '
        'NatureOfComplaintToolStripMenuItem
        '
        Me.NatureOfComplaintToolStripMenuItem.Image = CType(resources.GetObject("NatureOfComplaintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NatureOfComplaintToolStripMenuItem.Name = "NatureOfComplaintToolStripMenuItem"
        Me.NatureOfComplaintToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.NatureOfComplaintToolStripMenuItem.Text = "Nature Of Complaint"
        '
        'DesignationToolStripMenuItem
        '
        Me.DesignationToolStripMenuItem.Image = CType(resources.GetObject("DesignationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DesignationToolStripMenuItem.Name = "DesignationToolStripMenuItem"
        Me.DesignationToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DesignationToolStripMenuItem.Text = "Designation"
        '
        'ComplaintTypeToolStripMenuItem
        '
        Me.ComplaintTypeToolStripMenuItem.Image = CType(resources.GetObject("ComplaintTypeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComplaintTypeToolStripMenuItem.Name = "ComplaintTypeToolStripMenuItem"
        Me.ComplaintTypeToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ComplaintTypeToolStripMenuItem.Text = "Complaint Type"
        '
        'ActionDesiredToolStripMenuItem
        '
        Me.ActionDesiredToolStripMenuItem.Image = CType(resources.GetObject("ActionDesiredToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActionDesiredToolStripMenuItem.Name = "ActionDesiredToolStripMenuItem"
        Me.ActionDesiredToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ActionDesiredToolStripMenuItem.Text = "Action Desired"
        '
        'FeederNameToolStripMenuItem
        '
        Me.FeederNameToolStripMenuItem.Image = CType(resources.GetObject("FeederNameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FeederNameToolStripMenuItem.Name = "FeederNameToolStripMenuItem"
        Me.FeederNameToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FeederNameToolStripMenuItem.Text = "Feeder Name"
        '
        'ActionTakenToolStripMenuItem
        '
        Me.ActionTakenToolStripMenuItem.Image = CType(resources.GetObject("ActionTakenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActionTakenToolStripMenuItem.Name = "ActionTakenToolStripMenuItem"
        Me.ActionTakenToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ActionTakenToolStripMenuItem.Text = "Action Taken"
        '
        'SSComplaint
        '
        Me.SSComplaint.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SSComplaint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSComplaint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsername, Me.ToolStripStatusLabel2, Me.lblUserLevel, Me.ToolStripStatusLabel3, Me.lblArea, Me.lblEmployeeName})
        Me.SSComplaint.Location = New System.Drawing.Point(0, 385)
        Me.SSComplaint.Name = "SSComplaint"
        Me.SSComplaint.Size = New System.Drawing.Size(1006, 22)
        Me.SSComplaint.TabIndex = 1
        Me.SSComplaint.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 17)
        Me.ToolStripStatusLabel1.Text = "Username:"
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(50, 17)
        Me.lblUsername.Text = "-------"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(70, 17)
        Me.ToolStripStatusLabel2.Text = "User-level:"
        '
        'lblUserLevel
        '
        Me.lblUserLevel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(50, 17)
        Me.lblUserLevel.Text = "-------"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(150, 17)
        Me.ToolStripStatusLabel3.Text = "Area/Office/Department:"
        '
        'lblArea
        '
        Me.lblArea.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(50, 17)
        Me.lblArea.Text = "-------"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(109, 17)
        Me.lblEmployeeName.Text = "lblEmployeeName"
        Me.lblEmployeeName.Visible = False
        '
        'WeeklySummaryToolStripMenuItem
        '
        Me.WeeklySummaryToolStripMenuItem.Image = CType(resources.GetObject("WeeklySummaryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WeeklySummaryToolStripMenuItem.Name = "WeeklySummaryToolStripMenuItem"
        Me.WeeklySummaryToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.WeeklySummaryToolStripMenuItem.Text = "Weekly Summary"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 407)
        Me.Controls.Add(Me.SSComplaint)
        Me.Controls.Add(Me.MSComplaint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MSComplaint
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complaint Database Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSComplaint.ResumeLayout(False)
        Me.MSComplaint.PerformLayout()
        Me.SSComplaint.ResumeLayout(False)
        Me.SSComplaint.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MSComplaint As System.Windows.Forms.MenuStrip
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SSComplaint As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUserLevel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblArea As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TroubleshooterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NatureOfComplaintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoutingSlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaComplaintListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ComplaintActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintListToERCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEmployeeName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ComplaintTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceivedComplaintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PowerInterruptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonPowerInterruptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionDesiredToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeederNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionTakenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintByNOCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeeklySummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
