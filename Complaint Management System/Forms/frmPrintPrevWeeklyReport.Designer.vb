<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPrevWeeklyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintPrevWeeklyReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbxDepartment = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.lblPreparedBy = New System.Windows.Forms.Label()
        Me.cmbxPreparedBy = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblReviewedBy = New System.Windows.Forms.Label()
        Me.cmbxReviewedBy = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMonitoredBy = New System.Windows.Forms.Label()
        Me.cmbxMonitoredBy = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNotedBy = New System.Windows.Forms.Label()
        Me.cmbxNotedBy = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblNotedBy)
        Me.GroupBox1.Controls.Add(Me.cmbxNotedBy)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblMonitoredBy)
        Me.GroupBox1.Controls.Add(Me.cmbxMonitoredBy)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblReviewedBy)
        Me.GroupBox1.Controls.Add(Me.cmbxReviewedBy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPreparedBy)
        Me.GroupBox1.Controls.Add(Me.cmbxPreparedBy)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbxDepartment)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(459, 322)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpDateEnd)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpDateStart)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(439, 53)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(213, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "End date:"
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateEnd.Location = New System.Drawing.Point(282, 18)
        Me.dtpDateEnd.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.Size = New System.Drawing.Size(121, 22)
        Me.dtpDateEnd.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Start date:"
        '
        'dtpDateStart
        '
        Me.dtpDateStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateStart.Location = New System.Drawing.Point(83, 18)
        Me.dtpDateStart.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpDateStart.Name = "dtpDateStart"
        Me.dtpDateStart.Size = New System.Drawing.Size(121, 22)
        Me.dtpDateStart.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 280)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Department:"
        '
        'cmbxDepartment
        '
        Me.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxDepartment.FormattingEnabled = True
        Me.cmbxDepartment.Location = New System.Drawing.Point(99, 277)
        Me.cmbxDepartment.Name = "cmbxDepartment"
        Me.cmbxDepartment.Size = New System.Drawing.Size(349, 24)
        Me.cmbxDepartment.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Complaint_Management_System.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(389, 349)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 39)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEntry
        '
        Me.btnEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntry.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnEntry.Image = Global.Complaint_Management_System.My.Resources.Resources.printer
        Me.btnEntry.Location = New System.Drawing.Point(248, 349)
        Me.btnEntry.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(129, 39)
        Me.btnEntry.TabIndex = 12
        Me.btnEntry.Text = "Print Preview"
        Me.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'lblPreparedBy
        '
        Me.lblPreparedBy.ForeColor = System.Drawing.Color.Black
        Me.lblPreparedBy.Location = New System.Drawing.Point(96, 69)
        Me.lblPreparedBy.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPreparedBy.Name = "lblPreparedBy"
        Me.lblPreparedBy.Size = New System.Drawing.Size(293, 16)
        Me.lblPreparedBy.TabIndex = 38
        Me.lblPreparedBy.Text = "Preparedby"
        Me.lblPreparedBy.Visible = False
        '
        'cmbxPreparedBy
        '
        Me.cmbxPreparedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxPreparedBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxPreparedBy.FormattingEnabled = True
        Me.cmbxPreparedBy.Location = New System.Drawing.Point(98, 86)
        Me.cmbxPreparedBy.Name = "cmbxPreparedBy"
        Me.cmbxPreparedBy.Size = New System.Drawing.Size(350, 24)
        Me.cmbxPreparedBy.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Prepared by:"
        '
        'lblReviewedBy
        '
        Me.lblReviewedBy.ForeColor = System.Drawing.Color.Black
        Me.lblReviewedBy.Location = New System.Drawing.Point(97, 119)
        Me.lblReviewedBy.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblReviewedBy.Name = "lblReviewedBy"
        Me.lblReviewedBy.Size = New System.Drawing.Size(293, 16)
        Me.lblReviewedBy.TabIndex = 41
        Me.lblReviewedBy.Text = "Reviewed by:"
        Me.lblReviewedBy.Visible = False
        '
        'cmbxReviewedBy
        '
        Me.cmbxReviewedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxReviewedBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxReviewedBy.FormattingEnabled = True
        Me.cmbxReviewedBy.Location = New System.Drawing.Point(99, 136)
        Me.cmbxReviewedBy.Name = "cmbxReviewedBy"
        Me.cmbxReviewedBy.Size = New System.Drawing.Size(349, 24)
        Me.cmbxReviewedBy.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 139)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Reviewed by:"
        '
        'lblMonitoredBy
        '
        Me.lblMonitoredBy.ForeColor = System.Drawing.Color.Black
        Me.lblMonitoredBy.Location = New System.Drawing.Point(97, 169)
        Me.lblMonitoredBy.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMonitoredBy.Name = "lblMonitoredBy"
        Me.lblMonitoredBy.Size = New System.Drawing.Size(293, 16)
        Me.lblMonitoredBy.TabIndex = 44
        Me.lblMonitoredBy.Text = "Monitored by:"
        Me.lblMonitoredBy.Visible = False
        '
        'cmbxMonitoredBy
        '
        Me.cmbxMonitoredBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxMonitoredBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxMonitoredBy.FormattingEnabled = True
        Me.cmbxMonitoredBy.Location = New System.Drawing.Point(99, 186)
        Me.cmbxMonitoredBy.Name = "cmbxMonitoredBy"
        Me.cmbxMonitoredBy.Size = New System.Drawing.Size(349, 24)
        Me.cmbxMonitoredBy.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(5, 189)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Monitored by:"
        '
        'lblNotedBy
        '
        Me.lblNotedBy.ForeColor = System.Drawing.Color.Black
        Me.lblNotedBy.Location = New System.Drawing.Point(97, 218)
        Me.lblNotedBy.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNotedBy.Name = "lblNotedBy"
        Me.lblNotedBy.Size = New System.Drawing.Size(293, 16)
        Me.lblNotedBy.TabIndex = 47
        Me.lblNotedBy.Text = "Noted by:"
        Me.lblNotedBy.Visible = False
        '
        'cmbxNotedBy
        '
        Me.cmbxNotedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxNotedBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxNotedBy.FormattingEnabled = True
        Me.cmbxNotedBy.Location = New System.Drawing.Point(99, 235)
        Me.cmbxNotedBy.Name = "cmbxNotedBy"
        Me.cmbxNotedBy.Size = New System.Drawing.Size(349, 24)
        Me.cmbxNotedBy.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(5, 238)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Noted by:"
        '
        'frmPrintPrevWeeklyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEntry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPrintPrevWeeklyReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEntry As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents lblNotedBy As System.Windows.Forms.Label
    Friend WithEvents cmbxNotedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMonitoredBy As System.Windows.Forms.Label
    Friend WithEvents cmbxMonitoredBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblReviewedBy As System.Windows.Forms.Label
    Friend WithEvents cmbxReviewedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPreparedBy As System.Windows.Forms.Label
    Friend WithEvents cmbxPreparedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
