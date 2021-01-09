<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPrevToERC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintPrevToERC))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbtnDate = New System.Windows.Forms.RadioButton()
        Me.rbtnNatureOfComplaint = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbxDepartment = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblNotedby = New System.Windows.Forms.Label()
        Me.lblReviewedby = New System.Windows.Forms.Label()
        Me.lblPreparedby = New System.Windows.Forms.Label()
        Me.cmbxPreparedBy = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbxReviewedBy = New System.Windows.Forms.ComboBox()
        Me.cmbxNotedBy = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Complaint_Management_System.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(341, 344)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 34)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEntry
        '
        Me.btnEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntry.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnEntry.Image = Global.Complaint_Management_System.My.Resources.Resources.printer
        Me.btnEntry.Location = New System.Drawing.Point(207, 344)
        Me.btnEntry.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(124, 34)
        Me.btnEntry.TabIndex = 6
        Me.btnEntry.Text = "Print Preview"
        Me.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbxDepartment)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(425, 322)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbtnDate)
        Me.GroupBox4.Controls.Add(Me.rbtnNatureOfComplaint)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(66, 122)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(351, 41)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sort by:"
        Me.GroupBox4.Visible = False
        '
        'rbtnDate
        '
        Me.rbtnDate.AutoSize = True
        Me.rbtnDate.ForeColor = System.Drawing.Color.Black
        Me.rbtnDate.Location = New System.Drawing.Point(240, 15)
        Me.rbtnDate.Name = "rbtnDate"
        Me.rbtnDate.Size = New System.Drawing.Size(55, 20)
        Me.rbtnDate.TabIndex = 1
        Me.rbtnDate.TabStop = True
        Me.rbtnDate.Text = "Date"
        Me.rbtnDate.UseVisualStyleBackColor = True
        '
        'rbtnNatureOfComplaint
        '
        Me.rbtnNatureOfComplaint.AutoSize = True
        Me.rbtnNatureOfComplaint.Checked = True
        Me.rbtnNatureOfComplaint.ForeColor = System.Drawing.Color.Black
        Me.rbtnNatureOfComplaint.Location = New System.Drawing.Point(69, 15)
        Me.rbtnNatureOfComplaint.Name = "rbtnNatureOfComplaint"
        Me.rbtnNatureOfComplaint.Size = New System.Drawing.Size(141, 20)
        Me.rbtnNatureOfComplaint.TabIndex = 0
        Me.rbtnNatureOfComplaint.TabStop = True
        Me.rbtnNatureOfComplaint.Text = "Nature of complaint"
        Me.rbtnNatureOfComplaint.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpDateEnd)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpDateStart)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 46)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(224, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "End date:"
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateEnd.Location = New System.Drawing.Point(298, 16)
        Me.dtpDateEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.Size = New System.Drawing.Size(104, 22)
        Me.dtpDateEnd.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Start date:"
        '
        'dtpDateStart
        '
        Me.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateStart.Location = New System.Drawing.Point(85, 16)
        Me.dtpDateStart.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateStart.Name = "dtpDateStart"
        Me.dtpDateStart.Size = New System.Drawing.Size(104, 22)
        Me.dtpDateStart.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Department:"
        '
        'cmbxDepartment
        '
        Me.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDepartment.FormattingEnabled = True
        Me.cmbxDepartment.Location = New System.Drawing.Point(110, 92)
        Me.cmbxDepartment.Name = "cmbxDepartment"
        Me.cmbxDepartment.Size = New System.Drawing.Size(300, 24)
        Me.cmbxDepartment.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblNotedby)
        Me.GroupBox3.Controls.Add(Me.lblReviewedby)
        Me.GroupBox3.Controls.Add(Me.lblPreparedby)
        Me.GroupBox3.Controls.Add(Me.cmbxPreparedBy)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbxReviewedBy)
        Me.GroupBox3.Controls.Add(Me.cmbxNotedBy)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 148)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report"
        '
        'lblNotedby
        '
        Me.lblNotedby.ForeColor = System.Drawing.Color.Black
        Me.lblNotedby.Location = New System.Drawing.Point(99, 100)
        Me.lblNotedby.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNotedby.Name = "lblNotedby"
        Me.lblNotedby.Size = New System.Drawing.Size(293, 16)
        Me.lblNotedby.TabIndex = 32
        Me.lblNotedby.Text = "notedby"
        Me.lblNotedby.Visible = False
        '
        'lblReviewedby
        '
        Me.lblReviewedby.ForeColor = System.Drawing.Color.Black
        Me.lblReviewedby.Location = New System.Drawing.Point(99, 58)
        Me.lblReviewedby.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblReviewedby.Name = "lblReviewedby"
        Me.lblReviewedby.Size = New System.Drawing.Size(293, 16)
        Me.lblReviewedby.TabIndex = 31
        Me.lblReviewedby.Text = "reviewedby"
        Me.lblReviewedby.Visible = False
        '
        'lblPreparedby
        '
        Me.lblPreparedby.ForeColor = System.Drawing.Color.Black
        Me.lblPreparedby.Location = New System.Drawing.Point(99, 14)
        Me.lblPreparedby.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPreparedby.Name = "lblPreparedby"
        Me.lblPreparedby.Size = New System.Drawing.Size(293, 16)
        Me.lblPreparedby.TabIndex = 28
        Me.lblPreparedby.Text = "preparedby"
        Me.lblPreparedby.Visible = False
        '
        'cmbxPreparedBy
        '
        Me.cmbxPreparedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxPreparedBy.FormattingEnabled = True
        Me.cmbxPreparedBy.Location = New System.Drawing.Point(101, 31)
        Me.cmbxPreparedBy.Name = "cmbxPreparedBy"
        Me.cmbxPreparedBy.Size = New System.Drawing.Size(301, 24)
        Me.cmbxPreparedBy.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Prepared by:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Reviewed by:"
        '
        'cmbxReviewedBy
        '
        Me.cmbxReviewedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxReviewedBy.FormattingEnabled = True
        Me.cmbxReviewedBy.Location = New System.Drawing.Point(102, 76)
        Me.cmbxReviewedBy.Name = "cmbxReviewedBy"
        Me.cmbxReviewedBy.Size = New System.Drawing.Size(300, 24)
        Me.cmbxReviewedBy.TabIndex = 26
        '
        'cmbxNotedBy
        '
        Me.cmbxNotedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxNotedBy.FormattingEnabled = True
        Me.cmbxNotedBy.Location = New System.Drawing.Point(102, 115)
        Me.cmbxNotedBy.Name = "cmbxNotedBy"
        Me.cmbxNotedBy.Size = New System.Drawing.Size(300, 24)
        Me.cmbxNotedBy.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 118)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Noted by:"
        '
        'frmPrintPrevToERC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(452, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEntry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintPrevToERC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Preview of Complaints to ERC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEntry As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbxReviewedBy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxPreparedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbxNotedBy As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNotedby As System.Windows.Forms.Label
    Friend WithEvents lblReviewedby As System.Windows.Forms.Label
    Friend WithEvents lblPreparedby As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnDate As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNatureOfComplaint As System.Windows.Forms.RadioButton
End Class
