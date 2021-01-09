<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintPrevByNOC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintPrevByNOC))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker()
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbxNOC = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbxNOC)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(582, 288)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpDateEnd)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpDateStart)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(566, 46)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(317, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "End date:"
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateEnd.Location = New System.Drawing.Point(391, 16)
        Me.dtpDateEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.Size = New System.Drawing.Size(168, 22)
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
        Me.dtpDateStart.Size = New System.Drawing.Size(164, 22)
        Me.dtpDateStart.TabIndex = 0
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
        Me.GroupBox3.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(566, 148)
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
        Me.cmbxPreparedBy.Size = New System.Drawing.Size(459, 24)
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
        Me.cmbxReviewedBy.Size = New System.Drawing.Size(458, 24)
        Me.cmbxReviewedBy.TabIndex = 26
        '
        'cmbxNotedBy
        '
        Me.cmbxNotedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxNotedBy.FormattingEnabled = True
        Me.cmbxNotedBy.Location = New System.Drawing.Point(102, 115)
        Me.cmbxNotedBy.Name = "cmbxNotedBy"
        Me.cmbxNotedBy.Size = New System.Drawing.Size(458, 24)
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
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Complaint_Management_System.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(498, 312)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 34)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEntry
        '
        Me.btnEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntry.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnEntry.Image = Global.Complaint_Management_System.My.Resources.Resources.printer
        Me.btnEntry.Location = New System.Drawing.Point(364, 312)
        Me.btnEntry.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(124, 34)
        Me.btnEntry.TabIndex = 8
        Me.btnEntry.Text = "Print Preview"
        Me.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Department:"
        '
        'cmbxNOC
        '
        Me.cmbxNOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxNOC.FormattingEnabled = True
        Me.cmbxNOC.Location = New System.Drawing.Point(109, 64)
        Me.cmbxNOC.Name = "cmbxNOC"
        Me.cmbxNOC.Size = New System.Drawing.Size(459, 24)
        Me.cmbxNOC.TabIndex = 32
        '
        'frmPrintPrevByNOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEntry)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrintPrevByNOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print preview by Nature of Complaint"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNotedby As System.Windows.Forms.Label
    Friend WithEvents lblReviewedby As System.Windows.Forms.Label
    Friend WithEvents lblPreparedby As System.Windows.Forms.Label
    Friend WithEvents cmbxPreparedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbxReviewedBy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxNotedBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEntry As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbxNOC As System.Windows.Forms.ComboBox
End Class
